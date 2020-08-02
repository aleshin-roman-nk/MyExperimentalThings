using MyEngDictionary.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEngDictionary.BL.Models
{
	public class PhrasesModelMock : IPhrasesModel
	{
		List<Phrase> localPhrases;
		List<Group> localGroups;

		public PhrasesModelMock()
		{
			localPhrases = new List<Phrase>
			{
				new Phrase{Id = 1, Original = "make", Explanation = "делать", IsKnown = false, PhraseType = PhraseType.Word },
				new Phrase{Id = 2, Original = "collect", Explanation = "собирать", IsKnown = false, PhraseType = PhraseType.Word},
				new Phrase{Id = 3, Original = "kind of smthg", Explanation = "вид чего то", IsKnown = false, PhraseType = PhraseType.Idiom}
			};
		}

		public IEnumerable<Phrase> GetPhrases()
		{
			return localPhrases;
		}

		public void Save(Phrase p)
		{
			localPhrases.Add(p);
		}

		public Phrase Create(string text)
		{
			return new Phrase { Id = localPhrases.Count + 1, Original = text };
		}

		public int WordsCount
		{
			get
			{
				return localPhrases.Where(x => x.PhraseType == PhraseType.Word).ToList().Count;
			}
		}
	}
}