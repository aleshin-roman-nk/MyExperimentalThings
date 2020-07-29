using MyEngDictionary.BL.Entities;
using System.Collections.Generic;

namespace MyEngDictionary.BL.Models
{
	public interface IPhrasesModel
	{
		IEnumerable<Phrase> GetPhrases();
	}
}