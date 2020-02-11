using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelsManagmentExample.Panels
{
	public interface IGridPanel
	{
		void SetBindingSource(BindingSource bs);
		void AddColumn(GridPanelColumn col);
		/// <summary>
		/// Clear both bindings and columns
		/// </summary>
		void Clear();
		IPanel AttachedPanel { get; set; }
		event Action Next;
		event Action Back;
	}
}
