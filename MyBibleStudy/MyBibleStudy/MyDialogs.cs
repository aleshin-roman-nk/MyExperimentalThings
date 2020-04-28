using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBibleStudy
{
	public static class MyDialogs
	{
		public static bool UserAnswerYes(string msg)
		{
			return MessageBox.Show(msg, "Q", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
		}
		public static void ShowMessage(string msg)
		{
			MessageBox.Show(msg);
		}
	}
}
