using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace minij
{
    class FileReader
    {
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


        public string LexicalAnalysis(string input)
        {
            string temp = "";
            string response = "";
            int cont = 1;
            List<string> lines = input.Split('\n').ToList();
            bool gettinStrings = false;
            bool gettinInteger = false;
            bool concatNext = true;
            bool gettinDouble = false;

            foreach (string item in lines)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (Char.IsWhiteSpace(item[i]))
                    {
                        if (temp != "")
                        {
                            if (!gettinStrings)
                            {
                                response += Analysis(item, temp, cont);
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
                                response += Analysis(item, temp, cont);
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
                                    if (operators.Contains((item[i].ToString() + item[i + 1].ToString())))
                                    {
                                        lines.IndexOf(item);
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
                                    response += Analysis(item, temp, cont);
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
                                response += Analysis(item, temp, cont);
                                temp = "";
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
                            temp += item[i];
                        }
                        else
                        {
                            concatNext = true;
                        }
                    }
                }

                if (temp != "") // No analyzed item
                {
                    response += Analysis(item, temp, cont);
                    temp = "";
                }
                cont++;
            }

            return response;
        }

        public string FormatReserved(string line, string input, int cont)
        {
            int start = line.IndexOf(input) + 1;
            int end = start + input.Length - 1;
            var result = reserved.Where(pair => pair.Key == input).ToArray();
            Console.WriteLine($"{result[0].Key}\t line {cont} cols {start}-{end} is {result[0].Value}");
            return $"{result[0].Key}\t line {cont} cols {start}-{end} is {result[0].Value}\n";
        }

        public string FormatOperator(string line, string input, int cont)
        {
            int start = line.IndexOf(input) + 1;            
            int end = start + input.Length - 1;
            var result = operators.Where(x => x.Equals(input)).ToArray();
            Console.WriteLine($"{result[0]}\t line {cont} cols {start}-{end} is {result[0]}");
            return $"{result[0]}\t line {cont} cols {start}-{end} is \'{result[0]}\'\n";
        }

        public string FormatOperator(string line, string input, int cont, int index)
        {
            int start = line.IndexOf(input, index) + 1;
            int end = start + input.Length - 1;
            var result = operators.Where(x => x.Equals(input)).ToArray();
            Console.WriteLine($"{result[0]}\t line {cont} cols {start}-{end} is {result[0]}");
            return $"{result[0]}\t line {cont} cols {start}-{end} is \'{result[0]}\'\n";
        }

        public string FormatIdentifier(string line, string input, int cont)
        {
            Match match = Regex.Match(input, RegularExpressions.idPattern, RegexOptions.IgnoreCase);
            int start = line.IndexOf(input) + 1;
            int end = start + input.Length - 1;
            string result = match.Value;
            Console.WriteLine($"{result}\t line {cont} cols {start}-{end} is Token_Identifier");
            return $"'{result}'\t line {cont} cols {start}-{end} is Token_Identifier\n";
        }

        public string FormatDouble(string line, string input, int cont, string result)
        {
            int start = line.IndexOf(input) + 1;
            int end = start + input.Length - 1;
            Console.WriteLine($"{result}\t line {cont} cols {start}-{end} is Token_Double");
            return $"'{result}'\t line {cont} cols {start}-{end} is Token_Double\n";
        }
        public string FormatInt(string line, string input, int cont)
        {            
            int start = line.IndexOf(input) + 1;
            int end = start + input.Length - 1;
            Console.WriteLine($"{input}\t line {cont} cols {start}-{end} is T_IntConstant");
            return $"'{input}'\t line {cont} cols {start}-{end} is T_IntConstant\n";
        }

        public string FormatBool(string line, string input, int cont)
        {
            int start = line.IndexOf(input) + 1;
            int end = start + input.Length - 1;
            Console.WriteLine($"{input}\t line {cont} cols {start}-{end} is T_BooleanConstant");
            return $"'{input}'\t line {cont} cols {start}-{end} is T_BooleanConstant\n";
        }

        public string Analysis(string line, string input, int cont) 
        {
            if (reserved.ContainsKey(input))
            {
                return FormatReserved(line, input, cont);
            }
            else if (input.Contains("\"")) // use regex
            {
                return RegularExpressions.RecognizeString(line, input, cont);
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
