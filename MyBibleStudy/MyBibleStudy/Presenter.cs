using MyBibleStudy.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBibleStudy
{
	public class Presenter
	{
		IMainView view;
		WorkSessionsManager model;


		public Presenter(IMainView v)
		{
			view = v;
			model = new WorkSessionsManager();
			model.Load();

			view.SaveSessions += View_SaveSessions;
			view.StartSession += View_StartSession;
			view.StopSession += View_StopSession;
			view.CloseForm += View_CloseForm;

			view.SetSessions(model.WorkSessions);
			view.SetTotal(model.TotalTime);
		}

		private void View_CloseForm()
		{
			model.Save();
		}

		private void View_StopSession()
		{
			model.Stop(DateTime.Now);
			view.SetSessions(model.WorkSessions);
			view.SetTotal(model.TotalTime);
		}

		private void View_StartSession()
		{
			model.Start(DateTime.Now);
			view.SetSessions(model.WorkSessions);
		}

		private void View_SaveSessions()
		{
			model.Save();
		}
	}
}
