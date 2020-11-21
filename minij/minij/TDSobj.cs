using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minij
{
    class TDSobj
    {
        /* key = idAmbito,name */
        public string idAmbito { get; set; }
        public string name { get; set; }

        /* type
         * 0 = null
         * 1 = int
         * 2 = double
         * 3 = boolean
         * 4 = string
         * 5 = void
         */
        public int type { get; set; }

        /* value
         * string con el valor
         */
        public string value { get; set; }

        /*_base
         * 0 = NaN
         * 1 = decimal
         * 2 = hex
         */
        public int _base { get; set; }

        /* arreglo de tipos para los argumentos de una función */
        public int[] args { get; set; }

        public TDSobj() { }

        public TDSobj(string iAmbito, string Name, int iType, string Value)
        {
            this.idAmbito = iAmbito;
            this.name = Name;
            this.type = iType;
            this.value = Value;
            this._base = 0;
            this.args = null;
        }

        public TDSobj(string iAmbito, string Name, int iType, string Value, int Base)
        {
            this.idAmbito = iAmbito;
            this.name = Name;
            this.type = iType;
            this.value = Value;
            this._base = Base;
            this.args = null;
        }

        public TDSobj(string iAmbito, string Name, int iType, string Value, int[] argumentTypes)
        {
            this.idAmbito = iAmbito;
            this.name = Name;
            this.type = iType;
            this.value = Value;
            this._base = 0;
            this.args = argumentTypes;
        }

        public TDSobj(string iAmbito, string Name, int iType, string Value, int Base, int[] argumentTypes)
        {
            this.idAmbito = iAmbito;
            this.name = Name;
            this.type = iType;
            this.value = Value;
            this._base = Base;
            this.args = argumentTypes;
        }
    }
}
