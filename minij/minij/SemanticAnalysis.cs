using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minij
{
    class SemanticAnalysis
    {
        public List<KeyValuePair<string, string>> tokens = new List<KeyValuePair<string, string>>();
        Tabla_de_símbolos tabla = new Tabla_de_símbolos();
        int idAmbito = 0;

        /* type
        * 0 = null
        * 1 = int
        * 2 = double
        * 3 = boolean
        * 4 = string
        * 5 = void
        */

        Dictionary<string, int> type = new Dictionary<string, int>() {
            { "null", 0 },
            { "int", 1},
            { "double", 2 },
            { "boolean", 3},
            { "String", 4},
            { "void", 5}
        };

        public SemanticAnalysis(List<KeyValuePair<string, string>> tokens) {  // tokens per line
            this.tokens = tokens;
        }


        // la posición nula de la lista de tokens indica nueva linea
        public void Analysis() {

            List<KeyValuePair<string, string>> line = new List<KeyValuePair<string, string>>();

            for (int i = 0; i < tokens.Count; i++)
            {
                if (!tokens[i].Key.Equals(""))
                {
                    line.Add(tokens[i]);
                }
                else {  // termina la linea
                    Console.WriteLine("tokens por linea");
                    line = new List<KeyValuePair<string, string>>();

                } 

            }
        }

        public void assign(List<KeyValuePair<string, string>> input) {

            // declaración y asignación
            if (input[0].Value.Equals("T_ValueType") &&
                input[1].Value.Equals("ident") &&
                input[2].Value.Equals("=") &&
                (input[3].Value.Equals("ident") || input[3].Value.Equals("int") || input[3].Value.Equals("double") || input[3].Value.Equals("string") || input[3].Value.Equals("boolean"))) // declaracion y asignacion
            {
                int iType = 0;
                int _base = 0;
                switch (input[3].Value)
                {
                    case "int":
                        iType = 1;
                        break;
                    case "double":
                        iType = 2;
                        break;
                    case "boolean":
                        iType = 3;
                        break;
                    case "string":
                        iType = 4;
                        break;
                    default:
                        break;
                }

                if (iType == 1)
                {

                    string value = input[3].Key;
                    if (value[0] == '0' && (value[1] == 'x' || value[1] == 'X'))
                    {
                        _base = 2;
                    }
                    else
                    {
                        _base = 1;
                    }
                }

                TDSobj aux = null;
                // comparar tipos 
                if (input[3].Value.Equals("ident"))
                {
                    if (tabla.compareTypes(idAmbito, input[1].Key, input[3].Key))
                    {
                        aux = new TDSobj(idAmbito, input[1].Key, iType, input[3].Key, _base);
                    }

                }
                else
                {
                    if (tabla.compareTypes(idAmbito, input[1].Key, iType))
                    {
                        aux = new TDSobj(idAmbito, input[1].Key, iType, input[3].Key, _base);
                    }                    
                }
               
                
                Data.Instance.tds.Insert(aux);
            }

            // solo asignación
            if (input[1].Value.Equals("ident") &&
                input[2].Value.Equals("=") &&
                (input[3].Value.Equals("ident") || input[3].Value.Equals("int") || input[3].Value.Equals("double") || input[3].Value.Equals("string") || input[3].Value.Equals("boolean"))) // declaracion y asignacion
            {
                int iType = 0;
                int _base = 0;
                switch (input[3].Value)
                {
                    case "int":
                        iType = 1;
                        break;
                    case "double":
                        iType = 2;
                        break;
                    case "boolean":
                        iType = 3;
                        break;
                    case "string":
                        iType = 4;
                        break;
                    default:
                        break;
                }

                if (iType == 1)
                {

                    string value = input[3].Key;
                    if (value[0] == '0' && (value[1] == 'x' || value[1] == 'X'))
                    {
                        _base = 2;
                    }
                    else
                    {
                        _base = 1;
                    }
                }
                TDSobj aux = new TDSobj(idAmbito, input[1].Key, iType, input[3].Key, _base);
                Data.Instance.tds.Insert(aux);
            }            

            // asignación de variable a variable
        }

    }
}
