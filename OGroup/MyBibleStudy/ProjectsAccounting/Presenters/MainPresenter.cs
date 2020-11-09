using DrRomic.Dialogs;
using ProjectsAccounting.BL.Models;
using ProjectsAccounting.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsAccounting.Presenters
{
	public class MainPresenter
	{
		IMainView view;
		ProjectsManager model;
		public MainPresenter(IMainView v)
		{
			view = v;
			model = new ProjectsManager(@"..\Projects");
			view.SetProjectList(model.Projects);
			view.BtnAddProject += View_BtnAddProject;
		}

		private void View_BtnAddProject()
		{
			var name = InputBox.GetText("Введите имя проекта");
			if (string.IsNullOrWhiteSpace(name)) return;

			model.AddProject(name);
			view.SetProjectList(model.Projects);
		}
	}
}
