using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatMeDid.BL
{
	public static class DbAccept
	{
		public static void SaveReports(ReportCollection o, string filename)
		{
			string j = Newtonsoft.Json.JsonConvert.SerializeObject(o, Newtonsoft.Json.Formatting.Indented);
			File.WriteAllText(filename, j, Encoding.UTF8);
		}
		public static ReportCollection LoadReports(string filename)
		{
			if (!File.Exists(filename))
			{
				return new ReportCollection();
			}

			string j = File.ReadAllText(filename, Encoding.UTF8);
			return Newtonsoft.Json.JsonConvert.DeserializeObject<ReportCollection>(j);
		}
		public static void SaveTasks(TaskCollection o, string filename)
		{
			string j = Newtonsoft.Json.JsonConvert.SerializeObject(o, Newtonsoft.Json.Formatting.Indented);
			File.WriteAllText(filename, j, Encoding.UTF8);
		}
		public static TaskCollection LoadTasks(string filename)
		{
			if (!File.Exists(filename))
			{
				return new TaskCollection();
			}

			string j = File.ReadAllText(filename, Encoding.UTF8);
			return Newtonsoft.Json.JsonConvert.DeserializeObject<TaskCollection>(j);
		}
	}
}
