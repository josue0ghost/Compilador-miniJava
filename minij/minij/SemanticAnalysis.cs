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
        int ambito = 0;

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

        public bool assign(List<KeyValuePair<string, string>> input) {

            if (input[0].Value.Equals("T_ValueType") && 
                input[1].Value.Equals("ident") &&
                input[2].Value.Equals("=") &&
                (input[3].Value.Equals("int") || input[3].Value.Equals("double") || input[3].Value.Equals("string") || input[3].Value.Equals("boolean"))) // declaracion y asignacion
            {
                //tabla.Insert();
            }

            if (input[1].Value.Equals("ident") &&
                input[2].Value.Equals("=") &&
                (input[3].Value.Equals("int") || input[3].Value.Equals("double") || input[3].Value.Equals("string") || input[3].Value.Equals("boolean"))) // declaracion y asignacion
            {
                //tabla.Insert();
            }



            return true;
        }

    }
}
