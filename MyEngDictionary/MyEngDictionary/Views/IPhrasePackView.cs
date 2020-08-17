using DialCommuna.FormResult;
using MyEngDictionary.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEngDictionary.Views
{
	public interface IPhrasePackView
	{
		//void SetPhrases(IEnumerable<Phrase> phrases);
		void SetWordCount(int cnt);

		void SetPhrasePack(PhrasePack pack);

		event EventHandler ChangeCurrentPack;
		event EventHandler<CRUDRequest<Phrase>> PhraseCRUDRequset;
		event EventHandler<ViewResult> Closing;
	}
}
