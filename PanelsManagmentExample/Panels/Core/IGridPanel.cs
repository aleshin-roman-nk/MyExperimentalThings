using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrRomic.UI
{
	public interface IGridPanel
	{
		//void SetBindingSource(BindingSource bs);
		//void SetColumns(IEnumerable<GridPanelColumn> columns);
		/// <summary>
		/// Clear both bindings and columns
		/// </summary>
		void Clear();
		void Attach(IPanel panel);
		event Action Next;
		event Action Back;
	}
}
