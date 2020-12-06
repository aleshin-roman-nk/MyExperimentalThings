using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskBank
{
	public class MainPresenter
	{
		IMainView _mainView;
		public MainPresenter(IMainView mv)
		{
			_mainView = mv;
		}
	}
}
