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
        int idAmbito = 0;
        int whileCount = 0;
        int forCount = 0;
        int ifCount = 0;
        int elseCount = 0;

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

        private int getIdType(string type)
        {
            int iType = 0;
            switch (type)
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
                case "void":
                    iType = 5;
                    break;
                default:
                    break;
            }

            return iType;
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
                else if (tokens[i].Value == "T_ValueType" && tokens[i+1].Value == "ident" && tokens[i+2].Value == "(") // es función
                {
                    // una nueva función, un nuevo ámbito
                    idAmbito++;

                    int iType = getIdType(tokens[i].Value);
                    int pos = i;

                    i += 2;
                    List<int> argTypes = new List<int>();
                    while (tokens[i].Key != ")")
                    {
                        if (tokens[i].Value == "T_ValueType")
                        {
                            argTypes.Add(getIdType(tokens[i].Key));
                        }
                        else if (tokens[i].Value == "ident")
                        {
                            int argType = getIdType(tokens[i - 1].Key);
                            int idBase = 0;
                            if (argType == 1)
                            {
                                idBase = 1;
                            }
                            TDSobj newArg = new TDSobj(idAmbito.ToString(), tokens[i].Key, argTypes[argTypes.Count - 1], "", idBase);
                            Data.Instance.tds.Insert(newArg);
                        }
                        i++;
                    }

                    TDSobj newFunc = new TDSobj("0", tokens[pos+1].Key, iType, "", argTypes.ToArray());
                    Data.Instance.tds.Insert(newFunc);
                }
                else if (tokens[i].Value == "T_KeyWord") // condiciones o ciclos
                {
                    if (tokens[i].Key == "while")
                    {
                        Stack<string> parentesis = new Stack<string>();
                        parentesis.Push("(");

                        i+=2;
                        while (parentesis.Count > 0)
                        {
                            if (tokens[i].Value == "(") // puede haber ((true) == (true))
                            {
                                parentesis.Push("(");
                            }
                            else if (tokens[i].Value == ")")
                            {
                                parentesis.Pop();
                            }
                            else if (tokens[i].Value == "ident")
                            {
                                
                            }
                            else if (type.ContainsKey(tokens[i].Value)) // si es un valor de cierto tipo
                            {

                            }
                        }
                        whileCount++;
                    }
                    else if (tokens[i].Key == "for")
                    {
                        if (tokens[i+1].Key == "(" && tokens[i+2].Value == "T_ValueType")
                        {
                            int _base = 0;
                            int iType = getIdType(tokens[i + 2].Key);
                            string value = tokens[i + 4].Key;
                            if (iType == 1)
                            {
                                if (value[0] == '0' && (value[1] == 'x' || value[1] == 'X'))
                                {
                                    _base = 2;
                                }
                                else
                                {
                                    _base = 1;
                                }
                            }

                            TDSobj aux = new TDSobj("for" + forCount.ToString(), tokens[i + 3].Key, iType, value);
                            Data.Instance.tds.Insert(aux);

                            if (!Data.Instance.tds.compareTypes("for"+ forCount.ToString(), aux.name, 1))
                            {
                                Data.Instance.tds.Delete(aux);
                                //error
                            }
                        }
                        forCount++;
                    }
                    else if (tokens[i].Key == "if")
                    {

                        ifCount++;
                    }
                    else if (tokens[i].Key == "else")
                    {

                        elseCount++;
                    }
                }
                else {  // termina la linea
                    Console.WriteLine("tokens por linea");
                    declare(line);
                    assign(line, "");                   
                    line = new List<KeyValuePair<string, string>>();

                } 

            }
        }

        public void assign(List<KeyValuePair<string, string>> input, string ambito)
        {

            if (input.Count >= 3)
            {

            
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
                    if (Data.Instance.tds.compareTypes(idAmbito.ToString(), input[1].Key, iType))
                    {
                        aux = new TDSobj(idAmbito.ToString(), input[1].Key, iType, input[3].Key, _base);
                            if (aux != null)
                            {
                                Data.Instance.tds.Update(idAmbito.ToString(), input[1].Key, input[3].Key);
                            }
                    }
                }
                else
                {
                    // la variable no existe y se está declarando e insertando
                    aux = new TDSobj(idAmbito.ToString(), input[1].Key, iType, input[3].Key, _base);
                        if (aux != null)
                        {
                            Data.Instance.tds.Insert(aux);
                        }

                }
            }

            // solo asignación
            if (input[0].Value.Equals("ident") &&
                input[1].Value.Equals("=") &&
                (input[2].Value.Equals("ident") || input[3].Value.Equals("int") || input[3].Value.Equals("double") || input[3].Value.Equals("string") || input[3].Value.Equals("boolean"))) // declaracion y asignacion
            {
                int iType = 0;
                int _base = 0;
                switch (input[2].Value)
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
                    if (Data.Instance.tds.compareTypes(idAmbito.ToString(), input[1].Key, input[3].Key))
                    {
                        aux = new TDSobj(idAmbito.ToString(), input[1].Key, iType, input[3].Key, _base);
                    }

                }
                else
                {
                    if (Data.Instance.tds.compareTypes(idAmbito.ToString(), input[1].Key, iType))
                    {
                        aux = new TDSobj(idAmbito.ToString(), input[1].Key, iType, input[3].Key, _base);
                    }
                }

                if (aux != null)
                {
                    Data.Instance.tds.Update(idAmbito.ToString(), input[1].Key, input[3].Key);
                }
            }

        }
            // ASIGNACION ident.ident
        }

        /// <summary>
        /// Metodo para insertar declaraciones de variables en la tabla de simbolos
        /// </summary>
        public void declare(List<KeyValuePair<string, string>> input) {
            if (input.Count >= 2)
            {
                if (input[0].Value.Equals("T_ValueType") &&
                    input[1].Value.Equals("ident"))
                {

                    int iType = 0;
                    int _base = 0;
                    switch (input[0].Key)
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

                    TDSobj aux = new TDSobj(idAmbito.ToString(), input[1].Key, iType, "", _base);
                    if (aux != null)
                    {
                        Data.Instance.tds.Insert(aux);
                    }                    
                }


                if (input[0].Value.Equals("T_KeyWord") &&
                    input[1].Value.Equals("T_ValueType") &&
                    input[2].Value.Equals("ident"))
                {
                    int iType = 0;
                    int _base = 0;
                    switch (input[1].Key)
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

                    TDSobj aux = new TDSobj(idAmbito.ToString(), input[2].Key, iType, "", _base);
                    if (aux != null)
                    {
                        Data.Instance.tds.Insert(aux);
                    }

                }
            }
        }

        public void write() {
            Data.Instance.tds.writeTable();
        }

        public void errors() {
            Data.Instance.tds.getErrors();
        }

    }
}
