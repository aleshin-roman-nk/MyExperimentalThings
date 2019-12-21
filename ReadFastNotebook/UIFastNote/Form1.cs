using ReadFastNotebook.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIFastNote
{
	public interface IMainView
	{
		void SetNotes(IEnumerable<Note> notes);
	}
	public partial class Form1 : Form, IMainView
	{
		BindingSource bsMain = new BindingSource();

		public Form1()
		{
			InitializeComponent();
		}

		public void SetNotes(IEnumerable<Note> notes)
		{
			bsMain.DataSource = notes;
			lbNotes.DataSource = bsMain;
			lbNotes.DisplayMember = "DateStr";
			txtNoteText.DataBindings.Add("Text", bsMain, "Text");
			bsMain.ResetBindings(false);
		}
	}
}
