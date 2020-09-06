using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace minij
{
	static class RegularExpressions
	{
		// Formato:
		//static Regex id = new Regex("pattern");
		public static string replaceCommentsToNothing(string input)
		{
			string blockComments = @"/\*(.*?)\*/";
			string lineComments = @"//(.*?)\r?\n";
			string strings = @"""((\\[^\n]|[^""\n])*)""";
			string verbatimStrings = @"@(""[^""]*"")+";

			string noComments = Regex.Replace(input, 
				blockComments + "|" + lineComments + "|" + strings + "|" + verbatimStrings,
				me => {
					if (me.Value.StartsWith("/*") || me.Value.StartsWith("//"))
						return me.Value.StartsWith("//") ? Environment.NewLine : "";
					// Keep the literal strings
					return me.Value;
				},
				RegexOptions.Singleline);
			return noComments;
		}

		public static string RecognizeString(string line, string input, int cont, bool lastLine)
		{
			string pattern = "\\\"(.*?)\\\""; // si es una cadena válida
			string pattern2 = "\\\"(.*)?"; // string sin terminar 
			string pattern3 = "[\0\r\n\\\"]"; // si contiene cualquiera de estos 3 caracteres			

			Regex rgx = new Regex(pattern);
			Regex check = new Regex(pattern3);

			int start = line.IndexOf(input) + 1;
			int end = start + input.Length - 1;

			if (rgx.IsMatch(input))
            {
				string test = input.Substring(1, input.Length - 2);

				//validate the string
                if (!check.IsMatch(test))
                {
					return $"{input}\t line {cont} cols {start}-{end} is T_StringConstant\n";
				}
                else
                {
					string aux = $"{input}\t line {cont} cols {start}-{end} ERROR, found ";

					foreach (Match match in check.Matches(test))
					{
						aux += $"\'{match}\', ";
					}

					aux += "INVALID STRING\n";
					FileReader.errors += aux;
					return aux; 
				}
            }
            else
            {
				//unfinished string
				rgx = new Regex(pattern2);
				
				if (rgx.IsMatch(input))
				{
                    if (lastLine)
                    {
						FileReader.errors += $"{input}\t line {cont} cols {start}-{end} ERROR, EOF on a string\n";
						return $"{input}\t line {cont} cols {start}-{end} ERROR, EOF on a string\n";
					}
                    else
                    {
						FileReader.errors += $"{input}\t line {cont} cols {start}-{end} ERROR, Unfinished string\n";
						return $"{input}\t line {cont} cols {start}-{end} ERROR, Unfinished string\n";
					}
				}
			}		
			

			return "";
		}

		public static bool Validate(string input)
		{			            
			if (Regex.IsMatch(input, @"[\w$\d\""]"))
            {
				return true;  
            }

			return false;
		}

		public static string idPattern = @"[\$A-Za-z0-9]+";

		public static string intPattern = @"(^[1-9]*\d+|(0x|0X)(\d|[a-fA-F])+)";

		public static string doublePattern = @"(\d+\.\d*([eE][\+-]?\d+)?)";

		public static string boolean = @"true|false";		
	}
}
