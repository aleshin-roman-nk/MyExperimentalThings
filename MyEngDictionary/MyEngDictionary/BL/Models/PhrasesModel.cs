using MyEngDictionary.BL.DBA;
using MyEngDictionary.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEngDictionary.BL.Models
{
	public class PhrasesModel : IPhrasesModel
	{
		//List<Phrase> local;

		public int WordsCount => PhrasesDBA.WordCount;

		public Phrase Create(string text)
		{
			return new Phrase { Original = text, PhraseType = PhraseType.Word };
		}

		public IEnumerable<Phrase> GetPhrases()
		{
			return PhrasesDBA.GetAll();
		}

		public void Save(Phrase p)
		{
			//if (p.Id == 0) local.Add(p);
			PhrasesDBA.Save(p);
		}
	}
}
