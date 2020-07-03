using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiPtesenterExp.Views;

namespace MultiPtesenterExp.Forms.UC
{
	public partial class ManagersUCcs : UserControl, IManagersViewPart
	{
		public ManagersUCcs()
		{
			InitializeComponent();
		}

		public string NameA { get => txtNameA.Text; }
		public string NameB { get => txtNameB.Text; }
		public int Salary { get { return int.Parse(txtSalary.Text); } }

		public event Action ShowCmd;

		private void btnShow_Click(object sender, EventArgs e)
		{
			ShowCmd?.Invoke();
		}
	}
}
