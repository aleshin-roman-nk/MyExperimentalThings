using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatMeDid.BL;
using WhatMeDid.Presenters;
using WhatMeDid.Tools;

namespace WhatMeDid
{
	public partial class Form1 : Form, IMainView
	{
		bool _saved;

		public event Action<DateTime> DateChanged;
		public event Action<NotationLevel> NotationLevelChanged;
		public event Action<IDayNotation> SaveNotation;

		//DayReport currentReport;
		IDayNotation currentReport;
		NotationLevel _currentLevel;

		bool saved
		{
			get
			{
				return _saved;
			}
			set
			{
				_saved = value;
				if (_saved)
					label1.BackColor = Color.Green;
				else
					label1.BackColor = Color.Red;
			}
		}

		void setNotationLevel(NotationLevel level)
		{
			if (level == NotationLevel.Report)
			{
				richTextBox1.BackColor = Color.SeaGreen;
			}
			else if (level == NotationLevel.Task)
			{
				richTextBox1.BackColor = Color.LightSeaGreen;
			}

			_currentLevel = level;

			NotationLevelChanged?.Invoke(_currentLevel);
		}

		public DateTime CurrentDate => monthCalendar1.SelectionStart;
		public NotationLevel CurrentLevel => _currentLevel;

		public Form1()
		{
			InitializeComponent();
			Cursor c = new Cursor("..\\res\\my_txt.ico");
			richTextBox1.Cursor = c;
			setNotationLevel(NotationLevel.Task);
			UpdateModeTitle();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionLength = 0;
			richTextBox1.SelectedText = $">>> {DateTime.Now:dd-MM-yyyy HH:mm}";
			richTextBox1.Select();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			saveReport();
		}

		private void btnBold_Click(object sender, EventArgs e)
		{
			Font currentFont = richTextBox1.SelectionFont;

			richTextBox1.SelectionFont = new Font(
					currentFont.FontFamily,
					currentFont.Size,
					/*FontStyle.Underline | */FontStyle.Bold);
		}

		private void btnUnbold_Click(object sender, EventArgs e)
		{
			Font currentFont = richTextBox1.SelectionFont;

			richTextBox1.SelectionFont = new Font(
					currentFont.FontFamily,
					currentFont.Size,
					FontStyle.Regular);
		}

		void SetDayReport(IDayNotation notation)
		{
			richTextBox1.Rtf = notation.Body;
		}

		private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
		{
			if (!saved) saveReport();

			DateChanged?.Invoke(e.Start);

			UpdateModeTitle();
		}

		void saveReport()
		{
			currentReport.Body = richTextBox1.Rtf;
			SaveNotation?.Invoke(currentReport);
			saved = true;
		}

		private void BtnStop_Click(object sender, EventArgs e)
		{
			richTextBox1.SelectionLength = 0;
			richTextBox1.SelectedText = $"<<< {DateTime.Now:dd-MM-yyyy HH:mm}";
			richTextBox1.Select();
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			saved = false;
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(!saved) saveReport();
		}

		private void btnTable_Click(object sender, EventArgs e)
		{
			try
			{
				richTextBox1.SelectionLength = 0;
				richTextBox1.SelectedRtf = InsertTableInRichTextBox(3, 3);
				richTextBox1.Select();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void UpdateModeTitle()
		{
			string lvl = _currentLevel == NotationLevel.Report ? "ОТЧЕТ" : "ЗАДАЧА";
			var title = $"{lvl} / {CurrentDate.ToString("dd.MM.yyyy")}";
			txtReportOrTask.Text = title;
		}

		private string InsertTableInRichTextBox(int countRows, int countColumns)
		{
			int columnWidth = 9000 / countColumns;

			StringBuilder sringTableRtf = new StringBuilder();
			StringBuilder tableRowRtf = new StringBuilder();

			sringTableRtf.Append(@"{\rtf1 ");

			for (int j = 0; j < countColumns; j++)
			{
				if (j == 0)
				{
					tableRowRtf.Append(@"\trowd\trgaph108\trleft-108");
				}
				if (j == countColumns - 1)
					tableRowRtf.Append(string.Format(@"\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs\cellx{0}\intbl \row", ((j + 1) * columnWidth).ToString()));
				else
					tableRowRtf.Append(string.Format(@"\clbrdrl\brdrw10\brdrs\clbrdrt\brdrw10\brdrs\clbrdrr\brdrw10\brdrs\clbrdrb\brdrw10\brdrs\cellx{0} ", ((j + 1) * columnWidth).ToString()));
			}

			for (int i = 0; i < countRows; i++)
			{
				sringTableRtf.AppendLine(tableRowRtf.ToString());
			}

			sringTableRtf.Append(@"\pard");
			sringTableRtf.Append(@"}");

			return sringTableRtf.ToString();
		}

		public void PutNotation(IDayNotation report)
		{
			currentReport = report;
			SetDayReport(currentReport);
			saved = true;
		}

		private void rbTask_CheckedChanged(object sender, EventArgs e)
		{
			if (!saved) saveReport();
			setNotationLevel(NotationLevel.Task);
			UpdateModeTitle();
		}

		private void rbReport_CheckedChanged(object sender, EventArgs e)
		{
			if (!saved) saveReport();
			setNotationLevel(NotationLevel.Report);
			UpdateModeTitle();
		}
	}
}
