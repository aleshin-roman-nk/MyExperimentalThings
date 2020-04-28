using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsAccounting.BL.Entities
{
	public class Session
	{
		public int Id { get; set; }
		public int ProjTaskId { get; set; }
		public string BodyFile { get; set; }
		public DateTime Start { get; set; }
		public DateTime Stop { get; set; }
		public List<SessionPause> SessionPauses { get; set; } = new List<SessionPause>();
		public TimeSpan TotalTime
		{
			get
			{
				var total_time = Stop - Start;

				foreach (var pause in SessionPauses)
				{
					total_time = total_time.Subtract(pause.TotalTime);
				}

				return total_time;
			}
		}
	}
}
