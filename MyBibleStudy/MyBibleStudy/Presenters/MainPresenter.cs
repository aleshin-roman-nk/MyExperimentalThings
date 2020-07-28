using MyBibleStudy.BL;
using MyBibleStudy.BL.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBibleStudy
{
	public class MainPresenter
	{
		IMainView view;
		WeeksModel model;
		WeekModel _weekModel;

		public MainPresenter(IMainView v)
		{
			view = v;
			model = new WeeksModel();
			_weekModel = new WeekModel();
			//model.CheckThisWeek(DateTime.Today);

			view.SaveSessions += View_SaveSessions;
			view.StartSession += View_StartSession;
			view.StopSession += View_StopSession;
			view.CloseForm += View_CloseForm;
			view.WeekChanged += View_WeekChanged;
			view.BtnShowWordBank += View_BtnShowWordBank;
			view.BtnOpenWeekPlane += View_BtnOpenWeekPlane;
			view.PauseSession += View_PauseSession;

			view.SetWeeks(model.Weeks);
		}

		private void View_PauseSession()
		{
			if (model.Week == null) return;
			
			model.Week.Pause(DateTime.Now);
			view.SetSessions(model.Week.WorkSessionsOrdered);
			view.SetTotal(model.Week.TotalTimeTitle);
			model.Save();

			view.SetSessionState(model.GetLastSessionState());
		}

		private void View_BtnOpenWeekPlane()
		{
			model.OpenWeekPlan();
		}

		private void View_BtnShowWordBank()
		{
			WordBankPresenter presenter = new WordBankPresenter(new RepetitionForm());
			presenter.Go();
		}

		private void View_WeekChanged(string obj)
		{
			_weekModel.Load(obj);
			//if(model.Week == null)
			//{
			//	model.Load(obj);
			//}
			//else
			//{
			//	model.Save();
			//	model.Load(obj);
			//}

			//view.SetSessions(model.Week.WorkSessionsOrdered);
			//view.SetTotal(model.Week.TotalTimeTitle);

			//view.SetSessionState(model.GetLastSessionState());
		}

		private void View_CloseForm()
		{
			model.Save();
		}

		private void View_StopSession()
		{
			if (model.Week == null) return;

			model.Week.Stop(DateTime.Now);
			view.SetSessions(model.Week.WorkSessionsOrdered);
			view.SetTotal(model.Week.TotalTimeTitle);
			model.Save();

			view.SetSessionState(model.GetLastSessionState());
		}

		private void View_StartSession()
		{
			if (model.Week == null) return;

			model.Week.Start(DateTime.Now);
			view.SetSessions(model.Week.WorkSessionsOrdered);
			model.Save();

			view.SetSessionState(model.GetLastSessionState());
		}

		private void View_SaveSessions()
		{
			model.Save();
		}
	}
}
