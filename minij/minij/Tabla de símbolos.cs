using System;
using System.Collections.Generic;
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
            string key = symbol.idAmbito.ToString() + "," + symbol.name;
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
            string key = symbol.idAmbito.ToString() + "," + symbol.name;

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
        public void Delete(int idAmbito, string name)
        {
            string key = idAmbito.ToString() + "," + name;

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
        /// Búsqueda de un registro en el diccionario de la tabla de símbolos
        /// </summary>
        /// <param name="symbol">objeto TDSobj</param>
        /// <returns>TDSobj si encuentra un registro con la misma llave, null si no fue encontrado</returns>
        public TDSobj Search(TDSobj symbol)
        {
            string key = symbol.idAmbito.ToString() + "," + symbol.name;

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
        public TDSobj Search(int idAmbito, string name)
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

                TDSobj obj = new TDSobj(idAmbito, name, int.Parse(vals[0]), vals[1], int.Parse(vals[2]), iTypes.ToArray());
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
        public bool compareTypes(int idAmbito, string varName1, string varName2)
        {
            string key1 = idAmbito.ToString() + "," + varName1;
            string key2 = idAmbito.ToString() + "," + varName2;

            if (table.TryGetValue(key1, out string val1))
            {
                if (table.TryGetValue(key2, out string val2))
                {
                    string[] data1 = val1.Split('|');
                    string[] data2 = val2.Split('|');

                    if (data1[0] == data2[0])
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
        public bool compareTypes(int idAmbito, string varName1, int typeOfValue)
        {
            string key1 = idAmbito.ToString() + "," + varName1;

            if (table.TryGetValue(key1, out string val1))
            {
                string[] data1 = val1.Split('|');

                if (data1[0] == typeOfValue.ToString()) // mismos tipos
                {
                    return true;
                }
                else if (data1[0] == "2" && typeOfValue == 1) // asignacion de entero (type 1) a un double (type 2)
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
        public void tradIntToDouble(int idAmbito, string varName, string varName2, int x = 0)
        {
            string key = idAmbito + "," + varName;

            if (table.TryGetValue(key, out string values))
            {
                string[] data = values.Split('|');

                if (data[0] == "2")
                {
                    string key2 = idAmbito + "," + varName2;
                    if (table.TryGetValue(key2, out string values2))
                    {
                        string[] data2 = values2.Split('|');
                        if (data2[0] == "1")
                        {
                            data[1] = data2[1] + ".0";
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
        public void tradIntToDouble(int idAmbito, string varName, string intValue)
        {
            string key = idAmbito + "," + varName;

            if (table.TryGetValue(key, out string values))
            {
                string[] data = values.Split('|');

                if (data[0] == "2")
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
        /// <returns></returns>
        public bool compareArguments(int idAmbito, string funcName, int[] sendedArgs)
        {
            string key = idAmbito + "," + funcName;

            if (table.ContainsKey(key))
            {
                string[] data = table[key].Split('|');
                List<string> funcArgs = data[3].Split().ToList();
                List<int> iTypes = new List<int>();
                foreach (var item in funcArgs)
                {
                    iTypes.Add(int.Parse(item));
                }
                int[] funcArgTypes = iTypes.ToArray();

                if (sendedArgs.Length == funcArgTypes.Length)
                {
                    for (int i = 0; i < sendedArgs.Length; i++)
                    {
                        if (sendedArgs[i] != funcArgTypes[i])
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
        /// Realiza la operación entre dos datos
        /// </summary>
        /// <param name="signOp"></param>
        /// <param name="op1"></param>
        /// <param name="op2"></param>
        public void doOperation(string signOp, string op1, string op2)
        {
            switch (signOp)
            {
                case "+":
                    break;
                case "-":
                    break;
                case "*":
                    break;
                case "/":
                    break;
                case "==":
                    break;
                case "&&":
                    break;
                case "||":
                    break;
                default:
                    break;
            }
        }
    }
}
