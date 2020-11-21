# Compilador-miniJava
Como primer "filtro" en el analizador léxico se realiza una operación de sustitución a los comentarios, ya sean de una línea o multilínea con el método: ***replaceCommentsToNothing***, el cual tiene como parámetro una cadena. El argumento de este método es la lectura de todo el archivo, realizada en la clase Form1.cs en el método del botón de la interfaz de usuario ***analizeLex_btn_Click***.


Luego de obtener la cadena sin comentarios se realiza la llamada al método ***LexicalAnalysis***, recibiendo la cadena sin comentarios y el archivo original separado por *\n*, para poder realizar el conteo real de la línea a la que pertenecen los tokens analizados. El proceso de lectura consiste en leer caracter por caracter las líneas del archivo concatenando los caracteres en una variable temporal, se tienen indicadores lógicos que determinan si se está leyendo un string, entero, o tipo double. Al encontrar un espacio en blanco los caracteres acumulados en ***temp*** se envian a analizar al método ***Analysis***, hace distinción entre palabras reservadas, strings, double, int, constantes lógicas y la última comparación en este método son los identificadores. Si se encuentra un operador y la variable temporal tiene caracteres acumulados se analiza si la lectura actual pertenece a strings, si se está leyendo una cadena se siguen acumulando los caracteres; si se está leyendo un entero se verifica que el operador sea o no un punto, de ser así, la lectura de int da paso a lectura de double, siempre acumulando el siguiente caracter; por último, si ninguno de los indicadores está activado, se analizan los caracteres acumulados y se resta en 1 las iteraciones, para que la variable temporal sea la cadena vacía ("") y se vuelva a analizar el operador. Tanto palabras reservadas como operadores son analizados mediante un diccionario y una lista, correspondientemente, usando Linq para agilizar la consulta a las estructuras.


Como cadena de salida para cada token existen métodos con el sufijo *Format*, los cuales tienen como parámetros la cadena que se está analizando, la línea a la que pertenece y un contador para indicar el número de línea, la forma estándar cuando los token no tienen error se especifica con la siguiente estructura: Token + line + #línea + cols + #columnaInicio + #columnaFin + is + TipoToken. Se hace uso de las funciones de string para poder encontrar las columnas de inicio y fin del token en la línea, con la función *indexOf*. Dado que en una línea pueden existir operadores o símbolos de puntuación repetidos, se hace uso previo de *indexOf* para el caracter actual en la lectura y el método *Format* de los operadores recibe un parámetro adicional: ***index***. De esta manera, la función *indexOf* recibirá dos parámetros, el operador a analizar y el índice donde empezar a buscar en la cadena. En la segunda vuelta al analizar un operador (cuando temp es igual a ***""***) se verifica si la lista de operadores contiene el caracter actual y el caracter siguiente, de esta manera validar los símbolos (), {}, []; así como el símbolo de apertura y cierre de comentario multilínea. Al encontrar el símbolo de cierre de comentario se reporta un comentario multilínea sin emparejar, dado que estos ya han sido omitidos mediante expresiones regulares, si se encuentra un símbolo de apertura se procede a descontinuar el ciclo, dado que el resto del archivo está marcado como comentario, reportando el error: EOF en comentario.


El análisis de constantes de cadenas está dado por expresiones regulares que verifican si existe contenido entre comillas, luego se verifica que el contenido no haga *match* con una nueva línea, caracter nulo, si la cadena no tiene error se devuelve la cadena de respuesta con el formato anteriormente mencionado, si posee algún caracter inválido se devuelve el token el numero de línea y se recorre la cadena en caso de que existan múltiples caracteres inválidos, mostrándolos en la cadena de salida. Otra validación de cadenas es si no tienen comilla de cierre, se reporta el error y si la linea analizada es la última del archivo se reporta EOF en cadena.

Las expresiones regulares utilizadas son: 
* blockComments = @"/\*(.*?)\*/"
* lineComments = @"//(.*?)\r?\n"
* strings = @"""((\\[^\n]|[^""\n])*)"""
* verbatimStrings = @"@(""[^""]*"")+"
* pattern = "\\\"(.*?)\\\""
* pattern2 = "\\\"(.*)?"
* pattern3 = "[\0\r\n\\\"]"
*	idPattern = @"^[\$]*[A-Z]([A-Z0-9^\$])*\b"
* intPattern = @"(^[1-9]*\d+|(0x|0X)(\d|[a-fA-F])+)"
* doublePattern = @"(\d+\.\d*([eE][\+-]?\d+)?)"
* boolean = @"true|false"


