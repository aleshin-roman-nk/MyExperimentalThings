using ReadFastNotebook.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIFastNote
{
	public class Presenter
	{
		IMainView view;

		public Presenter(IMainView v)
		{
			view = v;

			var items = ShowNootes.GetNotes(@"..\..\..\DataFiles\notes.text", @"..\..\..\DataFiles\notes.index");

			view.SetNotes(items);
		}
	}
}
