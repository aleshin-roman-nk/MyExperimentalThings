using PanelsManagmentExample.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanelsManagmentExample
{
	public interface IMainView
	{
		void SetText(string msg);
		event Action<string> Message;
		event Action<ReqData> Request;
		void Init();
	}
}
