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
		public event Action ReindexTasks;

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
			//richTextBox1.SelectionLength = 0;
			//richTextBox1.SelectedText = $">>> {DateTime.Now:dd-MM-yyyy HH:mm}";
			//richTextBox1.Select();

			string b = "";

			if (!string.IsNullOrEmpty(richTextBox1.Text))
			{
				b = richTextBox1.Text[richTextBox1.Text.Length - 1] == '\n' ? "\n" : "\n\n";
			}

			richTextBox1.SelectionStart = richTextBox1.Text.Length;
			richTextBox1.SelectionLength = 0;
			richTextBox1.SelectedText = $"{b}>>> {DateTime.Now:dd-MM-yyyy HH:mm}\n";
			richTextBox1.Select();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			saveReport();
		}

		private void btnBold_Click(object sender, EventArgs e)
		{
			//Font currentFont = richTextBox1.SelectionFont;

			//richTextBox1.SelectionFont = new Font(
			//		currentFont.FontFamily,
			//		currentFont.Size,
			//		/*FontStyle.Underline | */FontStyle.Bold);
		}

		private void btnUnbold_Click(object sender, EventArgs e)
		{
			//Font currentFont = richTextBox1.SelectionFont;

			//richTextBox1.SelectionFont = new Font(
			//		currentFont.FontFamily,
			//		currentFont.Size,
			//		FontStyle.Regular);

			
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

		private void BtnPrev_Click(object sender, EventArgs e)
		{
			//richTextBox1.SelectionLength = 0;
			//richTextBox1.SelectedText = $"<<< {DateTime.Now:dd-MM-yyyy HH:mm}";
			//richTextBox1.Select();

			if (richTextBox1.SelectionStart <= 3)
			{
				richTextBox1.Select();
				return;
			}

			int pos = richTextBox1.SelectionStart;

			if (pos > richTextBox1.SelectionStart - 3) pos -= 3;

			if (richTextBox1.Text.Substring(pos, 3).Equals(">>>")) pos--;

			while (!richTextBox1.Text.Substring(pos, 3).Equals(">>>"))
			{
				pos--;
			};

			//richTextBox1.Lines

			richTextBox1.SelectionStart = pos;
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

		private void btnNext_Click(object sender, EventArgs e)
		{
			//try
			//{
			//	richTextBox1.SelectionLength = 0;
			//	richTextBox1.SelectedRtf = InsertTableInRichTextBox(3, 3);
			//	richTextBox1.Select();
			//}
			//catch (Exception ex)
			//{
			//	MessageBox.Show(ex.Message);
			//}

			//ReindexTasks?.Invoke();

			//string b = richTextBox1.Text[richTextBox1.Text.Length - 1] == '\n' ? "\n" : "\n\n";

			//richTextBox1.SelectionStart = richTextBox1.Text.Length;
			//richTextBox1.SelectionLength = 0;
			//richTextBox1.SelectedText = $"{b}>!!!> {DateTime.Now:dd-MM-yyyy HH:mm}\n";
			//richTextBox1.Select();

			// 0 1 2 3 4 5 6 7 8 9 = 7
			if (richTextBox1.SelectionStart >= richTextBox1.TextLength - 3)
			{
				richTextBox1.Select();
				return;
			}

			int pos = richTextBox1.SelectionStart;

			if (richTextBox1.Text.Substring(pos, 3).Equals(">>>")) pos += 3;

			while (!richTextBox1.Text.Substring(pos, 3).Equals(">>>"))
			{
				pos++;
				if (pos > richTextBox1.TextLength - 4) break;
			};

			//richTextBox1.Lines

			richTextBox1.SelectionStart = pos;
			richTextBox1.Select();
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

		private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.Control && e.KeyCode == Keys.S)
			{
				if (!saved) saveReport();
			}
		}

		private void richTextBox1_SelectionChanged(object sender, EventArgs e)
		{
			label2.Text = $"{richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart) +1}";
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			string b = "";

			if (!string.IsNullOrEmpty(richTextBox1.Text))
			{
				b = richTextBox1.Text[richTextBox1.Text.Length - 1] == '\n' ? "\n" : "\n\n";
			}

			richTextBox1.SelectionStart = richTextBox1.Text.Length;
			richTextBox1.SelectionLength = 0;
			richTextBox1.SelectedText = $"{b}<<< {DateTime.Now:dd-MM-yyyy HH:mm}\n";
			richTextBox1.Select();
		}
	}
}
