using AllVerbs.BL;
using AllVerbs.Deb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllVerbs
{
	public partial class Form1 : Form, IMainView
	{
		public Form1()
		{
			InitializeComponent();

			dataGridView1.DataSource = rmWordBindingSource;
			rmWordBindingSource.CurrentItemChanged += RmWordBindingSource_CurrentItemChanged;
			
			new MainPresenter(this);
		}

		/*
		 * 0. Имеем текущее слово с отредактированным полем упражнения.
		 * 
		 * 1. Начало фильрации слов.
		 * 2. Загрузка слов по фильтру
		 * 3. Отправка слов в окно
		 * 4. Срабатывание CurrentItemChanged
		 * 4.1 Вызов сохранения слова (шаг 0)
		 * 
		 * 
		 * 
		 */


		// It is not proper way to save automatically because when the CurrentItemChanged is fired, the position
		//	is already on the next item.
		private void RmWordBindingSource_CurrentItemChanged(object sender, EventArgs e)
		{
			_checkForChangesAndSaveWord(_prevWord);

			_prevWord = _currentWord;

			richTextBoxExercises.Text = _currentWord.Exercises;

			_wordChanged = false;

			txtCurrWord.Text = _currentWord.V1;
		}

		public event Action<RmWord> SaveWord;
		public event Action<RmWord> DeleteWord;
		public event Action WordFilterChanged;
		public event Action UpdateView;

		RmWord _prevWord { get; set; }
		RmWord _currentWord { get { return rmWordBindingSource.Current as RmWord; } }
		bool __changed;
		bool _wordChanged
		{
			get
			{
				return __changed;
			}
			set
			{
				__changed = value;
				if (__changed)
				{
					btnSave.BackColor = Color.Red;
				}
				else
				{
					btnSave.BackColor = Color.Green;
				}
			}
		}

		public string WordFilterText { get => textBoxFilter.Text; }

		public void DisplayWords(IEnumerable<RmWord> words)
		{
			rmWordBindingSource.DataSource = words;

			_wordChanged = false;

			_prevWord = _currentWord;
		}

		public void ShowMsg(string msg)
		{
			MessageBox.Show(msg);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			_checkForChangesAndSaveWord(_currentWord);
		}

		void _checkForChangesAndSaveWord(RmWord word)
		{
			if (_wordChanged)
			{
				word.Exercises = richTextBoxExercises.Text;
				SaveWord?.Invoke(word);
				_wordChanged = false;
			}
		}

		private void btnAddVerb_Click(object sender, EventArgs e)
		{
			IEditWord f = new EditVerbForm();

			if(f.Go() == UserAnswer.Ok)
			{
				RmWord word = new RmWord
				{
					V1 = f.Present,
					V2 = f.Past,
					V3 = f.Perfect
				};

				SaveWord?.Invoke(word);
				UpdateView?.Invoke();
			}
		}

		private void btnDeleteVerb_Click(object sender, EventArgs e)
		{
			var q = MessageBox.Show($"Verb {_currentWord.V1} is going to be killed. Are you sure you want that?",
				"Asking for killing (((", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

			if(DialogResult.Yes == q)
			{
				// After we reload collection, (when change filter and deleted word) DataBinding does not have any item
				//	hence BindingSource.CurrentItemChanged does not fire.
				DeleteWord?.Invoke(_currentWord);
				UpdateView?.Invoke();
			}
		}

		private void textBoxFilter_TextChanged(object sender, EventArgs e)
		{
			_checkForChangesAndSaveWord(_currentWord);
			WordFilterChanged?.Invoke();
		}

		private void richTextBoxExercises_TextChanged(object sender, EventArgs e)
		{
			_wordChanged = true;
		}

		private void richTextBoxExercises_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.S && e.Control)
			{
				_checkForChangesAndSaveWord(_currentWord);
				e.Handled = true;
			}
		}

		private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				IEditWord f = new EditVerbForm();

				f.Present = _currentWord.V1;
				f.Past = _currentWord.V2;
				f.Perfect = _currentWord.V3;

				if (f.Go() == UserAnswer.Ok)
				{
					_currentWord.V1 = f.Present;
					_currentWord.V2 = f.Past;
					_currentWord.V3 = f.Perfect;

					SaveWord?.Invoke(_currentWord);
					UpdateView?.Invoke();
				}

				e.Handled = true;
			}
		}

		public void DisplayVerbAmount(int a)
		{
			txtVerbAmount.Text = $"Total verbs :{a}";
		}
	}
}
