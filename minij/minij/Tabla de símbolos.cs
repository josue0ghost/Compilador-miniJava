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
         * idAmbito, name | type | value | _base
         */

        public Dictionary<string, string> table = new Dictionary<string, string>();

        public void Insert(TDSobj symbol)
        {
            string key = symbol.idAmbito.ToString() + "," + symbol.name;
            string value = symbol.type.ToString() + "," + symbol.value + "," + symbol._base;

            if (!table.ContainsKey(key))
            {
                table.Add(key, value);
            }
            else
            {
                // error
            }
        }

        public void Delete(TDSobj symbol)
        {
            string key = symbol.idAmbito.ToString() + "," + symbol.name;

            if (table.ContainsKey(key))
            {
                table.Remove(key);
            }
            else
            {
                // error
            }
        }

        public void Delete(int idAmbito, string name)
        {
            string key = idAmbito.ToString() + "," + name;

            if (table.ContainsKey(key))
            {
                table.Remove(key);
            }
            else
            {
                // error
            }
        }

        public TDSobj Search(TDSobj symbol)
        {
            string key = symbol.idAmbito.ToString() + "," + symbol.name;

            if (table.ContainsKey(key))
            {
                table.TryGetValue(key, out string value);
                string[] vals = value.Split(',');
                TDSobj obj = new TDSobj(int.Parse(vals[0]), vals[1], vals[2], int.Parse(vals[3]));
                return obj;
            }
            else
            {
                return null;
            }
        }

        public TDSobj Search(int idAmbito, string name)
        {
            string key = idAmbito.ToString() + "," + name;

            if (table.ContainsKey(key))
            {
                table.TryGetValue(key, out string value);
                string[] vals = value.Split(',');
                TDSobj obj = new TDSobj(int.Parse(vals[0]), vals[1], vals[2], int.Parse(vals[3]));
                return obj;
            }
            else
            {
                return null;
            }
        }
        
        public bool compareTypes(int idAmbito, string varName1, string varName2)
        {
            string key1 = idAmbito.ToString() + "," + varName1;
            string key2 = idAmbito.ToString() + "," + varName2;

            if (table.TryGetValue(key1, out string val1))
            {
                if (table.TryGetValue(key2, out string val2))
                {
                    string[] data1 = val1.Split(',');
                    string[] data2 = val2.Split(',');

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
                    //error, no existe la variable 2
                    return false;
                }
            }
            else
            {
                // error, no existe la variable 1
                return false;
            }
        }

        public bool compareTypes(int idAmbito, string varName1, string valueOf2, int typeOfValue)
        {
            string key1 = idAmbito.ToString() + "," + varName1;

            if (table.TryGetValue(key1, out string val1))
            {
                string[] data1 = val1.Split(',');

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
                // error, no existe la variable 1
                return false;
            }
        }

        public void tradIntToDouble(int idAmbito, string varName, string intValue)
        {
            string key = idAmbito + "," + varName;

            if (table.TryGetValue(key, out string values))
            {
                string[] data = values.Split(',');

                if (data[0] == "2")
                {
                    if (int.TryParse(intValue, out _))
                    {
                        data[1] = intValue + ".0";
                        string newVal = data[0] + "," + data[1] + "," + data[2];
                        // cambio de atributos
                        table[key] = newVal;
                    }
                    else
                    {
                        // error, lo que se está asignando no es un entero
                    }
                }
                else
                {
                    // error, la variable no es tipo double
                }
                
            }
            else
            {
                // error, no existe en la tabla
            }
        }
    }
}
