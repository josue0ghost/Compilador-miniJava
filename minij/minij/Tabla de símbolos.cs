using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minij
{
    class Tabla_de_símbolos
    {
        /* table struct
         * idAmbito, name | type | value | _base | argsTypesArray
         */

        public Dictionary<string, string> table = new Dictionary<string, string>();
        public string err { get; set; }

        /// <summary>
        /// Inserta un registro en el diccionario de la tabla de símbolos
        /// </summary>
        /// <param name="symbol">objeto TDSobj</param>
        public void Insert(TDSobj symbol)
        {
            string key = symbol.idAmbito + "," + symbol.name;
            string value = symbol.type.ToString() + "|" + symbol.value + "|" + symbol._base + "|";

            if (symbol.args != null)
            {
                foreach (var item in symbol.args)
                {
                    /* Debido a que los id de tipos se identifican con números del 0 al 5
                     * es posible únicamente concatenarlos y separarlos por caracter para análisis
                     */
                    value += item.ToString();
                }
            }
            else
            {
                value += "NULL";
            }


            if (!table.ContainsKey(key))
            {
                table.Add(key, value);
            }
            else
            {
                this.err = "Ya se había de clarado una variable o constante con el mismo nombre";
            }
        }

        /// <summary>
        /// Elimina un registro del diccionario de la tabla de símbolos
        /// </summary>
        /// <param name="symbol">objeto TDSobj</param>
        public void Delete(TDSobj symbol)
        {
            string key = symbol.idAmbito + "," + symbol.name;

            if (table.ContainsKey(key))
            {
                table.Remove(key);
            }
            else
            {
                this.err = "El objeto que se intentó eliminar no existe en la tabla";
            }
        }

        /// <summary>
        /// Eliminar un registro del diccionario de la tabla de símbolos
        /// </summary>
        /// <param name="idAmbito">identificador del ámbito actual</param>
        /// <param name="name">nombre de la variable o constante</param>
        public void Delete(string idAmbito, string name)
        {
            string key = idAmbito + "," + name;

            if (table.ContainsKey(key))
            {
                table.Remove(key);
            }
            else
            {
                this.err = "El objeto que se intentó eliminar no existe en la tabla";
            }
        }

        /// <summary>
        /// Modifica un símbolo existente en la tabla
        /// </summary>
        /// <param name="idAmbito">Número identificador del ámbito actual</param>
        /// <param name="name">Nombre de la variable que se modifica</param>
        /// <param name="newValue">Nuevo valor para la variable</param>
        public void Update(string idAmbito, string name, string newValue)
        {
            TDSobj aux = Search(idAmbito, name);

            if (aux != null)
            {
                string key = idAmbito + "," + name;
                aux.value = newValue;

                string value = aux.type.ToString() + "|" + aux.value + "|" + aux._base + "|";

                if (aux.args != null)
                {
                    foreach (var item in aux.args)
                    {
                        /* Debido a que los id de tipos se identifican con números del 0 al 5
                         * es posible únicamente concatenarlos y separarlos por caracter para análisis
                         */
                        value += item.ToString();
                    }
                }
                else
                {
                    value += "NULL";
                }

                table[key] = value;
            }
            else
            {
                this.err = "No se pudo encontrar la variable " + name + "en el ámbito actual";
            }
        }

        /// <summary>
        /// Búsqueda de un registro en el diccionario de la tabla de símbolos
        /// </summary>
        /// <param name="symbol">objeto TDSobj</param>
        /// <returns>TDSobj si encuentra un registro con la misma llave, null si no fue encontrado</returns>
        public TDSobj Search(TDSobj symbol)
        {
            string key = symbol.idAmbito + "," + symbol.name;

            if (table.ContainsKey(key))
            {
                table.TryGetValue(key, out string value);
                string[] vals = value.Split('|');
                List<string> sTypes = vals[3].Split().ToList();
                List<int> iTypes = new List<int>();
                foreach (var item in sTypes)
                {
                    iTypes.Add(int.Parse(item));
                }

                TDSobj obj = new TDSobj(symbol.idAmbito, symbol.name, int.Parse(vals[0]), vals[1], int.Parse(vals[2]), iTypes.ToArray());
                return obj;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Búsqueda de un registro en el diccionario de la tabla de símbolos
        /// </summary>
        /// <param name="idAmbito">Número identificador del ámbito actual</param>
        /// <returns>TDSobj si encuentra un registro con la misma llave, null si no fue encontrado</returns>
        public TDSobj Search(string idAmbito, string name)
        {
            string key = idAmbito.ToString() + "," + name;

            if (table.ContainsKey(key))
            {
                table.TryGetValue(key, out string value);
                string[] vals = value.Split('|');
                List<string> sTypes = vals[3].Split().ToList();
                List<int> iTypes = new List<int>();
                foreach (var item in sTypes)
                {
                    iTypes.Add(int.Parse(item));
                }

                TDSobj obj = new TDSobj(idAmbito.ToString(), name, int.Parse(vals[0]), vals[1], int.Parse(vals[2]), iTypes.ToArray());
                return obj;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Compara tipos de dos variables en un mismo ámbito
        /// </summary>
        /// <param name="idAmbito">Número identificador del ámbito actual</param>
        /// <param name="varName1">Nombre de la primera variable o constante</param>
        /// <param name="varName2">Nombre de la segunda variable o constante</param>
        /// <returns>true si ambos tipos son iguales</returns>
        public bool compareTypes(string idAmbito, string varName1, string varName2)
        {
            TDSobj var1 = Search(idAmbito, varName1);
            TDSobj var2 = Search(idAmbito, varName2);

            if (var1 != null)
            {
                if (var2 != null)
                {
                    if (var1.type == var2.type)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    this.err = "La variable o constante con el nombre " + varName2 + " no existe en el contexto actual";
                    return false;
                }
            }
            else
            {
                this.err = "La variable o constante con el nombre " + varName1 + " no existe en el contexto actual";
                return false;
            }
        }

        /// <summary>
        /// Compara el tipo de una variable con un valor que se le asigna
        /// </summary>
        /// <param name="idAmbito">Número identificador del ámbito actual</param>
        /// <param name="varName1">Nombre de la varialbe o constante</param>
        /// <param name="typeOfValue">Identificador del tipo de dato que se le asigna a <paramref name="varName1"/></param>
        /// <returns></returns>
        public bool compareTypes(string idAmbito, string varName1, int typeOfValue)
        {
            TDSobj var1 = Search(idAmbito, varName1);

            if (var1 != null)
            {
                if (var1.type == typeOfValue) // mismos tipos
                {
                    return true;
                }
                else if (var1.type == 2 && typeOfValue == 1) // asignacion de entero (type 1) a un double (type 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                this.err = "La variable o constante con el nombre " + varName1 + " no existe en el contexto actual";
                return false;
            }
        }

        /// <summary>
        /// Traducción de un valor tipo int a una variable o constante double
        /// </summary>
        /// <param name="idAmbito">Número identificador del ámbito actual</param>
        /// <param name="varName">Nombre de la variable o constante</param>
        /// <param name="varName2">Nombre de la variable o constante que se le asigna a <paramref name="varName"/></param>
        public void tradIntToDouble(string idAmbito, string varName, string varName2, int x = 0)
        {
            TDSobj var1 = Search(idAmbito, varName);

            if (var1 != null)
            {
                if (var1.type == 2)
                {
                    TDSobj var2 = Search(idAmbito, varName2);

                    if (var2 != null)
                    {
                        string key = idAmbito + "," + varName;
                        string[] data = table[key].Split('|');
                        if (var2.type == 1)
                        {
                            data[1] = var2.value + ".0";
                            string newVal = data[0] + "|" + data[1] + "|" + data[2] + "|" + data[3];
                            // cambio de atributos
                            table[key] = newVal;
                        }
                        else
                        {
                            this.err = varName2 + " no es de tipo 'double' o 'int'";
                        }
                    }
                    else
                    {
                        this.err = varName2 + " no existe en el contexto actual";
                    }
                }
                else
                {
                    this.err = varName + " no es de tipo 'double' o 'int'";
                }
            }
            else
            {
                this.err = varName + " no existe en el contexto actual";
            }
        }

        /// <summary>
        /// Traducción de un valor tipo int a una variable o constante double
        /// </summary>
        /// <param name="idAmbito">Número identificador del ámbito actual</param>
        /// <param name="varName">Nombre de la variable o constante</param>
        /// <param name="intValue">Valor que se le asigna a <paramref name="varName"/></param>
        public void tradIntToDouble(string idAmbito, string varName, string intValue)
        {
            TDSobj var1 = Search(idAmbito, varName);
            string key = idAmbito + "," + varName;

            if (var1 != null)
            {
                string[] data = table[key].Split('|');

                if (var1.type == 2)
                {
                    if (int.TryParse(intValue, out _))
                    {
                        data[1] = intValue + ".0";
                        string newVal = data[0] + "|" + data[1] + "|" + data[2] + "|" + data[3];
                        // cambio de atributos
                        table[key] = newVal;
                    }
                    else
                    {
                        this.err = intValue + " no es de tipo 'double' o 'int'";
                    }
                }
                else
                {
                    this.err = varName + " no es de tipo 'double' o 'int'";
                }
            }
            else
            {
                this.err = varName + " no existe en el contexto actual";
            }
        }

        /// <summary>
        /// Compara los tipos de los parámetros de una función con los parámetros enviados
        /// </summary>
        /// <param name="idAmbito">Número identificador del ámbito actual</param>
        /// <param name="funcName">Nombre de la función</param>
        /// <param name="sendedArgs">Arreglo de tipos de los parámetros enviados</param>
        /// <returns>true si los argumentos son del mismo tipo y en la misma cantidad</returns>
        public bool compareArguments(string idAmbito, string funcName, int[] sendedArgs)
        {
            TDSobj var1 = Search(idAmbito, funcName);

            if (var1 != null)
            {
                if (sendedArgs.Length == var1.args.Length)
                {
                    for (int i = 0; i < sendedArgs.Length; i++)
                    {
                        if (sendedArgs[i] != var1.args[i])
                        {
                            this.err = "Un argumento de la función " + funcName + " es inválido";
                            return false;
                        }
                    }
                    return true;
                }
                else
                {
                    this.err = "La función " + funcName + " no acepta la cantidad de argumentos enviados";
                    return false;
                }
            }

            this.err = funcName + " no existe en el contexto actual";
            return false;
        }

        /// <summary>
        /// Realiza la operación entre dos valores
        /// </summary>
        /// <param name="signOp">Signo de la operación</param>
        /// <param name="op1">Valor o nombre de la variable operanda 1</param>
        /// <param name="op2">Valor o nombre de la variable operanda 1</param>
        /// <param name="idAmbito">Opcional, número identificador del ámbito actual</param>
        /// <returns>TDSobj con el atributo value igual a la operación realizada</returns>
        public TDSobj doOperation(string signOp, string op1, string op2, string idAmbito = "0")
        {
            TDSobj var1 = Search(idAmbito, op1);
            TDSobj var2 = Search(idAmbito, op2);
            TDSobj result = new TDSobj();

            if (var1 != null && var2 != null) // ambos son variables
            {
                operate(var1, var2, signOp, idAmbito);
            }
            else if (var1 != null) // solo op1 es una variable
            {
                if (int.TryParse(op2, out _))
                {
                    var2 = new TDSobj(idAmbito, "temp", 1, op2);
                }
                else if (double.TryParse(op2, out _))
                {
                    var2 = new TDSobj(idAmbito, "temp", 2, op2);
                }
                else if (op2 == "true" || op2 == "false")
                {
                    var2 = new TDSobj(idAmbito, "temp", 3, op2);
                }
                else // string type
                {
                    var2 = new TDSobj(idAmbito, "temp", 4, op2);
                }
                result = operate(var1, var2, signOp, idAmbito);
            }
            else if (var2 != null) // solo op2 es una variable
            {
                if (int.TryParse(op1, out _))
                {
                    var1 = new TDSobj(idAmbito, "temp", 1, op1);
                }
                else if (double.TryParse(op1, out _))
                {
                    var1 = new TDSobj(idAmbito, "temp", 2, op1);
                }
                else if (op1 == "true" || op1 == "false")
                {
                    var1 = new TDSobj(idAmbito, "temp", 3, op1);
                }
                else // string type
                {
                    var1 = new TDSobj(idAmbito, "temp", 4, op1);
                }
                result = operate(var1, var2, signOp, idAmbito);
            }
            else // ni op1 ni op2 son variables
            {
                if (int.TryParse(op1, out _))
                {
                    var1 = new TDSobj(idAmbito, "temp", 1, op1);
                }
                else if (double.TryParse(op1, out _))
                {
                    var1 = new TDSobj(idAmbito, "temp", 2, op1);
                }
                else if (op1 == "true" || op1 == "false")
                {
                    var1 = new TDSobj(idAmbito, "temp", 3, op1);
                }
                else // string type
                {
                    var1 = new TDSobj(idAmbito, "temp", 4, op1);
                }

                if (int.TryParse(op2, out _))
                {
                    var2 = new TDSobj(idAmbito, "temp", 1, op2);
                }
                else if (double.TryParse(op2, out _))
                {
                    var2 = new TDSobj(idAmbito, "temp", 2, op2);
                }
                else if (op2 == "true" || op2 == "false")
                {
                    var2 = new TDSobj(idAmbito, "temp", 3, op2);
                }
                else // string type
                {
                    var2 = new TDSobj(idAmbito, "temp", 4, op2);
                }
                result = operate(var1, var2, signOp, idAmbito);
            }

            return result;
        }

        private TDSobj operate(TDSobj var1, TDSobj var2, string operacion, string idAmbito = "0")
        {
            TDSobj result = new TDSobj();
            switch (operacion)
            {
                case "+": // suma o concatenación

                    if (var1.type == var2.type)
                    {
                        switch (var1.type)
                        {
                            case 0:
                                this.err = "Error de referencia a valor nulo";
                                break;

                            case 1: // int
                                if (var1._base == var2._base)
                                {
                                    int iVal = int.Parse(var1.value) + int.Parse(var2.value);
                                    result = new TDSobj(idAmbito, "temp", 1, iVal.ToString());
                                }
                                else
                                {
                                    this.err = "Intento de operación sobre enteros de diferente base";
                                }
                                break;

                            case 2: // double
                                double dVal = double.Parse(var1.value) + double.Parse(var2.value);
                                result = new TDSobj(idAmbito, "temp", 1, dVal.ToString());
                                break;

                            case 4: // string concatenación
                                string sVal = var1.value + var2.value;
                                result = new TDSobj(idAmbito, "temp", 1, sVal);
                                break;

                            default:
                                this.err = "Operación inválida sobre tipos";
                                break;
                        }
                    }
                    else if ((var1.type == 1 && var2.type == 2) || (var1.type == 2 && var2.type == 1))
                    {
                        double dVal = double.Parse(var1.value) + double.Parse(var2.value);
                        result = new TDSobj(idAmbito, "temp", 1, dVal.ToString());
                    }
                    else
                    {
                        this.err = "Operación inválida sobre tipos diferentes";
                    }
                    break;

                case "-":

                    if (var1.type == var2.type)
                    {
                        switch (var1.type)
                        {
                            case 0:
                                this.err = "Error de referencia a valor nulo";
                                break;

                            case 1: // int
                                if (var1._base == var2._base)
                                {
                                    int iVal = int.Parse(var1.value) - int.Parse(var2.value);
                                    result = new TDSobj(idAmbito, "temp", 1, iVal.ToString());
                                }
                                else
                                {
                                    this.err = "Intento de operación sobre enteros de diferente base";
                                }
                                break;

                            case 2: // double
                                double dVal = double.Parse(var1.value) - double.Parse(var2.value);
                                result = new TDSobj(idAmbito, "temp", 1, dVal.ToString());
                                break;

                            default:
                                this.err = "Operación inválida sobre tipos";
                                break;
                        }
                    }
                    else if ((var1.type == 1 && var2.type == 2) || (var1.type == 2 && var2.type == 1))
                    {
                        double dVal = double.Parse(var1.value) - double.Parse(var2.value);
                        result = new TDSobj(idAmbito, "temp", 1, dVal.ToString());
                    }
                    else
                    {
                        this.err = "Operación inválida sobre tipos diferentes";
                    }
                    break;

                case "*":

                    if (var1.type == var2.type)
                    {
                        switch (var1.type)
                        {
                            case 0:
                                this.err = "Error de referencia a valor nulo";
                                break;

                            case 1: // int
                                if (var1._base == var2._base)
                                {
                                    int iVal = int.Parse(var1.value) * int.Parse(var2.value);
                                    result = new TDSobj(idAmbito, "temp", 1, iVal.ToString());
                                }
                                else
                                {
                                    this.err = "Intento de operación sobre enteros de diferente base";
                                }
                                break;

                            case 2: // double
                                double dVal = double.Parse(var1.value) * double.Parse(var2.value);
                                result = new TDSobj(idAmbito, "temp", 1, dVal.ToString());
                                break;

                            default:
                                this.err = "Operación inválida sobre tipos";
                                break;
                        }
                    }
                    else if ((var1.type == 1 && var2.type == 2) || (var1.type == 2 && var2.type == 1))
                    {
                        double dVal = double.Parse(var1.value) * double.Parse(var2.value);
                        result = new TDSobj(idAmbito, "temp", 1, dVal.ToString());
                    }
                    else
                    {
                        this.err = "Operación inválida sobre tipos diferentes";
                    }
                    break;

                case "/":

                    if (var1.type == var2.type)
                    {
                        switch (var1.type)
                        {
                            case 0:
                                this.err = "Error de referencia a valor nulo";
                                break;

                            case 1: // int
                                if (var1._base == var2._base)
                                {
                                    int iVal = int.Parse(var1.value) / int.Parse(var2.value);
                                    result = new TDSobj(idAmbito, "temp", 1, iVal.ToString());
                                }
                                else
                                {
                                    this.err = "Intento de operación sobre enteros de diferente base";
                                }
                                break;

                            case 2: // double
                                double dVal = double.Parse(var1.value) / double.Parse(var2.value);
                                result = new TDSobj(idAmbito, "temp", 1, dVal.ToString());
                                break;

                            default:
                                this.err = "Operación inválida sobre tipos";
                                break;
                        }
                    }
                    else if ((var1.type == 1 && var2.type == 2) || (var1.type == 2 && var2.type == 1))
                    {
                        double dVal = double.Parse(var1.value) / double.Parse(var2.value);
                        result = new TDSobj(idAmbito, "temp", 1, dVal.ToString());
                    }
                    else
                    {
                        this.err = "Operación inválida sobre tipos diferentes";
                    }
                    break;

                case "%":
                    if (var1.type == var2.type)
                    {
                        switch (var1.type)
                        {
                            case 0:
                                this.err = "Error de referencia a valor nulo";
                                break;

                            case 1: // int
                                if (var1._base == var2._base)
                                {
                                    int iVal = int.Parse(var1.value) % int.Parse(var2.value);
                                    result = new TDSobj(idAmbito, "temp", 1, iVal.ToString());
                                }
                                else
                                {
                                    this.err = "Intento de operación sobre enteros de diferente base";
                                }
                                break;

                            case 2: // double
                                double dVal = double.Parse(var1.value) % double.Parse(var2.value);
                                result = new TDSobj(idAmbito, "temp", 1, dVal.ToString());
                                break;

                            default:
                                this.err = "Operación inválida sobre tipos";
                                break;
                        }
                    }
                    else if ((var1.type == 1 && var2.type == 2) || (var1.type == 2 && var2.type == 1))
                    {
                        double dVal = double.Parse(var1.value) % double.Parse(var2.value);
                        result = new TDSobj(idAmbito, "temp", 1, dVal.ToString());
                    }
                    else
                    {
                        this.err = "Operación inválida sobre tipos diferentes";
                    }
                    break;

                case "&&":

                    if (var1.type == var2.type)
                    {
                        switch (var1.type)
                        {
                            case 0:
                                this.err = "Error de referencia a valor nulo";
                                break;

                            case 3: // boolean
                                bool b1 = (var1.value == "true") ? true : false;
                                bool b2 = (var2.value == "true") ? true : false;
                                bool bVal = b1 && b2;

                                result = new TDSobj(idAmbito, "temp", 1, bVal.ToString());
                                break;

                            default:
                                this.err = "Operación inválida sobre tipos no booleanos";
                                break;
                        }
                    }
                    else
                    {
                        this.err = "Operación inválida sobre tipos diferentes no booleanos";
                    }
                    break;

                case "||":

                    if (var1.type == var2.type)
                    {
                        switch (var1.type)
                        {
                            case 0:
                                this.err = "Error de referencia a valor nulo";
                                break;

                            case 3: // boolean
                                bool b1 = (var1.value == "true") ? true : false;
                                bool b2 = (var2.value == "true") ? true : false;
                                bool bVal = b1 || b2;

                                result = new TDSobj(idAmbito, "temp", 1, bVal.ToString());
                                break;

                            default:
                                this.err = "Operación inválida sobre tipos no booleanos";
                                break;
                        }
                    }
                    else
                    {
                        this.err = "Operación inválida sobre tipos diferentes no booleanos";
                    }
                    break;

                case "==":
                    if (var1.type == var2.type)
                    {
                        switch (var1.type)
                        {
                            case 0:
                                this.err = "Error de referencia a valor nulo";
                                break;

                            case 1: // int
                                if (var1._base == var2._base)
                                {
                                    bool biVal = int.Parse(var1.value) == int.Parse(var2.value);
                                    result = new TDSobj(idAmbito, "temp", 1, biVal.ToString());
                                }
                                else
                                {
                                    this.err = "Intento de operación sobre enteros de diferente base";
                                }
                                break;

                            case 2: // double
                                bool bdVal = double.Parse(var1.value) == double.Parse(var2.value);
                                result = new TDSobj(idAmbito, "temp", 1, bdVal.ToString());
                                break;

                            case 3: // boolean
                                bool b1 = (var1.value == "true") ? true : false;
                                bool b2 = (var2.value == "true") ? true : false;
                                bool bVal = b1 == b2;

                                result = new TDSobj(idAmbito, "temp", 1, bVal.ToString());
                                break;
                            default:
                                this.err = "Operación inválida sobre tipos";
                                break;
                        }
                    }
                    else
                    {
                        this.err = "Operación inválida sobre tipos diferentes";
                    }
                    break;

                case "!=":
                    if (var1.type == var2.type)
                    {
                        switch (var1.type)
                        {
                            case 0:
                                this.err = "Error de referencia a valor nulo";
                                break;

                            case 1: // int
                                if (var1._base == var2._base)
                                {
                                    bool biVal = int.Parse(var1.value) != int.Parse(var2.value);
                                    result = new TDSobj(idAmbito, "temp", 1, biVal.ToString());
                                }
                                else
                                {
                                    this.err = "Intento de operación sobre enteros de diferente base";
                                }
                                break;

                            case 2: // double
                                bool bdVal = double.Parse(var1.value) != double.Parse(var2.value);
                                result = new TDSobj(idAmbito, "temp", 1, bdVal.ToString());
                                break;

                            case 3: // boolean
                                bool b1 = (var1.value == "true") ? true : false;
                                bool b2 = (var2.value == "true") ? true : false;
                                bool bVal = b1 != b2;

                                result = new TDSobj(idAmbito, "temp", 1, bVal.ToString());
                                break;
                            default:
                                this.err = "Operación inválida sobre tipos";
                                break;
                        }
                    }
                    else
                    {
                        this.err = "Operación inválida sobre tipos diferentes";
                    }
                    break;

                case "<":
                    if (var1.type == var2.type)
                    {
                        switch (var1.type)
                        {
                            case 0:
                                this.err = "Error de referencia a valor nulo";
                                break;

                            case 1: // int
                                if (var1._base == var2._base)
                                {
                                    bool biVal = int.Parse(var1.value) < int.Parse(var2.value);
                                    result = new TDSobj(idAmbito, "temp", 1, biVal.ToString());
                                }
                                else
                                {
                                    this.err = "Intento de operación sobre enteros de diferente base";
                                }
                                break;

                            case 2: // double
                                bool bdVal = double.Parse(var1.value) < double.Parse(var2.value);
                                result = new TDSobj(idAmbito, "temp", 1, bdVal.ToString());
                                break;

                            default:
                                this.err = "Operación inválida sobre tipos";
                                break;
                        }
                    }
                    else
                    {
                        this.err = "Operación inválida sobre tipos diferentes";
                    }
                    break; 

                case ">":
                    if (var1.type == var2.type)
                    {
                        switch (var1.type)
                        {
                            case 0:
                                this.err = "Error de referencia a valor nulo";
                                break;

                            case 1: // int
                                if (var1._base == var2._base)
                                {
                                    bool biVal = int.Parse(var1.value) > int.Parse(var2.value);
                                    result = new TDSobj(idAmbito, "temp", 1, biVal.ToString());
                                }
                                else
                                {
                                    this.err = "Intento de operación sobre enteros de diferente base";
                                }
                                break;

                            case 2: // double
                                bool bdVal = double.Parse(var1.value) > double.Parse(var2.value);
                                result = new TDSobj(idAmbito, "temp", 1, bdVal.ToString());
                                break;

                            default:
                                this.err = "Operación inválida sobre tipos";
                                break;
                        }
                    }
                    else
                    {
                        this.err = "Operación inválida sobre tipos diferentes";
                    }
                    break;

                case ">=":
                    if (var1.type == var2.type)
                    {
                        switch (var1.type)
                        {
                            case 0:
                                this.err = "Error de referencia a valor nulo";
                                break;

                            case 1: // int
                                if (var1._base == var2._base)
                                {
                                    bool biVal = int.Parse(var1.value) >= int.Parse(var2.value);
                                    result = new TDSobj(idAmbito, "temp", 1, biVal.ToString());
                                }
                                else
                                {
                                    this.err = "Intento de operación sobre enteros de diferente base";
                                }
                                break;

                            case 2: // double
                                bool bdVal = double.Parse(var1.value) >= double.Parse(var2.value);
                                result = new TDSobj(idAmbito, "temp", 1, bdVal.ToString());
                                break;

                            default:
                                this.err = "Operación inválida sobre tipos";
                                break;
                        }
                    }
                    else
                    {
                        this.err = "Operación inválida sobre tipos diferentes";
                    }
                    break;

                case "<=":
                    if (var1.type == var2.type)
                    {
                        switch (var1.type)
                        {
                            case 0:
                                this.err = "Error de referencia a valor nulo";
                                break;

                            case 1: // int
                                if (var1._base == var2._base)
                                {
                                    bool biVal = int.Parse(var1.value) <= int.Parse(var2.value);
                                    result = new TDSobj(idAmbito, "temp", 1, biVal.ToString());
                                }
                                else
                                {
                                    this.err = "Intento de operación sobre enteros de diferente base";
                                }
                                break;

                            case 2: // double
                                bool bdVal = double.Parse(var1.value) <= double.Parse(var2.value);
                                result = new TDSobj(idAmbito, "temp", 1, bdVal.ToString());
                                break;

                            default:
                                this.err = "Operación inválida sobre tipos";
                                break;
                        }
                    }
                    else
                    {
                        this.err = "Operación inválida sobre tipos diferentes";
                    }
                    break;
                
                default:
                    this.err = "Operador inválido";
                    break;
            }

            return result;
        }

        public void writeTable() {
            string basePath = string.Format(@"{0}Outputs\", AppContext.BaseDirectory);
            DirectoryInfo directory = Directory.CreateDirectory(basePath);

            // table format
            //string key = symbol.idAmbito.ToString() + "," + symbol.name;
            //string value = symbol.type.ToString() + "|" + symbol.value + "|" + symbol._base + "|";

            using (StreamWriter file = new StreamWriter(basePath + "TablaDeSimbolos.txt"))
            {
                file.WriteLine("ambito, name => type|value|base|");
                for (int i = 0; i < table.Count; i++)
                {
                    file.WriteLine(table.Keys.ElementAt(i) + " => " + table.Values.ElementAt(i));
                }
                file.Close();
            }
        }
    }
}
