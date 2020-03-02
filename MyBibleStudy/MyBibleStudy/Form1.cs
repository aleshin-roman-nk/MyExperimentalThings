using MyBibleStudy.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBibleStudy
{
	public partial class Form1 : Form, IMainView
	{
		BindingSource bsMain;

		public Form1()
		{
			InitializeComponent();

			bsMain = new BindingSource();
		}

		public event Action StartSession;
		public event Action StopSession;
		public event Action SaveSessions;
		public event Action LoadSessions;
		public event Action CloseForm;

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			StartSession?.Invoke();
		}

		public void SetSessions(IEnumerable<WorkSession> workSessions)
		{
			txtTitle.DataBindings.Clear();
			txtBody.DataBindings.Clear();

			bsMain.DataSource = workSessions;
			listSessions.DataSource = bsMain;
			listSessions.DisplayMember = "VisibleTitle";

			txtTitle.DataBindings.Add("Text", bsMain, "Title");
			txtBody.DataBindings.Add("Text", bsMain, "Notes");

			bsMain.ResetBindings(false);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			SaveSessions?.Invoke();
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			LoadSessions?.Invoke();
		}

		private void btnEnd_Click(object sender, EventArgs e)
		{
			StopSession?.Invoke();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			CloseForm?.Invoke();
		}

		public void SetTotal(TimeSpan time)
		{
			txtTotalTime.Text = $"{time.Hours} : {time.Minutes} : {time.Seconds}"; 
		}
	}
}
