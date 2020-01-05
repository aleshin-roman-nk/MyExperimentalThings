using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ReadFastNotebook.BL;

namespace ReadFastNotebook
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				//ShowNootes.ShowBody("Заметки 20-12-2019-02-47.txt");

				//ShowNootes.GetIndexes("Заметки 20-12-2019-02-47Индексы.txt");

				//ShowNootes.GetNotes(@"..\..\..\DataFiles\notes.text", @"..\..\..\DataFiles\notes.index");

				string str = File.ReadAllText(@"..\..\..\DataFiles\FastNotepad_2019-12-20");

				//var l = CoutTags.GetObjs("{Name=Roman{Age=41;Color=Black}}{Name=Natasha{Age=37;Color=Yellow}}");
				var l = CoutTags.GetObjs(str);

				int c = 0;
				foreach (var item in l)
				{
					Console.WriteLine($"Object {c++} :");
					Console.WriteLine(item);
					Console.WriteLine("");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}

			Console.ReadLine();
		}
	}

	class A
	{
		public string Name { get; set; }
		public string Age { get; set; }
	}
}
