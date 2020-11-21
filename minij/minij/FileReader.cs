using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace minij
{
    class FileReader
    {
        public static string errors = "";
        public static List<string> tokens = new List<string>();
        public static List<string> lexems = new List<string>();       
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


        Dictionary<string, string> reserved = new Dictionary<string, string>()
        {
            { "void", "T_void"},
            { "int", "T_ValueType"},
            { "double", "T_ValueType"},
            { "boolean", "T_ValueType"},
            { "string", "T_ValueType"},
            { "class", "T_ReferenceType"},
            { "const", "T_ValueType"},
            { "interface", "T_ReferenceType"},
            { "null", "T_ValueType"},
            { "this", "T_ReferenceType"},
            { "extends", "T_KeyWord"},
            { "implements", "T_KeyWord"},
            { "for", "T_KeyWord"},
            { "while", "T_KeyWord"},
            { "if", "T_KeyWord"},
            { "else", "T_KeyWord"},
            { "return", "T_KeyWord"},
            { "break", "T_KeyWord"},
            { "New", "T_KeyWord"},
            { "System", "T_JavaLang"},
            { "out", "T_SystemClass"},
            { "println", "T_Method"}
        };

        List<string> operators = new List<string>()
        { "+", "-", "*", "/", "%", "<", "<=", ">", ">=", "=", "==",
          "!=", "&&", "||", "!", ";", ",", ".", "[]", "()", "{}",
          "[", "]", "(", ")", "{", "}"
        };

        public List<string> getTokens()
        {
            return tokens;
        }


        public string LexicalAnalysis(string input, List<string> origin)
        {
            string temp = "";
            string response = "";
            //int cont = 1;

            List<string> lines = input.Split('\n').ToList();
            //List<string> lines = Regex.Split(input, "\r\n").ToList();
            bool gettinStrings = false;
            bool gettinInteger = false;
            bool concatNext = true;
            bool gettinDouble = false;
            bool finish = false; 

            foreach (string item in lines)
            {
                int cont = origin.FindIndex(x => x.Contains(item.Replace("\r", ""))) + 1;
                for (int i = 0; i < item.Length; i++)
                {
                    if (Char.IsWhiteSpace(item[i]))
                    {
                        if (temp != "")
                        {
                            if (!gettinStrings)
                            {
                                response += Analysis(item, temp, cont, cont == lines.Count);
                                temp = "";
                            }
                            else
                            {
                                temp += item[i];
                            }
                        }
                    }
                    else if (operators.Contains(item[i].ToString()))
                    {
                        if (temp != "")
                        {
                            if (gettinStrings) // if a operator is between '"' is not really an operator
                            {
                                temp += item[i];
                            }
                            else if (gettinInteger && item[i] == '.') // if a '.' is after a number, is a double var
                            {
                                gettinInteger = false;
                                gettinDouble = true;
                                temp += item[i];
                            }
                            else if (gettinDouble && (item[i] == '+' || item[i] == '-')) // exponential double
                            {
                                temp += item[i];
                            }
                            else
                            {
                                response += Analysis(item, temp, cont, cont == lines.Count);
                                temp = "";
                                i--;
                            }
                        }
                        else
                        {
                            //check if the next char is operator                                                     
                            if (item.Length > 1)
                            {
                                try
                                {
                                    if (item[i].ToString() + item[i + 1].ToString() == "*/")
                                    {
                                        response += FormatUnpairedComment(item, (item[i].ToString() + item[i + 1].ToString()), cont, i);
                                        i++;
                                    }
                                    else if (item[i].ToString() + item[i + 1].ToString() == "/*")
                                    {
                                        response += FormatEOF(item, (item[i].ToString() + item[i + 1].ToString()), cont);
                                        finish = true; 
                                        break;
                                    }
                                    else if (operators.Contains((item[i].ToString() + item[i + 1].ToString())))
                                    {
                                        response += FormatOperator(item, (item[i].ToString() + item[i + 1].ToString()), cont, i);
                                        i++;
                                    }
                                    else
                                    {
                                        response += FormatOperator(item, item[i].ToString(), cont, i);
                                    }
                                }
                                catch (Exception) // operator is at the end of line
                                {
                                    response += FormatOperator(item, item[i].ToString(), cont, i);
                                }
                            }
                            else
                            {
                                response += FormatOperator(item, item[i].ToString(), cont, i);
                            }
                        }
                    }
                    else
                    {
                        List<char> hexDigits = new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f' };
                        if (item[i] == '"' && !gettinStrings)
                        {
                            gettinStrings = true;
                        }
                        else if (item[i] == '"' && gettinStrings)
                        {
                            gettinStrings = false;
                        }
                        else if (int.TryParse(item[i].ToString(), out int x) && !gettinStrings && temp == "")
                        {
                            try
                            {
                                if (x == 0 && (item[i + 1] == 'x' || item[i + 1] == 'X')) // posibility to being an hex value
                                {
                                    temp += item[i];
                                    temp += item[i + 1];
                                    i += 2;
                                    gettinInteger = false;
                                    while (i < item.Length)
                                    {
                                        if (hexDigits.Contains(item[i]))
                                        {
                                            temp += item[i];
                                            i++;
                                        }
                                        else
                                        {
                                            i--;
                                            concatNext = false;
                                            break;
                                        }
                                    }
                                    if (i == item.Length)
                                    {
                                        concatNext = false;
                                    }
                                    response += Analysis(item, temp, cont, cont == lines.Count);
                                    temp = "";
                                }
                                else
                                {
                                    gettinInteger = true;
                                }
                            }
                            catch (Exception)
                            {
                                gettinInteger = true;
                            }
                        }
                        else if (gettinInteger)
                        {
                            if (!int.TryParse(item[i].ToString(), out int y))
                            {
                                gettinInteger = false;
                                if (temp != "")
                                {
                                    response += Analysis(item, temp, cont, cont == lines.Count);
                                    temp = "";
                                }                                                              
                            }
                        }
                        //else if (gettinDouble && (item[i] != 'e' && item[i] != 'E'))
                        //{
                        //    gettinDouble = false;
                        //    response += Analysis(item, temp, cont);
                        //    temp = "";
                        //    i--;
                        //    concatNext = false;
                        //}

                        if (concatNext)
                        {
                            if (RegularExpressions.Validate(item[i].ToString()) || operators.Contains(item[i].ToString()) || gettinStrings)
                            {
                                temp += item[i];
                            }
                            else
                            {
                                response += FormatIdentifier(item, item[i].ToString(), cont);
                            }                   
                        }
                        else
                        {
                            concatNext = true;
                        }
                    }
                }

                if (finish)
                {
                    break;
                }

                if (temp != "") // No analyzed item
                {
                    response += Analysis(item, temp, cont, cont == lines.Count);
                    temp = "";
                }

                //cont++;
            }

            return response;
        }

        public string FormatReserved(string line, string input, int cont)
        {
            int start = line.IndexOf(input) + 1;
            int end = start + input.Length - 1;
            var result = reserved.Where(pair => pair.Key == input).ToArray();            
            Console.WriteLine($"{result[0].Key}\t line {cont} cols {start}-{end} is {result[0].Value}");
            tokens.Add(result[0].Value);
            lexems.Add(result[0].Key);
            return $"{result[0].Key}\t line {cont} cols {start}-{end} is {result[0].Value}\n";
        }

        public string FormatOperator(string line, string input, int cont)
        {
            int start = line.IndexOf(input) + 1;            
            int end = start + input.Length - 1;
            var result = operators.Where(x => x.Equals(input)).ToArray();
            Console.WriteLine($"{result[0]}\t line {cont} cols {start}-{end} is {result[0]}");
            tokens.Add(result[0]);
            lexems.Add(result[0]);
            return $"{result[0]}\t line {cont} cols {start}-{end} is \'{result[0]}\'\n";
        }

        public string FormatOperator(string line, string input, int cont, int index)
        {
            int start = line.IndexOf(input, index) + 1;
            int end = start + input.Length - 1;
            var result = operators.Where(x => x.Equals(input)).ToArray();
            Console.WriteLine($"{result[0]}\t line {cont} cols {start}-{end} is {result[0]}");
            tokens.Add(result[0]);
            lexems.Add(result[0]);
            return $"{result[0]}\t line {cont} cols {start}-{end} is \'{result[0]}\'\n";
        }

        public string FormatEOF(string lines, string input, int cont)
        {
            int start = lines.IndexOf(input) + 1;    
            errors += $"{input}\t line {cont} cols {start} ERROR, EOF on a comment\n"; 
            return $"{input}\t line {cont} cols {start} ERROR, EOF on a comment\n";
        }

        public string FormatIdentifier(string line, string input, int cont)
        {
            Match match = Regex.Match(input, RegularExpressions.idPattern, RegexOptions.IgnoreCase);

            if (match.Success)
            {
                int start = line.IndexOf(input) + 1;
                int end = start + input.Length - 1;
                string result = match.Value;
                Console.WriteLine($"{result}\t line {cont} cols {start}-{end} is Token_Identifier");

                var combined = reserved.Where(value => match.Value.Contains(value.Key)).ToArray();

                if (combined.Length > 0) // identifier contains a keyword
                {
                    return $"'{result}'\t line {cont} cols {start}-{end}, Identifier contains '{combined[0].Key}' keyword\n";
                }
                else
                {
                    if (input.Length > 31)
                    {
                        errors += $"'{result.Substring(0, 31)}...'\t line {cont} cols {start}-{end} ERROR, Length not allowed identifier\n";
                        return $"'{result.Substring(0, 31)}...'\t line {cont} cols {start}-{end} ERROR, Length not allowed\n";
                    }
                    else
                    {
                        tokens.Add(result);
                        lexems.Add(result);
                        return $"'{result}'\t line {cont} cols {start}-{end} is Token_Identifier\n";
                    }
                }                
            }
            else 
            {
                errors += $"ERROR line {cont}, Unrecognized input: {input}\n";
                return $"ERROR line {cont}, Unrecognized input: {input}\n";
            }

        }

        public string FormatDouble(string line, string input, int cont, string result)
        {
            int start = line.IndexOf(input) + 1;
            int end = start + input.Length - 1;
            Console.WriteLine($"{result}\t line {cont} cols {start}-{end} is Token_Double");
            tokens.Add(result);
            lexems.Add(result);
            return $"'{result}'\t line {cont} cols {start}-{end} is Token_Double\n";
        }

        public string FormatInt(string line, string input, int cont)
        {            
            int start = line.IndexOf(input) + 1;
            int end = start + input.Length - 1;
            Console.WriteLine($"{input}\t line {cont} cols {start}-{end} is T_IntConstant");
            tokens.Add(input);
            lexems.Add(input);
            return $"'{input}'\t line {cont} cols {start}-{end} is T_IntConstant\n";
        }

        public string FormatBool(string line, string input, int cont)
        {
            int start = line.IndexOf(input) + 1;
            int end = start + input.Length - 1;
            Console.WriteLine($"{input}\t line {cont} cols {start}-{end} is T_BooleanConstant");
            tokens.Add(input);
            lexems.Add(input);
            return $"'{input}'\t line {cont} cols {start}-{end} is T_BooleanConstant\n";
        }

        public string FormatUnpairedComment(string line, string input, int cont, int index)
        {
            int start = line.IndexOf(input) + 1;
            int end = start + input.Length - 1;          
            errors += $"ERROR line {cont}, Unpaired comment: {input}\n";
            return $"ERROR line {cont}, Unpaired comment: {input}\n";
        }

        public string Analysis(string line, string input, int cont, bool lastLine) 
        {
            if (reserved.ContainsKey(input))
            {
                return FormatReserved(line, input, cont);
            }
            else if (input.Contains("\"")) // use regex
            {
                return RegularExpressions.RecognizeString(line, input, cont, lastLine);
            }
            else if (Regex.Match(input, RegularExpressions.doublePattern).Success)
            {
                Match match = Regex.Match(input, RegularExpressions.doublePattern);
                return FormatDouble(line, input, cont, match.Value);
            }
            else if (Regex.Match(input, RegularExpressions.intPattern).Success)
            {
                return FormatInt(line, input, cont);
            }
            else if (Regex.Match(input, RegularExpressions.boolean).Success)
            {
                return FormatBool(line, input, cont);
            }
            else
            {
                return FormatIdentifier(line, input, cont);
            }           
        }
    }
}
