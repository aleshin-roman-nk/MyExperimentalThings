using StudyProtocol.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProtocol.DbAccess
{
	public class WorkDayManager
	{
		bool sqlite_initialized { get; set; } = false;// в этом проекте хочу иметь DbContext на весь жизненный цикл.

		public void Init()
		{
			sqlite_initialized = true;
		}
		public void AddWorkDay(WorkDay wd)
		{

		}

		public void AddWorkTo(WorkDay wd)
		{
			
		}

		public void AddMarker()
		{

		}

		//public void Add
	}
}
