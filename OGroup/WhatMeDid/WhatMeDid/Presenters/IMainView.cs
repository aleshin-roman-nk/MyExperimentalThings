using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhatMeDid.BL;

namespace WhatMeDid.Presenters
{
	public enum NotationLevel { Task, Report }
	public interface IMainView
	{
		event Action<DateTime> DateChanged;
		event Action<NotationLevel> NotationLevelChanged;
		event Action<IDayNotation> SaveNotation;
		//void PutReport(DayReport notation);
		event Action ReindexTasks;
		void PutNotation(IDayNotation notation);
		DateTime CurrentDate { get; }
		NotationLevel CurrentLevel { get; }
	}
}
