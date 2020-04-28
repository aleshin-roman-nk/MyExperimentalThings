﻿using MyBibleStudy.BL;
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
		void SetTotal(string time);
		void SetWeeks(IEnumerable<string> weeks);
		bool UserAnswerYes(string msg);

		event Action StartSession;
		event Action StopSession;
		event Action SaveSessions;
		event Action LoadSessions;
		event Action CloseForm;
		event Action<string> WeekChanged;
		event Action BtnShowWordBank;
		event Action BtnOpenWeekPlane;
	}
}
