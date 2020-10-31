using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeGen
{
    class CodeGenerator
    {
        /*
         * TO DO:
         * poner pila de estados [x]
         * poner pila de de símbolos leídos [x]
         * poner cadena de entrada [x]
         * implementar el aceptar []
         * implementar escritura []
         */

        // tabla de análisis
        string[] hAnalisis;
        List<string[]> states = new List<string[]>();

        // producciones
        string[] hProd;
        List<string[]> prods = new List<string[]>();

        FileHandling fh = new FileHandling();

        public void Generate(string tablePath, string prodPath, string outputPath)
        {
            // leer csv de tabla de análisis
            states = fh.ReadFile(ref hAnalisis, tablePath);

            // leer csv de tabla de producciones
            /* Ej: 1) E -> T + E
             * #Prod,NT,#Simbolos
             * 1,E,3
             */
            prods = fh.ReadFile(ref hProd, prodPath);           
            
            string ini = "public Stack<int> stack = new Stack<int>();\n";   // pila de estados
            ini += "public Stack<string> text = new Stack<string>();\n";    // texto analizado
            ini += "public List<string> input = new List<string>();\n";     // cadena de entrada

            fh.WriteFile(ini, outputPath);

            for (int i = 0; i < states.Count; i++)
            {
                string func = writeFunctions(states[i], i);
                fh.WriteFile(func, outputPath);
            }
        }

        private string writeFunctions(string[] state, int numState)
        {
            string func = "";
            func += "public bool fooState" + numState + "(bool afterReduce){\n"; // funcion de estado

            // ,r2,,d4,,1,3
            string[] actions = state;
            for (int i = 0; i < actions.Length; i++)
            {
                if (actions[i] != "")
                {
                    string act = actions[i];
                    string symbol = hAnalisis[i];
                    if (symbol == "(coma)")
                    {
                        symbol = ",";
                    }


                    if (int.TryParse(act[0].ToString(), out int s)) // IR_A
                    {
                        func += "\tif(afterReduce && text.Peek() == \"" + symbol + "\"){\n";
                        func += "\t\tstack.Push(" + numState + ");\n"; // insertar estado actual a pila de estados
                        func += "\t\tfooState" + s + "(false);\n";
                        func += "\t\tbreak;\n";
                        func += "\t}\n";
                    }
                    else if (act[0] == 'd') // desplazamiento
                    {
                        int num = int.Parse(act.Substring(1));

                        func += "\tif(input[0] == \"" + symbol + "\"){\n";
                        func += "\t\tstack.Enqueue(" + num + ");\n";
                        func += "\t\ttext.Enqueue();\n";
                        func += "\t\tinput.RemoveAt(0);\n";

                        func += "\t\tstack.Push(" + numState + ");\n";         // insertar estado actual a pila de estados
                        func += "\t\tfooState" + num + "(false);\n";
                        func += "\t\tbreak;\n";
                        func += "\t}\n";
                    }
                    else if (act[0] == 'r')// reducción
                    {
                        int index = int.Parse(act.Substring(1)) - 1;

                        func += "\tif(text.Peek() == \"" + symbol + "\"){\n";

                        func += "\t\tfor(int i = 0; i < " + prods[index][2] + "; i++){\n"; // estado n [2] = # símbolos
                        func += "\t\t\tstack.Pop();\n";
                        func += "\t\t\ttext.Pop();\n";
                        func += "\t\t}\n";

                        func += "\t\ttext.Push(" + prods[index][1] + ");\n"; // estado n [1] = izq de la producción

                        func += "\t\tfooStateCAMBIAR();\n";
                        func += "\t\tbreak;\n";
                        func += "\t}\n";
                    }
                    else if (actions[i] == "ACEPTAR") // aceptar
                    {
                        func += "\tif(input[0] == \"" + symbol + "\"){\n";
                        func += "\treturn true;\n";
                        func += "\t}\n";
                    }
                }
            }

            func += "\treturn false\n";

            func += "}\n\n";

            return func;
        }
    }
}
