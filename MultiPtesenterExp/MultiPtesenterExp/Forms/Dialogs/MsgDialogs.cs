using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiPtesenterExp.Forms.Dialogs
{
	public static class MsgDialogs
	{
		public static void ShowMessage(string txt)
		{
			MessageBox.Show(txt);
		}
	}
}
