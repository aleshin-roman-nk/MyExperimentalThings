using DrRomic.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrRomic
{
	public interface IMainView
	{
		void SetText(string msg);
		event Action<string> OnMessage;
		event Action<Requset> OnRequest;
		void Init();
	}
}
