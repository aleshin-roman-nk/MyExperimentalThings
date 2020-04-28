using MyBibleStudy.BL;
using MyBibleStudy.Forms.RepetitionForm;
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
 * >>>
 * 29-03-2020 2-35
 * возможно так же нужно привязаться к неделе.
 * 
 * 
 * 
 */

namespace MyBibleStudy
{
	public interface IRepetitionView
	{
		void SetPacks(IEnumerable<WordPack> packs);
		event Action<string, WordPack> BtnCreateWord;
		//event Action<WordPack> BtnSave;
		event Action<IEnumerable<WordPack>> BtnSaveAll;
		event Action<string> BtnCreatePack;
		event Action<string> CurrentPackChanged;
		event Action<WordPack> BtnDeletePack;
		event Action<WordsBankItem, WordPack> BtnDeleteWord;
		event Action<IEnumerable<WordPack>> BtnClosing;
		void ShowForm();
	}
	public partial class RepetitionForm : Form, IRepetitionView
	{
		DataSavedInfo dataSavedInfo = null;
		BindingSource bsPacks;
		BindingSource bsWords;
		IEnumerable<WordPack> wordPacks = null;
	
		public RepetitionForm()
		{
			InitializeComponent();

			bsPacks = new BindingSource();
			bsWords = new BindingSource();

			bsPacks.CurrentItemChanged += BsPacks_CurrentItemChanged;
			dataSavedInfo = new DataSavedInfo();
		}

		private void BsPacks_CurrentItemChanged(object sender, EventArgs e)
		{
			//if (bsPacks.Current == null) return;
			//var i = bsPacks.Current as WordPack;
			//if (i == null) return;

			//Text = i.Name;
		}

		public event Action<string, WordPack> BtnCreateWord;
		//public event Action<WordPack> BtnSave;
		public event Action<string> BtnCreatePack;
		public event Action<string> CurrentPackChanged;
		public event Action<WordPack> BtnDeletePack;
		public event Action<IEnumerable<WordPack>> BtnSaveAll;
		public event Action<WordsBankItem, WordPack> BtnDeleteWord;
		public event Action<IEnumerable<WordPack>> BtnClosing;

		WordPack CurrentPack 
		{
			get
			{
				if (bsPacks.DataSource == null) return null;
				return bsPacks.Current as WordPack;
			}
		} 
		WordsBankItem CurrentWord
		{
			get
			{
				if (bsWords.DataSource == null) return null;
				return bsWords.Current as WordsBankItem;
			}
		}
		public void SetPacks(IEnumerable<WordPack> packs)
		{
			wordPacks = packs;

			bsPacks.DataSource = wordPacks;
			lbWordsPack.DataSource = null;
			lbWordsPack.DataSource = bsPacks;
			lbWordsPack.DisplayMember = "Name";

			txtBody.DataBindings.Clear();
			txtTitle.DataBindings.Clear();
			txtCurrentWord.DataBindings.Clear();

			bsWords.DataSource = bsPacks;
			bsWords.DataMember = "WordsBankItems";
			lbItems.DataSource = bsWords;
			lbItems.DisplayMember = "Name";
			bsWords.ResetBindings(false);

			txtBody.DataBindings.Add("Text", bsWords, "Body");
			txtTitle.DataBindings.Add("Text", bsWords, "Title");
			txtCurrentWord.DataBindings.Add("Text", bsWords, "Name");

			dataSavedInfo.Register(wordPacks);
			Text = dataSavedInfo.ToString();
		}

		public void ShowForm()
		{
			this.ShowDialog();
		}

		private void btnCreatePack_Click(object sender, EventArgs e)
		{
			string name = DrRomic.Dialogs.InputBox.GetText("Имя пака слов");
			if (name == null) return;

			BtnCreatePack?.Invoke(name);
		}

		private void lbWordsPack_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Delete)
			{
				var wpname = bsPacks.Current as WordPack;
				if (wpname == null) return;

				if(!MyDialogs.UserAnswerYes($"Подтвердите удаление пака {wpname.Name}")) return;

				BtnDeletePack?.Invoke(wpname);
				e.Handled = true;
				return;
			}
		}

		private void btnCreateWord_Click(object sender, EventArgs e)
		{
			string name = DrRomic.Dialogs.InputBox.GetText("Новое слово");
			if (name == null) return;
			var curr_pack = bsPacks.Current as WordPack;
			if (curr_pack == null) return;

			BtnCreateWord?.Invoke(name, curr_pack);
		}

		private void lbItems_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Delete)
			{
				if (CurrentPack == null) return;
				if (CurrentWord == null) return;
				if (!MyDialogs.UserAnswerYes($"Подтвердите удаление слова {CurrentWord.Name}")) return;

				BtnDeleteWord?.Invoke(CurrentWord, CurrentPack);
			}
		}

		private void txtBody_TextChanged(object sender, EventArgs e)
		{
			if (!txtBody.Focused) return;
			if (CurrentPack == null) return;
			dataSavedInfo.AddChangeCount(CurrentPack);
			Text = dataSavedInfo.ToString();
		}

		private void txtTitle_TextChanged(object sender, EventArgs e)
		{
			if (!txtTitle.Focused) return;
			if (CurrentPack == null) return;
			dataSavedInfo.AddChangeCount(CurrentPack);
			Text = dataSavedInfo.ToString();
		}

		private void RepetitionForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.ValidateChildren();// Без этого при закрытии формы не происходит автоматического сохранения в поле Body
			BtnClosing?.Invoke(dataSavedInfo.GetChangedPacks(wordPacks));
		}

		private void btnSaveAll_Click(object sender, EventArgs e)
		{
			BtnSaveAll?.Invoke(dataSavedInfo.GetChangedPacks(wordPacks));
		}
	}
}
