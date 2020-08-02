using MyEngDictionary.BL.Entities;
using System.Collections.Generic;

namespace MyEngDictionary.BL.Models
{
	public interface IPhrasesModel
	{
		IEnumerable<Phrase> GetPhrases();
		int WordsCount { get; }
		void Save(Phrase p);
		Phrase Create(string text);
	}
}