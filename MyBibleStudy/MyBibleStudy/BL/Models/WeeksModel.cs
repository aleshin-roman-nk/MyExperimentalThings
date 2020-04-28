using MyBibleStudy.BL.DataSources;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Project -> session
 * 
 * 
 * 
 * session : tag_begin; tag_end; tag_pause; tag_resume;
 *			session_info (txt, different files)
 * 
 * Project -> part
 * 
 * PlannedWork: link to Project.Part
 * 
 */


namespace MyBibleStudy.BL
{
	public class WeeksModel
	{
		public void CheckThisWeek(DateTime dt)
		{
			FileManager.CreateWeekWork(dt);
		}
		public void Save(Week week)
		{
			WeekFile.Save(week);
		}
		public Week Load(string week_name)
		{
			return WeekFile.Load(week_name);
		}
		public string[] Weeks
		{
			get
			{
				return WeekFile.Weeks;
			}
		}
		public void OpenWeekPlan(string week_name)
		{
			var fname = FileManager.WeekPlanFileName(week_name);

			Process myProcess = new Process();
			Process.Start("notepad++.exe", fname);
		}
	}
}
