using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBibleStudy.BL
{
	public class Week
	{
		public string Name { get; set; }
		public List<WorkSession> workSessions { get; set; }
		//public TimeSpan TotalTime
		//{
		//	get
		//	{
		//		var items = WorkSessionsOrdered.Select(x => x.Ended - x.Started);
		//		TimeSpan res = new TimeSpan(0, 0, 0);
		//		foreach (var item in items)
		//		{
		//			res += item;
		//		}
		//		return res;
		//	}
		//}
		public string TotalTimeTitle
		{
			get
			{
				var total_minutes = WorkSessionsOrdered.Sum(x => x.Finished ? (x.Ended - x.Started).TotalMinutes : 0);
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
		public bool Start(DateTime starttime)
		{
			var last = LastSession;
			if (last == null)
			{
				workSessions.Add(new WorkSession
				{
					Started = starttime,
					Finished = false
				});

				return true;
			}

			if (!last.Finished) return false;

			workSessions.Add(new WorkSession
			{
				Started = starttime,
				Finished = false
			});

			return true;
		}
		public void Stop(DateTime stoptime)
		{
			var last = LastSession;
			if (last == null) return;

			if (last.Finished) return;

			last.Ended = stoptime;
			last.Finished = true;
		}
	}
}
