using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpMonthCalendarBuildTasks.BL
{
	public class TestClass
	{
		public event EventHandler MyEvent;

		public void Run()
		{
			MyEvent?.Invoke(this, EventArgs.Empty);
		}
	}
}
