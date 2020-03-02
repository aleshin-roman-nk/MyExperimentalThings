using DrRomic.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrRomic.UI
{
	public interface IPanel
	{
		object Leave();
		void Enter(object obj);
		void EnterBack();
		event Action<string> OnMessage;
		event Action<Requset> OnRequest;
		object CurrentObject { get; }
		IEnumerable<GridPanelColumn> Columns { get; }
		BindingSource BS { get; }
	}
}
