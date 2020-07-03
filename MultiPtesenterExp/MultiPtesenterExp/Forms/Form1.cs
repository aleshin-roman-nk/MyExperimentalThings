using MultiPtesenterExp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiPtesenterExp
{
	public partial class Form1 : Form, IMainView
	{
		public Form1()
		{
			InitializeComponent();
		}

		public IManagersViewPart ManagersViewPart => managersUCcs1;
	}
}
