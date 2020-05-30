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
		public Week Week { get; set; } = null;

		public SessionState GetLastSessionState()
		{
			var last = Week.LastSession;

			if (last == null) return SessionState.NoSession;
			return last.SessionState;
		}

		public void CheckThisWeek(DateTime dt)
		{
			FileManager.CreateWeekWork(dt);
		}
		public void Save()
		{
			if (Week == null) return;
			WeekFile.Save(Week);
		}
		public void Load(string week_name)
		{
			Week = WeekFile.Load(week_name);
		}
		public string[] Weeks
		{
			get
			{
				return WeekFile.Weeks;
			}
		}
		public void OpenWeekPlan()
		{
			if (Week == null) return;

			var fname = FileManager.WeekPlanFileName(Week.Name);

			Process myProcess = new Process();
			Process.Start("notepad++.exe", fname);
		}
	}
}
