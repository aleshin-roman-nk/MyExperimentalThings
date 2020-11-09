using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsAccounting.BL.Entities
{
	public class SessionPause
	{
		public int Id { get; set; }
		public DateTime PauseStart { get; set; }
		public DateTime PauseStop { get; set; }
		public TimeSpan TotalTime
		{
			get
			{
				return PauseStop - PauseStart;
			}
		}
	}
}
