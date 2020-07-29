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
		public IEnumerable<Phrase> GetPhrases()
		{
			return new List<Phrase>
			{
				new Phrase{Id = 1,
					TextEng = "make", TextRus = "делать", }
			}
		}
	}
}