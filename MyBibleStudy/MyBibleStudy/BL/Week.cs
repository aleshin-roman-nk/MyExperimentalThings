using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBibleStudy.BL
{
	public class Week
	{
		public string Name { get; set; }
		public List<WorkSession> workSessions { get; set; }

		public string TotalTimeTitle
		{
			get
			{
				var total_minutes = WorkSessionsOrdered.Sum(x => x.SessionState == SessionState.Closed ? (x.Ended - x.Started).TotalMinutes : 0);
				var hours = total_minutes / 60;
				var minutes = (long)((hours - (long)hours) * 60);
				return $"{(long)hours}:{minutes}";
			}
		}
		public WorkSession LastSession
		{
			get
			{
				return workSessions.LastOrDefault();
			}
		}
		public IEnumerable<WorkSession> WorkSessionsOrdered
		{ 
			get => workSessions.OrderByDescending(x => x.Started).ToList(); 
		}
		public void Start(DateTime starttime)
		{
			var last = LastSession;
			if (last == null || last.IsClosed)
			{
				workSessions.Add(new WorkSession
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
