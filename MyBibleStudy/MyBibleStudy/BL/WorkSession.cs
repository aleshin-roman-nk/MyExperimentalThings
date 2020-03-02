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
		public string VisibleTitle 
		{ 
			get 
			{
				DateTime _s = new DateTime(Started.Year, Started.Month, Started.Day);
				DateTime _e = new DateTime(Ended.Year, Ended.Month, Ended.Day);

				string endFormat;

				if (_e == _s) endFormat = "H:mm:ss";
				else endFormat = "dd.MM.yyyy H:mm:ss";

				string end_time = Finished ? Ended.ToString(endFormat) : "*";
				return $"{Started.ToString("dd.MM.yyyy H:mm:ss")} - {end_time}"; 
			} 
		}
	}
}
