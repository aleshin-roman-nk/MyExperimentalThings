using DialCommuna.FormResult;
using DialCommuna.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialCommuna.Dialogs
{
	public class InputText
	{
		public static ViewResult<string> Show(string title, string init = null)
		{
			using (var d = new InputTextForm())
			{
				d.SetInitText(init, title);

				if (DialogResult.OK == d.ShowDialog())
				{
					return new ViewResult<string> { Answer = ViewAnswer.Ok, Data = d.InputedText };
				}

				return new ViewResult<string> { Answer = ViewAnswer.Cancel };
			}
		}
	}
}
