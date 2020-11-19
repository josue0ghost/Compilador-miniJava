using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minij
{
    class Tabla_de_símbolos
    {
        /* table struct
         * idAmbito, name | type | value | _base
         */

        public Dictionary<string, string> table = new Dictionary<string, string>();

        public void Insert(TDSobj symbol)
        {
            string key = symbol.idAmbito.ToString() + "," + symbol.name;
            string value = symbol.type.ToString() + "," + symbol.value + "," + symbol._base;

            if (!table.ContainsKey(key))
            {
                table.Add(key, value);
            }
            else
            {
                // error
            }
        }

        public void Delete(TDSobj symbol)
        {
            string key = symbol.idAmbito.ToString() + "," + symbol.name;

            if (table.ContainsKey(key))
            {
                table.Remove(key);
            }
            else
            {
                // error
            }
        }

        public void Delete(int idAmbito, string name)
        {
            string key = idAmbito.ToString() + "," + name;

            if (table.ContainsKey(key))
            {
                table.Remove(key);
            }
            else
            {
                // error
            }
        }

        public TDSobj Search(TDSobj symbol)
        {
            string key = symbol.idAmbito.ToString() + "," + symbol.name;

            if (table.ContainsKey(key))
            {
                table.TryGetValue(key, out string value);
                string[] vals = value.Split(',');
                TDSobj obj = new TDSobj(int.Parse(vals[0]), vals[1], vals[2], int.Parse(vals[3]));
                return obj;
            }
            else
            {
                return null;
            }
        }

        public TDSobj Search(int idAmbito, string name)
        {
            string key = idAmbito.ToString() + "," + name;

            if (table.ContainsKey(key))
            {
                table.TryGetValue(key, out string value);
                string[] vals = value.Split(',');
                TDSobj obj = new TDSobj(int.Parse(vals[0]), vals[1], vals[2], int.Parse(vals[3]));
                return obj;
            }
            else
            {
                return null;
            }
        }
    }
}
