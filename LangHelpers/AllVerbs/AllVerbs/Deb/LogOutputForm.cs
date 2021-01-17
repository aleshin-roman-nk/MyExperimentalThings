using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllVerbs.Deb
{
	public partial class LogOutputForm : Form
	{
		public LogOutputForm()
		{
			InitializeComponent();
		}

		public void AppendLog(string msg)
		{
			richTextBox1.AppendText($"{msg}");
		}
	}
}
