using MyBibleStudy.BL.DataSources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBibleStudy.BL
{
	public class WordsBankModel
	{
		public WordPack Load(string fname)
		{
			return WordsBankFile.Load(fname);
		}
		public void Save(WordPack wp)
		{
			WordsBankFile.Save(wp);
		}
		public void SaveAll(IEnumerable<WordPack> packs)
		{
			WordsBankFile.SaveAll(packs);
		}
		public IEnumerable<WordPack> GetWordPacks()
		{
			return WordsBankFile.GetWordPacks();
		}
		public bool IsPackExists(string wpname)
		{
			return WordsBankFile.IsPackNameExists(wpname);
		}
		public void DeletePack(WordPack pack)
		{
			WordsBankFile.DeletePack(pack);
		}
		public void DeleteWord(WordsBankItem word, WordPack pack)
		{
			pack.WordsBankItems.Remove(word);
		}
	}
}
