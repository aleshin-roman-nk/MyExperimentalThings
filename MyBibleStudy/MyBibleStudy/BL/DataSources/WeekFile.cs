using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBibleStudy.BL.DataSources
{
	public static class WeekFile
	{
		const string sessions_file_name = @"sessions.json";
		public static Week Load(string week_name)
		{
			var currentSessions = $"{week_name}\\{sessions_file_name}";
			var res = new Week();
			res.Name = week_name;

			if (File.Exists(currentSessions))
			{
				string j = File.ReadAllText(currentSessions, Encoding.UTF8);
				res.workSessions = Newtonsoft.Json.JsonConvert.DeserializeObject<List<WorkSession>>(j);
			}
			else
			{
				res.workSessions = new List<WorkSession>();
			}

			return res;
		}
		public static void Save(Week week)
		{
			var currentSessions = $"{week.Name}\\{sessions_file_name}";
			string j = Newtonsoft.Json.JsonConvert.SerializeObject(week.workSessions, Newtonsoft.Json.Formatting.Indented);
			File.WriteAllText(currentSessions, j, Encoding.UTF8);
		}
		public static string[] Weeks
		{
			get
			{
				var dirs = Directory.GetDirectories(Directory.GetCurrentDirectory(), "Week_*");
				var week_names = dirs.Select(x => x.Split(new char[] { '\\', '/' }).Last());

				return week_names.OrderByDescending((x) =>
				{

					var s = x.Remove(0, "Week_".Length);
					var datestr = s.Replace("_", ".");
					return DateTime.Parse(datestr);

				}).ToArray();
			}
		}
	}

//////////////////////

	public static class FileManager
	{
		public static void CreateWeekWork(DateTime dt)
		{
			var dirName = ThisWeekName;
			string fname = WorkFileName(dt);

			string fullName = $"{dirName}\\{fname}";

			if (!Directory.Exists(dirName))
				Directory.CreateDirectory(dirName);

			if (!IsExist(fullName))
				File.WriteAllText(fullName, $"{DATE_TAG(dt)}{Environment.NewLine}", Encoding.UTF8);

			string week_plan_file = $"{dirName}\\week_plan.txt";

			if (!IsExist(week_plan_file))
				File.WriteAllText(week_plan_file, $"WEEK :{ThisWeekName}{Environment.NewLine}TO DO LIST:{Environment.NewLine}", Encoding.UTF8);
		}
		public static string WeekPlanFileName(string week_name)
		{
			return $"{week_name}\\week_plan.txt";
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
		private static string WorkFileName(DateTime dt)
		{
			string name = $"[{dt.DayOfWeek.ToString("d")}]_{dt.ToString("dd_MM_yyyy")}.txt";
			return name;
		}
		private static bool IsExist(string name)
		{
			return File.Exists(name);
		}

		private static string DATE_TAG(DateTime dt)
		{
			return $"date: {dt.ToString("dd-MM-yyyy")}";
		}
	}
}
