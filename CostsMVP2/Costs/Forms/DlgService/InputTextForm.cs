using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costs.Forms.DlgService
{
	public partial class InputTextForm : Form
	{
		public InputTextForm()
		{
			InitializeComponent();
		}

		public string InputedText { get => tbText.Text; }
	}
}
