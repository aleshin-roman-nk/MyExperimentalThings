using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIImagine
{
	public static class DataGenerator
	{
		static string [] names = new string []
		{
			"Roman",
			"sorsend",
			"ansuns",
			"tendis",
			"istit",
			"apengilas",
			"rinsuc",
			"tacrir",
			"ingatra",
			"esomi",
			"imbutt",
			"sandof",
			"eciospac",
			"ernetamb",
			"avulado",
			"yomesowlu"
		};
			
		static Random r = new Random();

		public static string StringData()
		{

			int rndint = r.Next(0, 10000000);
			int ind = r.Next(0, names.Length - 1);

			return $"{names[ind]}{rndint}";
		}
	}
}
