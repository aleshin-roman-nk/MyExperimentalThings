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
	public partial class Form1 : Form, IMainView
	{
		bool HasUnsaved = false;

		public Form1()
		{
			InitializeComponent();
		}

		public event EventHandler CreatePhrase;
		public event EventHandler<Phrase> PhraseChanged;

		private Phrase CurrentPhrase => listPhrases.SelectedItems[0].Tag as Phrase;

		public void SetPhrases(IEnumerable<Phrase> phrases)
		{
			listPhrases.Clear();
			HasUnsaved = false;

			foreach (var item in phrases)
			{
				var o = listPhrases.Items.Add(item.Original);
				o.Tag = item;
			}

			if (listPhrases.Items.Count == 0) return;

			listPhrases.Items[0].Selected = true;
			listPhrases.Items[0].Focused = true;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			CurrentPhrase.Explanation = txtExplanation.Text;

			PhraseChanged?.Invoke(null, CurrentPhrase);
		}

		private void listPhrases_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listPhrases.SelectedItems.Count == 0) return;
			var i = listPhrases.SelectedItems[0].Tag as Phrase;

			txtExplanation.Text = i.Explanation;
			txtCurrPhrase.Text = i.Original;
			txtExercises.Text = i.Exercises;
			if (i.PhraseType == PhraseType.Idiom)
				rbIdiom.Checked = true;
			else rbWord.Checked = true;
		}

		private void accept_phrase(Phrase p)
		{
			p.Explanation = txtExplanation.Text;
			p.Exercises = txtExercises.Text;
			p.PhraseType = rbWord.Checked ? PhraseType.Word : PhraseType.Idiom;
		}

		private void listPhrases_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			if (!e.IsSelected)
			{
				var i = e.Item.Tag as Phrase;
				accept_phrase(i);
				PhraseChanged?.Invoke(null, i);
			}
		}

		public void SetWordCount(int cnt)
		{
			txtWordCount.Text = cnt.ToString();
		}

		private void btnAddPhrase_Click(object sender, EventArgs e)
		{
			CreatePhrase?.Invoke(null, EventArgs.Empty);
		}

		private void txtExplanation_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
