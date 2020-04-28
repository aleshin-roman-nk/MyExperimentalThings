using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBibleStudy.BL
{
	public class WorkSession
	{
		public DateTime Started { get; set; }
		public DateTime Ended { get; set; }
		public string Title { get; set; }
		public string Notes { get; set; }
		public bool Finished { get; set; }
		public List<SessionPause> Pauses { get; set; } = new List<SessionPause>();
		public long AllPausesMinutes
		{
			get
			{
				return (long)Pauses.Sum(x => x.Total.TotalMinutes);
			}
		}
		public long TotalTimeMinutes
		{
			get
			{
				var totalWork = (Ended - Started).TotalMinutes;
				return ((long)totalWork - AllPausesMinutes);
			}
		}
		public string VisibleTitle 
		{ 
			get 
			{
				DateTime _s = new DateTime(Started.Year, Started.Month, Started.Day);
				DateTime _e = new DateTime(Ended.Year, Ended.Month, Ended.Day);

				//string endFormat;

				//if (_e == _s) endFormat = "H:mm";
				//else endFormat = "dd.MM.yyyy H:mm";

				//string total_minutes = Finished ? Ended.ToString(endFormat) : "*";
				string total_minutes = Finished ? TotalTimeMinutes.ToString() : "*";

				return $"{Started.ToString("dd.MM.yyyy H:mm")} - {total_minutes}"; 
			} 
		}
	}
}
