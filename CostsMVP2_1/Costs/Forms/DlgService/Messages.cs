using Costs.Forms.DlgService;
using System.Windows.Forms;

namespace Costs.DlgService
{
	public static class Messages
	{
		public static void ShowError( string msg, string title )
		{
			MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public static bool UserAnsweredYes( string askMsg, string title )
		{
			return DialogResult.Yes ==
				MessageBox.Show( askMsg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question );
		}

		public static string InputText(string init_text, string title = null)
		{
			string result = string.Empty;

			using (InputTextForm form = new InputTextForm())
			{
				form.SetInitText(init_text, title);

				if (form.ShowDialog() == DialogResult.OK)
					result = form.InputedText;
			}

			return result;
		}
	}
}
