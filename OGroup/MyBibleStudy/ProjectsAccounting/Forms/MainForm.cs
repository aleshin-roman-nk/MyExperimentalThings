using ProjectsAccounting.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectsAccounting
{
	public partial class MainForm : Form, IMainView
	{
		BindingSource bsProjects = new BindingSource();

		public MainForm()
		{
			InitializeComponent();
			lbPeojects.DataSource = bsProjects;
		}

		public event Action BtnAddProject;

		public void SetProjectList(IEnumerable<string> prjs)
		{
			bsProjects.DataSource = prjs;
			bsProjects.ResetBindings(false);
		}

		private void btnCreatePoject_Click(object sender, EventArgs e)
		{
			BtnAddProject?.Invoke();
		}

		private void myCalendar1_DateChoosed(DateTime obj)
		{
			Text = ThisWeekName(obj);
		}

		public string ThisWeekName(DateTime obj)
		{
			DateTime dt = obj;

			int diff = (7 + (dt.DayOfWeek - DayOfWeek.Monday)) % 7;
			return $"Week_{dt.AddDays(-1 * diff).Date.ToString("dd_MM_yyyy")}";
		}
	}
}
