﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minij
{
    class Data
    {
		private static Data instance = null;
		public static Data Instance
		{
			get
			{
				if (instance == null) instance = new Data();
				return instance;
			}
		}

		public FileReader fr = new FileReader();
		public LR parser = new LR();
		public Tabla_de_símbolos tds = new Tabla_de_símbolos();
	}
}
