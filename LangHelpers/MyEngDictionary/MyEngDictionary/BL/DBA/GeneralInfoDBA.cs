using MyEngDictionary.BL.AppDb;
using MyEngDictionary.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEngDictionary.BL.DBA
{
	class GeneralInfoDBA
	{
		public static int GetPhraseCount()
		{
			using (AppData db = new AppData())
			{
				return db.Phrases.Where(x => x.PhraseType == PhraseType.Word).Count();
			}
		}
	}
}
