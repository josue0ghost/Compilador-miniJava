using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace minij
{
    class Lexeme
    {
        public KeyValuePair<string, string> token { get; set; } 
        public int cont { get; set; }


        public Lexeme(KeyValuePair<string, string> token, int cont)
        {
            this.token = token;
            this.cont = cont;
        }
    }
}
