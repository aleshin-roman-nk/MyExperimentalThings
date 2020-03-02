using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBibleStudy.BL
{
	public class WorkSessionsData
	{
		public int Count { get; set; }
		public List<WorkSession> WorkSessions { get; set; }
		public WorkSession LastWorkSession { get; set; }
		public void Start()
		{
			LastWorkSession = new WorkSession();
			LastWorkSession.Started = DateTime.Now;
		}
		public void Stop()
		{

		}
	}
}
