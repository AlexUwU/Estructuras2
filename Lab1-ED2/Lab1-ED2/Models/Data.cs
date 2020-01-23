using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1_ED2.Models
{
    public class Data
    {
		private static Data _instance = null;
		public static Data Instance
		{
			get
			{
				if (_instance == null) _instance = new Data();
				return _instance;
			}
		}
		public List<Pelicula> Peliculas = new List<Pelicula>();
		
	}
}
