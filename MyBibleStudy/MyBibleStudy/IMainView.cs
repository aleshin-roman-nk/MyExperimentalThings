using MyBibleStudy.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBibleStudy
{
	public interface IMainView
	{
		void SetSessions(IEnumerable<WorkSession> workSessions);
		void SetTotal(TimeSpan time);
		event Action StartSession;
		event Action StopSession;
		event Action SaveSessions;
		event Action LoadSessions;
		event Action CloseForm;
	}
}
