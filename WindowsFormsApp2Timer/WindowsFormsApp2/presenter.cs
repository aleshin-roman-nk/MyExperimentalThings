using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
	public class presenter
	{
		IView _view;
		BL model = new BL();

		public presenter(IView v)
		{
			_view = v;
			_view.Tick += _view_Tick;
		}

		private void _view_Tick(decimal obj)
		{
			throw new NotImplementedException();
		}
	}
}
