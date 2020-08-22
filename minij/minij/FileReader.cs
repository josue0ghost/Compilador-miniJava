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
            string response = "";
            int cont = 1;            
            List<string> lines = input.Split('\n').ToList();

            // 
            foreach (string line in lines)
            {                
                // leer programa
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
            return "";
        }
    }
}
