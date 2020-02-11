using PanelsManagmentExample.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanelsManagmentExample.Panels
{
	public interface IPanel
	{
		void Leave();
		void Lose();
		void Activate(IGridPanel gridPanel);
		void Hide();
		void Show();
		event Action<string> Message;
		event Action<ReqData> Request;
	}
}
