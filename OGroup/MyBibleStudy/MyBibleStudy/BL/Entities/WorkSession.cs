using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vedeg.BL
{
	public class WorkSession
	{
		public DateTime Started { get; set; }
		public DateTime Ended { get; set; }
		public string Title { get; set; }
		public string Notes { get; set; }
		public SessionState SessionState {get;set;}
		public bool IsClosed
		{
			get
			{
				return SessionState == SessionState.Closed;
			}
		}
		public List<SessionPause> Pauses { get; set; } = new List<SessionPause>();
		public SessionPause LastPause
		{
			get
			{
				return Pauses.LastOrDefault();
			}
		}
		public long TotalPausesInMinutes
		{
			get
			{
				return (long)Pauses.Sum(x => x.Total.TotalMinutes);
			}
		}
		public long TotalTimeInMinutes
		{
			get
			{
				var totalWork = (Ended - Started).TotalMinutes;
				return ((long)totalWork - TotalPausesInMinutes);
			}
		}
		public string VisibleTitle 
		{ 
			get 
			{
				DateTime _s = new DateTime(Started.Year, Started.Month, Started.Day);
				DateTime _e = new DateTime(Ended.Year, Ended.Month, Ended.Day);

				string total_minutes = "";

				if (SessionState == SessionState.Closed) total_minutes = TotalTimeInMinutes.ToString();
				else if (SessionState == SessionState.Paused) total_minutes = "[*]";
				else if (SessionState == SessionState.Working) total_minutes = "*";

				return $"{Started:dd.MM.yyyy H:mm} - {total_minutes}"; 
			} 
		}
	}

	public enum SessionState { Closed = 0, Working = 1, Paused = 2, NoSession = 3 }
}