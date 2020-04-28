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
			FileManager.CreateWeekWork(dt);
		}
	}
	public static class FileManager
	{
		public static string WorkFileName(DateTime dt)
		{
			string name = $"[{dt.DayOfWeek.ToString("d")}]_{dt.ToString("dd_MM_yyyy")}.txt";
			return name;
		}

		public static string ThisWeekName
		{
			get
			{
				DateTime dt = DateTime.Today;
				
				int diff = (7 + (dt.DayOfWeek - DayOfWeek.Monday)) % 7;
				return $"Week_{dt.AddDays(-1 * diff).Date.ToString("dd_MM_yyyy")}";
			}
		}

		public static bool IsExist(string name)
		{
			return File.Exists(name);
		}

		private static string DATE_TAG(DateTime dt)
		{
			return $"date: {dt.ToString("dd-MM-yyyy")}";
		}

		public static void CreateWeekWork(DateTime dt)
		{
			//var dirName = $"{dt.ToString("dd-MM-yyyy")}";
			var dirName = ThisWeekName;
			string fname = WorkFileName(dt);

			string fullName = $"{dirName}\\{fname}";

			if (!Directory.Exists(dirName))
				Directory.CreateDirectory(dirName);

			if (!IsExist(fullName))
				File.WriteAllText(fullName, $"{DATE_TAG(dt)}{Environment.NewLine}", Encoding.UTF8);

			string week_plan_file = $"{dirName}\\week_plan.txt";

			if(!IsExist(week_plan_file))
				File.WriteAllText(week_plan_file, $"TO DO LIST:{Environment.NewLine}", Encoding.UTF8);
		}
	}
}
