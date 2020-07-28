using MyEngDictionary.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEngDictionary.Views
{
	public interface IMainView
	{
		void SetPhrases(IEnumerable<Phrase> phrases);
		event EventHandler CreatePhrase;
		event EventHandler<Phrase> PhraseChanged;
	}
}
