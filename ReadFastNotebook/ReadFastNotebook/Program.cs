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

				ShowNootes.GetNotes("notes.text", "notes.index");
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
