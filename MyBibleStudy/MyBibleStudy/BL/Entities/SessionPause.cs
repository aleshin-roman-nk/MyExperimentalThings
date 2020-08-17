using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * >>>
 * 24-04-2020 2-37
 * Правка сессии в своем окне.
 * Там список прерываний (пауз) и изменение времени начала и закрытия
 * 
 * 
 * 
 */

namespace Vedeg.BL
{
	public class SessionPause
	{
		public DateTime Start { get; set; }
		public DateTime End { get; set; }
		public bool Closed { get; set; } = false;
		public TimeSpan Total
		{
			get
			{
				if (!Closed) return new TimeSpan(0, 0, 0);
				return End - Start;
			}
		}
	}
}
