using DialCommuna.FormResult;
using MyEngDictionary.BL.Entities;
using MyEngDictionary.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEngDictionary
{
	public partial class PhrasePackForm : Form, IPhrasePackView
	{
		bool HasUnsaved = false;

		public PhrasePackForm()
		{
			InitializeComponent();

			_set_view_mode(_view_mode.view);
			_set_saved();
		}

		public event EventHandler ChangeCurrentPack;
		public event EventHandler<CRUDRequest<Phrase>> PhraseCRUDRequset;
		public event EventHandler<ViewResult> Closing;

		private void _set_unsaved()
		{
			HasUnsaved = true;
			btnSave.Enabled = true;
		}

		private void _set_saved()
		{
			HasUnsaved = false;
			btnSave.Enabled = false;
		}

		private Phrase CurrentPhrase { get; set; }
		private int current_id { get; set; }

		private enum _view_mode { view, edit }

		private void _set_view_mode(_view_mode mode)
		{
			if(mode == _view_mode.view)
			{
				btnStartEdit.Enabled = true;
				btnCancel.Enabled = false;
				txtExplanation.ReadOnly = true;
				txtExercises.ReadOnly = true;
				rbIdiom.Enabled = false;
				rbWord.Enabled = false;
				checkIknowIt.Enabled = false;
				listPhrases.Enabled = true;
				txtPhrase.ReadOnly = true;

				listPhrases.Select();
			}
			else if(mode == _view_mode.edit)
			{
				btnStartEdit.Enabled = false;
				btnCancel.Enabled = true;
				txtExplanation.ReadOnly = false;
				txtExercises.ReadOnly = false;
				rbIdiom.Enabled = true;
				rbWord.Enabled = true;
				checkIknowIt.Enabled = true;
				listPhrases.Enabled = false;
				txtPhrase.ReadOnly = false;
			}
		}

		//public void SetPhrases(IEnumerable<Phrase> phrases)
		//{
		//	listPhrases.Clear();
		//	HasUnsaved = false;

		//	foreach (var item in phrases)
		//	{
		//		var o = listPhrases.Items.Add(item.TextEng);
		//		o.Tag = item;
		//	}

		//	set_focus_on_phrase(current_id);
		//}

		private void put_phrase(Phrase p)
		{
			txtExplanation.Text = p.Explanation;
			txtCurrPhrase.Text = p.TextEng;
			txtExercises.Text = p.Exercises;
			txtPhrase.Text = p.TextEng;
			if (p.PhraseType == PhraseType.Idiom)
				rbIdiom.Checked = true;
			else rbWord.Checked = true;
			checkIknowIt.Checked = p.IsKnown;
		}

		private void set_focus_on_phrase(int id)
		{
			if (listPhrases.Items.Count == 0) return;

			var i = listPhrases.Items.Cast<ListViewItem>().FirstOrDefault(x => (x.Tag as Phrase).Id == id);

			if(i != null)
			{
				i.Selected = true;
				i.Focused = true;
			}
			else
			{
				listPhrases.Items[0].Selected = true;
				listPhrases.Items[0].Focused = true;
			}
		}

		private void listPhrases_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listPhrases.SelectedItems.Count == 0) return;
			var i = listPhrases.SelectedItems[0].Tag as Phrase;

			current_id = i.Id;
			CurrentPhrase = i;

			put_phrase(i);

			_set_saved();
		}

		private void accept_phrase(Phrase p)
		{
			p.Explanation = txtExplanation.Text;
			p.Exercises = txtExercises.Text;
			p.PhraseType = rbWord.Checked ? PhraseType.Word : PhraseType.Idiom;
			p.IsKnown = checkIknowIt.Checked;
			p.TextEng = txtPhrase.Text;
		}

		public void SetWordCount(int cnt)
		{
			txtTotalWordCount.Text = cnt.ToString();
		}

		private void btnAddPhrase_Click(object sender, EventArgs e)
		{
			PhraseCRUDRequset?.Invoke(null, new CRUDRequest<Phrase> { CRUDCode = CRUDType.Create});
		}

		private void txtExplanation_TextChanged(object sender, EventArgs e)
		{
			_set_unsaved();
		}

		private void txtExercises_TextChanged(object sender, EventArgs e)
		{
			_set_unsaved();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			accept_phrase(CurrentPhrase);

			PhraseCRUDRequset?.Invoke(null, new CRUDRequest<Phrase> { CRUDCode = CRUDType.Update, Data = CurrentPhrase });

			_set_view_mode(_view_mode.view);
			_set_saved();
		}

		private void btnStartEdit_Click(object sender, EventArgs e)
		{
			_set_view_mode(_view_mode.edit);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			put_phrase(CurrentPhrase);

			_set_view_mode(_view_mode.view);
			_set_saved();
		}

		private void txtPhrasePackName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ChangeCurrentPack?.Invoke(null, EventArgs.Empty);
		}

		private void listPhrases_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Delete)
			{
				PhraseCRUDRequset?.Invoke(null, new CRUDRequest<Phrase> { CRUDCode = CRUDType.Delete, Data = CurrentPhrase});

				e.Handled = true;
			}
		}

		private void txtPhrase_TextChanged(object sender, EventArgs e)
		{
			_set_unsaved();
		}

		private void rbWord_CheckedChanged(object sender, EventArgs e)
		{
			_set_unsaved();
		}

		private void rbIdiom_CheckedChanged(object sender, EventArgs e)
		{
			_set_unsaved();
		}

		private void checkIknowIt_CheckedChanged(object sender, EventArgs e)
		{
			_set_unsaved();
		}

		/*
		 * Спрашиваем разрешения у модели (презентера), можно ли нам закрыться
		 */
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!HasUnsaved) { e.Cancel = false; return; }

			ViewResult res = new ViewResult { Answer = ViewAnswer.Cancel};
			Closing?.Invoke(null, res);
			
			e.Cancel = res.Answer == ViewAnswer.Cancel;
		}

		public void SetPhrasePack(PhrasePack pack)
		{
			txtPhrasePackName.Text = pack.Name;

			listPhrases.Clear();
			HasUnsaved = false;

			foreach (var item in pack.Phrases.OrderBy(x=>x.TextEng))
			{
				var o = listPhrases.Items.Add(item.TextEng);
				o.Tag = item;
			}

			set_focus_on_phrase(current_id);
		}
	}
}