Adicional a estas expresiones regulares, se cuenta con el método ***Validate***, que revisa que los caracteres sean válidos, cualquier caracter que no pertenezca a los especificados serán ignorados y reportados. El método utiliza la siguente expresión regular: ***@"[\w$\d\""]"***.


El manejo de errores incluye para los identificadores, si las cadenas analizadas no pertenecen a los identificadores se reportan como entradas no reconocidas, si los identificadores tienen una longitud que sobrepasa los 31 caracteres se truncan los siguientes y se reporta el error. El análisis de todos los tokens se muestra en pantalla además de generar dos archivos, uno general para la salida de todos los tokens y otro donde se reportan solo los errores, ambos generados en el directorio del proyecto: /bin/Debug/Outputs.

## Análisis sintáctico
Para esta fase agregamos un segundo proyecto a la solución, el cual fue nuestro generador de código para análisis sintáctico. En él, se lee la tabla de símbolos que trabajamos en format CSV, para poder reconocer cada estado, por cada estado crea una función con un nombre genérico, en esa función por cada desplazamiento agrega a la pila de estados el número que le va a la par. Por cada reducción quita de la pila los elementos y de los terminales también y los reemplaza por la parte izquierda de la producción. Por cada Ir_A se llama a la función y apila el número en la pila de estados.

Para utilizar las reducciones se utilizó en el proyecto CodeGen, un archivo CSV con el formato: NUMERO, PRODUCCIÓN, NUMERO DE SÍMBOLOS. En donde la primera columna correspondía al numero de producción, la segunda al lado izquierdo de la producción por el cual se tuvo que reducir y la tercera corresponde al numero de símbolos que se quitarán de la pila al reducir.


Tabla de análisis realizada y consumida por el proyecto: https://correo2urledu-my.sharepoint.com/:x:/g/personal/eapelaezc_correo_url_edu_gt/EbyUEJQogLNNglH6ThPWtYYBl3wp6KNUzSPBIpzeEKWNZg?e=5J2n5U

Estados generados: https://correo2urledu-my.sharepoint.com/:x:/g/personal/eapelaezc_correo_url_edu_gt/ES9vlWRT9tVOsxHed3KZ29cBiq1HWiWLsqkKTBQwzj3e_g?e=FdUZJI

## Análisis semántico
Para esta fase se implemetó la tabla de símbolos como un diccionario llave,valor. Este diccionario nos permitiría segmentar las variables bajo diferentes ámbitos (segmentos de código aislados dentro de uno segmento padre). La llave de esta estructura es una llave compuesta conformada por el ámbito y el nombre de la variable/función ***idÁmbito,Nombre***. El valor del diccionario comprendería una serie de valores tales como ***tipo|valor|base|argumentos***

A continuación se explica cada campo:
* idÁmbito - cadena la cual nos indica un correlativo numérico si es un bloque de función o un correlativo alfanumérico si está en un bloque de una estructura selectiva o ciclica, por ejemplo: ***while1, for3, if4, else1***.
* Nombre - cadena la cual nos indica cuál es el identificador de una variable
* tipo - con valores numéricos del 0 al 5 tal que:
  * 0 = null
  * 1 = int
  * 2 = double
  * 3 = boolean
  * 4 = string
  * 5 = void
* valor - cadena equivalente al valor de la variable, por ejemplo: "false" para el valor booleano false
* base - valor numérico de 0 a 2 tal que:
  * 0 = NaN (not a number)
  * 1 = decimal
  * 2 = hexadecimal
* argumentos - arreglo de enteros el cual nos indica de qué tipo son los argumentos de una función. Por ejemplo:
  * para int foo(int param1, double param2, boolean param3), argumentos sería una cadena "123"
  
Para esta tabla se implementaron métodos CRUD para facilitar el manejo de la misma, adicionando la implementación de una clase objeto que contiene los mismos atributos parseados a sus respectivos tipos.

## Fuentes 
*Regex Class* (s.f.) Microsoft Documentation. Recuperado de: https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex?view=netcore-3.1.



*Regex para eliminar los comentarios de línea de C #* it-swarm.dev. Recuperado de: https://www.it-swarm.dev/es/c%23/regex-para-eliminar-los-comentarios-de-linea-de-c/969223761/.
