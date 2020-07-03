using MultiPtesenterExp.BL.Entities;
using MultiPtesenterExp.BL.Models;
using MultiPtesenterExp.Forms.Dialogs;
using MultiPtesenterExp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiPtesenterExp.Presenters
{
	public class ManagerPresenterPart
	{
		IManagersViewPart _view;

		public ManagerPresenterPart(IManagersViewPart v)
		{
			_view = v;
			_view.ShowCmd += _view_ShowCmd;
		}

		private void _view_ShowCmd()
		{
			Manager ent = new Manager();
			ent.Id = 1;
			ent.Name = _view.NameB;
			ent.Salary = _view.Salary;

			//ManagerModel model = new ManagerModel();
			//model.Entry(ent).AddSalary(90);

			//MsgDialogs.ShowMessage(model.Entry(ent).FullName());

			ManagerModel model = new ManagerModel(ent);
			model.AddSalary(90);

			MsgDialogs.ShowMessage(model.FullName);
		}
	}
}
