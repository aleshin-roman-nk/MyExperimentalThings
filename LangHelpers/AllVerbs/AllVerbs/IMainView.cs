using AllVerbs.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllVerbs
{
	public interface IMainView
	{
		void DisplayWords(IEnumerable<RmWord> words);
		void DisplayVerbAmount(int a);
		void ShowMsg(string msg);
		event Action<RmWord> SaveWord;
		event Action<RmWord> DeleteWord;
		event Action WordFilterChanged;
		event Action UpdateView;// In other cases it may be good to use action code, what part of display we are updating.
		string WordFilterText { get; }
	}
}
