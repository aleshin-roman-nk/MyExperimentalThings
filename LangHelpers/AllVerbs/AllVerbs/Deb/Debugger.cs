using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllVerbs.Deb
{
	public static class Debugger
	{
		static string file_name = "output.log";
		static LogOutputForm logOutputForm = null;
		public static void Log(string msg)
		{
			File.AppendAllText(file_name, msg, Encoding.UTF8);
		}
		public static void LogToConsole(string msg)
		{
			if (logOutputForm == null) logOutputForm = new LogOutputForm();

			logOutputForm.Show();

			logOutputForm.AppendLog($"{DateTime.Now:T} | {msg}\n");
		}

		public static void ShowObject(object o)
		{
			string j = Newtonsoft.Json.JsonConvert.SerializeObject(o, Newtonsoft.Json.Formatting.Indented);
			MessageBox.Show(j);
		}
	}
}
