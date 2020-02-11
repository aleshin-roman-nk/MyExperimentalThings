using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace todayprot
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime dt = DateTime.Today;

			string name = FileManager.CreateName(dt);
			FileManager.CheckAndCreate(dt);
		}
	}
	public static class FileManager
	{
		public static string CreateName(DateTime dt)
		{
			string name = $"prc_{dt.ToString("dd_MM_yyyy")}.txt";

			return name;
		}

		public static bool IsExist(string name)
		{
			return File.Exists(name);
		}

		private static string DATE_TAG(DateTime dt)
		{
			return $"date: {dt.ToString("dd-MM-yyyy")}";
		}

		public static void CheckAndCreate(DateTime dt)
		{
			var dirName = $"{dt.ToString("dd-MM-yyyy")}";
			string fname = CreateName(dt);

			string fullName = $"{dirName}\\{fname}";

			if (!Directory.Exists(dirName))
				Directory.CreateDirectory(dirName);

			if (!IsExist(fullName))
				File.WriteAllText(fullName, $"{DATE_TAG(dt)}{Environment.NewLine}", Encoding.UTF8);
		}
	}
}
