using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace minij
{
	class RegularExpressions
	{
		// Formato:
		//static Regex id = new Regex("pattern");
		public void RecognizeString()
        {
			string pattern = "\\\"(.*?)\\\""; // si es una cadena 
			string pattern2 = "\\\"\\w+"; // string sin terminar 
			string pattern3 = "[\\0+\r\n\\\"]"; // si contiene cualquiera de estos 3 caracteres
			Regex rgx = new Regex(pattern3);


		}

		public static string idPattern = @"\b[A-Z]+\b";
	}
}
