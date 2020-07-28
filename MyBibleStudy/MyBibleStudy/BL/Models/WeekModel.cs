using MyBibleStudy.BL.DataSources;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBibleStudy.BL.Models
{
	public class WeekModel
	{
		Week _week = null;

		//public Week Week { get => _week; }
		public SessionState GetLastSessionState()
		{
			var last = LastSession;

			if (last == null) return SessionState.NoSession;
			return last.SessionState;
		}
		public void CheckIfExists(DateTime dt)
		{
			FileManager.CreateWeekWork(dt);
		}
		public void Save()
		{
			if (_week == null) return;
			WeekFile.Save(_week);
		}
		public void Load(string week_name)
		{
			_week = WeekFile.Load(week_name);
		}
		public void OpenWeekPlan()
		{
			if (_week == null) return;

			var fname = FileManager.WeekPlanFileName(_week.Name);

			Process.Start("notepad++.exe", fname);
		}
		public string TotalTimeTitle
		{
			get
			{
				var total_minutes = WorkSessionsOrdered.Sum(x => x.SessionState == SessionState.Closed ? x.TotalTimeInMinutes : 0);
				decimal hours = total_minutes / 60.0m;

				var minutes = ((hours - (long)hours) * 60.0m);

				return $"{(long)hours} ч, {minutes:f0} мин";
			}
		}
		public WorkSession LastSession
		{
			get
			{
				return _week.workSessions.LastOrDefault();
			}
		}
		public IEnumerable<WorkSession> WorkSessionsOrdered
		{
			get => _week.workSessions.OrderByDescending(x => x.Started).ToList();
		}
		public void Start(DateTime starttime)
		{
			var last = LastSession;
			if (last == null || last.IsClosed)
			{
				_week.workSessions.Add(new WorkSession
				{
					Started = starttime,
					SessionState = SessionState.Working
				});

				return;
			}

			Resume(starttime);
		}
		public void Stop(DateTime stoptime)
		{
			var last = LastSession;
			if (last == null) return;

			if (last.IsClosed) return;

			last.Ended = stoptime;
			last.SessionState = SessionState.Closed;

			var pause = last.LastPause;

			if (pause == null) return;

			pause.Closed = true;
			pause.End = stoptime;
		}
		public void Pause(DateTime pause_start)
		{
			var last = LastSession;
			if (last == null) return;
			if (last.IsClosed) return;

			if (last.SessionState == SessionState.Paused) return;

			SessionPause pause = new SessionPause();
			pause.Start = pause_start;

			last.Pauses.Add(pause);

			last.SessionState = SessionState.Paused;
		}
		public void Resume(DateTime pause_end)
		{
			var last = LastSession;
			if (last == null) return;
			if (last.IsClosed) return;

			if (last.SessionState == SessionState.Working) return;
			if (last.SessionState == SessionState.Closed) return;

			SessionPause pause = last.LastPause;

			pause.Closed = true;
			pause.End = pause_end;

			last.SessionState = SessionState.Working;
		}
	}
}
