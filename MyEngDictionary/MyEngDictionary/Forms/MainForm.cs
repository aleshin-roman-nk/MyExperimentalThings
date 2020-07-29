﻿using DialCommuna.FormResult;
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
		public Form1()
		{
			InitializeComponent();
		}

		public event EventHandler CreatePhrase;
		public event EventHandler<Phrase> PhraseChanged;

		public void SetPhrases(IEnumerable<Phrase> phrases)
		{
			throw new NotImplementedException();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			var res = DialCommuna.Dialogs.InputText.
				Show(null, "Введите новое слово", null);

			if (res.Answer == ViewAnswer.Ok)
				MessageBox.Show($"Вы ввели {res.Data}");
			else
				MessageBox.Show("Вы ничего не ввели :(");
		}
	}
}
