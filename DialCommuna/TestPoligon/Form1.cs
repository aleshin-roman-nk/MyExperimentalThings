using DialCommuna.FormResult;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPoligon
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var res = DialCommuna.Dialogs.InputText.
				Show("Тестирование", "введите новый текст");

			if (res.Answer == ViewAnswer.Ok)
				MessageBox.Show($"Вы ввели {res.Data}");
			else
				MessageBox.Show("Вы ничего не ввели :(");

		}
	}
}
