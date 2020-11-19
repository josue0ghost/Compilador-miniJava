using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minij
{
    class TDSobj
    {
        /* type
         * 0 = null
         * 1 = int
         * 2 = double
         * 3 = boolean
         * 4 = string
         * 5 = void
         */
        public int type { get; set; }

        /*_base
         * 0 = NaN
         * 1 = decimal
         * 2 = octal
         * 3 = hex
         */
        public int _base { get; set; }

        /* value
         * string con el valor
         */
        public string value { get; set; }

        public string name { get; set; }

        /* key = idAmbito,name */
        public int idAmbito { get; set; }

        public TDSobj(int iType, int Base, string Name, string Value, int iAmbito)
        {
            this.type = iType;
            this._base = Base;
            this.value = Value;
            this.name = Name;
            this.idAmbito = iAmbito;
        }

        public TDSobj(int iType, string Name, string Value, int iAmbito)
        {
            this.type = iType;
            this.value = Value;
            this.name = Name;
            this.idAmbito = iAmbito;
            this._base = 0;
        }
    }
}
