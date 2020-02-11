using PanelsManagmentExample.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanelsManagmentExample
{
	public class Presenter
	{
		DataModel model;
		IMainView view;

		public Presenter(IMainView v)
		{
			view = v;
			model = new DataModel();

			view.Message += View_Message;
			view.Request += View_Request;

			view.Init();
		}

		private void View_Request(ReqData obj)
		{
			model.Routing(obj);
		}

		private void View_Message(string obj)
		{
			view.SetText($"handled by model: {obj}");
		}
	}
}
