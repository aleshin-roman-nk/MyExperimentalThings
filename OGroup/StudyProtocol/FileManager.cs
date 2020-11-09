using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProtocol
{
	public static class FileManager
	{
		public static string CreateName()
		{
			DateTime today = DateTime.Today;

			string name = $"prc_{today.ToString("dd_MM_yyyy")}.txt";

			return name;
		}

		public static bool IsExist(string name)
		{
			return File.Exists(name);
		}

	}
}
