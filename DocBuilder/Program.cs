using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocBuilder
{
	class Program
	{
		static void Main(string[] args)
		{
			string tempDoc = File.ReadAllText("contract.htmltemplate");

			var table = new Dictionary<string, string>();

			string body = "Адрес %kv:<, кв kv>%";

			table["kv"] = "";


			DBiuld doc = new DBiuld(table, body);
			Console.WriteLine(doc.Document);

			//File.WriteAllText("out.html", doc.Document, Encoding.UTF8);

			//var vars = DBiuld.AllVariables(tempDoc);

			//foreach (var item in vars)
			//{
			//	Console.WriteLine(item);
			//}

			//Console.WriteLine("Done!!!");
			Console.ReadLine();
		}
	}
}
