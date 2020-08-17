using MyEngDictionary.BL.Models;
using MyEngDictionary.Forms;
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

			PhrasePackForm f = new PhrasePackForm();
			//PhrasePacksForm f = new PhrasePacksForm();
			PhrasePackPresenter phrasePackPresenter = new PhrasePackPresenter(f);
			PhrasePackManagerPresenter phrasePackManagerPresenter = new PhrasePackManagerPresenter(new PhrasePackManagerForm());

			PresenterHub hub = new PresenterHub();

			hub.AddPresenter(phrasePackPresenter)
				.AddPresenter(phrasePackManagerPresenter);


			Application.Run(f);
		}
	}
}
