using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minij
{
    class AnalisisSemantico
    {
        Dictionary<string, string> reserved = new Dictionary<string, string>()
        {
            { "void", "T_void"},
            { "int", "T_ValueType"},
            { "double", "T_ValueType"},
            { "boolean", "T_ValueType"},
            { "string", "T_ValueType"},
            { "const", "T_ValueType"},
            { "for", "T_KeyWord"},
            { "while", "T_KeyWord"},
            { "if", "T_KeyWord"},
            { "else", "T_KeyWord"},
        };

        List<string> funcTypes = new List<string>() { "int", "double", "boolean", "string", "void" };
        List<string> varTypes = new List<string>() { "int", "double", "boolean", "string" };

        public List<string> tokens = new List<string>();
        int idAmbito = 0;

        public AnalisisSemantico() { }

        public void Analizar()
        {
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < tokens.Count; i++)
            {
                if (varTypes.Contains(tokens[i]) || funcTypes.Contains(tokens[i]))
                {
                    // variable o función?
                    if (tokens[i+2] == "=")
                    {
                        int iType = 0;
                        int _base = 0;
                        switch (tokens[i])
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
                            string value = tokens[i + 3];
                            if (value[value.Length] == 'h')
                            {
                                _base = 3;
                            }
                            else if (value[value.Length] == 'o')
                            {
                                _base = 2;
                            }
                            else
                            {
                                _base = 1;
                            }
                        }
                        TDSobj aux = new TDSobj(idAmbito, tokens[i+1], iType, tokens[i+3], _base);
                        Data.Instance.tds.Insert(aux);
                    }
                    else
                    {

                    }
                }
                if (tokens[i] == "{")
                {
                    stack.Push("{");
                }
                else if (tokens[i] == "(")
                {
                    stack.Push("(");
                }
                else if (tokens[i] == ")")
                {
                    if (stack.Peek() == "(")
                    {
                        stack.Pop();
                    }
                    else
                    {
                        // error
                    }
                }
                else if (tokens[i] == "}")
                {
                    if (stack.Peek() == "{")
                    {
                        stack.Pop();
                    }
                    else
                    {
                        //error
                    }
                }
            }
        }
    }
}
