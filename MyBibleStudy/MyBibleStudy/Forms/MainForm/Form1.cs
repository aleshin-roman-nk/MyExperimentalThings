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

/*
 * В этом классе формы может хранится указание на текущее состяние данных, например какой то выбранный элемент коллекции.
 * 
 */

namespace MyBibleStudy
{
	public partial class Form1 : Form, IMainView
	{
		BindingSource bsMain;
		BindingSource bsWeeks;

		SessionState sessionState;

		public Form1()
		{
			InitializeComponent();

			bsMain = new BindingSource();
			bsWeeks = new BindingSource();
			bsWeeks.CurrentItemChanged += BsWeeks_CurrentItemChanged;
		}

		private void BsWeeks_CurrentItemChanged(object sender, EventArgs e)
		{
			var weekname = bsWeeks.Current as string;

			WeekChanged?.Invoke(weekname);
			txtWeek.Text = weekname;
		}

		public event Action StartSession;
		public event Action StopSession;
		public event Action SaveSessions;
		public event Action LoadSessions;
		public event Action CloseForm;
		public event Action<string> WeekChanged;
		public event Action BtnShowWordBank;
		public event Action BtnOpenWeekPlane;
		public event Action PauseSession;

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
			this.ValidateChildren();// Без этого при закрытии формы не происходит автоматического сохранения в поле Body
			CloseForm?.Invoke();
		}

		public void SetTotal(string time)
		{
			txtTotalTime.Text = $"Общее время : {time}";
		}

		public void SetWeeks(IEnumerable<string> weeks)
		{
			lbWeeks.DataSource = bsWeeks;
			bsWeeks.DataSource = weeks;
			bsWeeks.ResetBindings(false);
		}

		private void txtWeek_Click(object sender, EventArgs e)
		{
			BtnOpenWeekPlane?.Invoke();
		}

		private void txtWeek_MouseLeave(object sender, EventArgs e)
		{
			(sender as Control).ForeColor = Color.FromArgb(97, 142, 192);
		}

		private void txtWeek_MouseEnter(object sender, EventArgs e)
		{
			(sender as Control).ForeColor = Color.Coral;
			
		}

		private void chbAlwaysOnTop_CheckedChanged(object sender, EventArgs e)
		{
			TopMost = chbAlwaysOnTop.Checked;
		}

		private void btnBank_Click(object sender, EventArgs e)
		{
			BtnShowWordBank?.Invoke();
		}
		public bool UserAnswerYes(string msg)
		{
			return MessageBox.Show(msg, "Q", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
		}

		private void btnPause_Click(object sender, EventArgs e)
		{
			PauseSession?.Invoke();
		}

		public void SetSessionState(SessionState state)
		{
			setSessionStateInternal(state);
		}

		void setSessionStateInternal(SessionState state)
		{
			sessionState = state;

			switch (sessionState)
			{
				case SessionState.Closed:
				case SessionState.NoSession:
					btnStart.Enabled = true;
					btnEnd.Enabled = false;
					btnPause.Enabled = false;
					break;
				case SessionState.Working:
					btnStart.Enabled = false;
					btnEnd.Enabled = true;
					btnPause.Enabled = true;
					break;
				case SessionState.Paused:
					btnStart.Enabled = true;
					btnEnd.Enabled = false;
					btnPause.Enabled = false;
					break;
				default:
					break;
			}
		}
	}
}
