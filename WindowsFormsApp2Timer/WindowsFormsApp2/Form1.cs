using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class Form1 : Form, IView
	{
		public Form1()
		{
			InitializeComponent();
		}
		decimal sec = 0;
		private void btnStart_Click(object sender, EventArgs e)
		{
			timer1.Start();

		}
		bool tick = false;
		Color col1 = Color.FromArgb(0x78FF0000);
		Color col2 = Color.FromArgb(0x7800FF00);

		public decimal sign { get; set; }

		public event Action<decimal> Tick;

		private void timer1_Tick(object sender, EventArgs e)
		{
			tick = !tick;
			label1.BackColor = tick ? col1 : col2;
			sec += (decimal)0.5;
			label1.Text = sec.ToString();
			Tick?.Invoke(sec);
		}

		private void tnStop_Click(object sender, EventArgs e)
		{
			timer1.Stop();
		}
	}
}
