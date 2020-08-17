using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialCommuna.Dialogs
{
	public class UserAnswerYes
	{
		public static bool Show(string askMsg, string title)
		{
			return DialogResult.Yes ==
				MessageBox.Show(askMsg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		}
	}
}
