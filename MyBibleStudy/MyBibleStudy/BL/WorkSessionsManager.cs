using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBibleStudy.BL
{
	public class WorkSessionsManager
	{
		const string fileName = @"notes.txt";

		public IEnumerable<WorkSession> WorkSessions { get => workSessions.OrderByDescending(x=>x.Started).ToList(); }

		public TimeSpan TotalTime
		{
			get
			{
				var items = WorkSessions.Select(x=> x.Ended - x.Started);
				TimeSpan res = new TimeSpan(0, 0, 0);
				foreach (var item in items)
				{
					res += item;
				}
				return res;
			}
		}

		List<WorkSession> workSessions { get; set; }

		public WorkSession LastSession
		{
			get
			{
				return workSessions.LastOrDefault();
			}
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

		public void Save()
		{
			string j = Newtonsoft.Json.JsonConvert.SerializeObject(workSessions,Newtonsoft.Json.Formatting.Indented);
			File.WriteAllText(fileName, j, Encoding.UTF8);
		}

		public void Load()
		{
			if (File.Exists(fileName))
			{
				string j = File.ReadAllText(fileName, Encoding.UTF8);
				workSessions = Newtonsoft.Json.JsonConvert.DeserializeObject<List<WorkSession>>(j);
			}
			else
			{
				workSessions = new List<WorkSession>();
			}
		}
	}
}
