using MyBibleStudy.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBibleStudy.Forms.RepetitionForm
{
	// This is for observing if a WordPack object is changed.
	public class DataSavedInfo
	{
		Dictionary<string, int> dataSavedInfo;

		public DataSavedInfo()
		{
			dataSavedInfo = new Dictionary<string, int>();
		}

		//public void Reset()
		//{
		//	dataSavedInfo.Clear();
		//}
		public IEnumerable<WordPack> GetChangedPacks(IEnumerable<WordPack> packs)
		{
			List<WordPack> res = new List<WordPack>();

			var names = dataSavedInfo.Where(x => x.Value > 0).Select(x => x.Key);

			foreach (var item in names)
			{
				var i = packs.FirstOrDefault(x => x.Name.Equals(item));
				if (i != null) res.Add(i);
			}

			return res;
		}
		public void AddChangeCount(WordPack pack)
		{
			if (!dataSavedInfo.ContainsKey(pack.Name))
			{
				MyDialogs.ShowMessage($"Пакет {pack.Name} не зарегистрирован");
				return;
			}

			dataSavedInfo[pack.Name]++;
		}
		public void Register(IEnumerable<WordPack> packs)
		{
			dataSavedInfo.Clear();
			foreach (var pack in packs)
				dataSavedInfo[pack.Name] = 0;
		}

		public override string ToString()
		{
			StringBuilder str = new StringBuilder();

			foreach (var item in dataSavedInfo)
			{
				str.Append($"{item.Key} :{item.Value} ;");
			}

			return str.ToString();
		}
	}
}
