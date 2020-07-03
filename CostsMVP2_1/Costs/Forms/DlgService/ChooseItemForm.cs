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
	public partial class ChooseItemForm<T> : Form
		where T : class
	{
		BindingSource bs;

		public event Action<string> FilterTextChanged;

		public ChooseItemForm()
		{
			InitializeComponent();

			bs = new BindingSource();
		}

        public void SetList(IEnumerable<T> list, string displayMember)
        {
			bs.DataSource = list;

			listBoxItems.DataSource = bs;
			listBoxItems.DisplayMember = displayMember;

            bs.ResetBindings(false);
        }

        public T Current {
			get
			{
				return bs.Current as T;
			}
			set
			{
				bs.Position = (bs.IndexOf(value));
			}
		}

		private void txtQuickFilter_TextChanged(object sender, EventArgs e)
		{
			FilterTextChanged?.Invoke((sender as TextBox).Text);
		}
	}
}
