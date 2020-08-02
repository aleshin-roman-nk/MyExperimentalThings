using MyEngDictionary.BL.Models;
using MyEngDictionary.Presenters;
using MyEngDictionary.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEngDictionary
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Form1 f = new Form1();

			//MainPresenter p = new MainPresenter(f, new PhrasesModelMock());
			MainPresenter p = new MainPresenter(f, new PhrasesModel());

			Application.Run(f);
		}
	}
}
