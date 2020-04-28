using MyBibleStudy.BL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBibleStudy
{
	public class MainPresenter
	{
		IMainView view;
		WeeksModel model;
		Week current_week = null;

		public MainPresenter(IMainView v)
		{
			view = v;
			model = new WeeksModel();
			model.CheckThisWeek(DateTime.Today);

			view.SaveSessions += View_SaveSessions;
			view.StartSession += View_StartSession;
			view.StopSession += View_StopSession;
			view.CloseForm += View_CloseForm;
			view.WeekChanged += View_WeekChanged;
			view.BtnShowWordBank += View_BtnShowWordBank;
			view.BtnOpenWeekPlane += View_BtnOpenWeekPlane;

			view.SetWeeks(model.Weeks);

		}

		private void View_BtnOpenWeekPlane()
		{
			if (current_week == null) return;

			model.OpenWeekPlan(current_week.Name);
		}

		private void View_BtnShowWordBank()
		{
			WordBankPresenter presenter = new WordBankPresenter(new RepetitionForm());
			presenter.Go();
		}

		private void View_WeekChanged(string obj)
		{
			if(current_week == null)
			{
				current_week = model.Load(obj);
			}
			else
			{
				model.Save(current_week);
				current_week = model.Load(obj);
			}
			
			view.SetSessions(current_week.WorkSessionsOrdered);
			view.SetTotal(current_week.TotalTimeTitle);
		}

		private void View_CloseForm()
		{
			if (current_week == null) return;
			model.Save(current_week);
		}

		private void View_StopSession()
		{
			if (current_week == null) return;

			current_week.Stop(DateTime.Now);
			view.SetSessions(current_week.WorkSessionsOrdered);
			view.SetTotal(current_week.TotalTimeTitle);
			model.Save(current_week);
		}

		private void View_StartSession()
		{
			if (current_week == null) return;

			current_week.Start(DateTime.Now);
			view.SetSessions(current_week.WorkSessionsOrdered);
			model.Save(current_week);
		}

		private void View_SaveSessions()
		{
			if (current_week == null) return;

			model.Save(current_week);
		}
	}
}
