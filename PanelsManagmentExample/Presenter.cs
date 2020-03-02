using DrRomic.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrRomic
{
	public class Presenter
	{
		RequestRouter requestModel;
		IMainView view;

		public Presenter(IMainView v)
		{
			view = v;
			requestModel = new RequestRouter();

			view.OnMessage += View_OnMessage;
			view.OnRequest += View_OnRequest;

			view.Init();
		}

		private void View_OnRequest(Requset obj)
		{
			requestModel.GetResponse(obj);
		}

		private void View_OnMessage(string obj)
		{
			view.SetText($"handled by model: {obj}");
		}
	}
}
