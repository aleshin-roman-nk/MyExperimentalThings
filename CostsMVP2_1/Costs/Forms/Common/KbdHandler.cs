using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costs.Forms
{
	public class KbdHandler
	{
		Control control;
		Dictionary<Keys, Action> keyMap = new Dictionary<Keys, Action>();

		public void AddKey(Keys key, Action proc)
		{
			keyMap[key] = proc;
		}

		public void SetControl(Control c)
		{
			control = c;
			control.KeyDown += Control_KeyDown;
		}

		private void Control_KeyDown(object sender, KeyEventArgs e)
		{
			if (keyMap.ContainsKey(e.KeyCode))
			{
				keyMap[e.KeyCode]();
				e.Handled = true;
			}
		}
	}
}
