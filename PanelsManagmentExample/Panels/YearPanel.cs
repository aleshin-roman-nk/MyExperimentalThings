using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrRomic.BL;

namespace DrRomic.UI
{
	public partial class YearPanel : UserControl, IPanel
	{
		public object CurrentObject => BS.Current;

		public IEnumerable<GridPanelColumn> Columns
		{
			get
			{
				List<GridPanelColumn> c = new List<GridPanelColumn>();

				c.Add(new GridPanelColumn("Имя года", "Name", "col1", 300));

				return c;
			}
		}
		public BindingSource BS { get; } = new BindingSource();

		public event Action<string> OnMessage;
		public event Action<Requset> OnRequest;

		public YearPanel()
		{
			InitializeComponent();
			this.Visible = false;
		}
		void IPanel.Enter(object obj)
		{
			var dr = new Requset { Request = "years", Data = obj };
			OnRequest?.Invoke(dr);

			BS.DataSource = dr.Responce;

			this.Visible = true;
		}
		public void EnterBack()
		{
			this.Visible = true;
		}

		object IPanel.Leave()
		{
			this.Visible = false;
			return CurrentObject;
		}

		private void btnAddYear_Click(object sender, EventArgs e)
		{
			var dr = new Requset { Request = "add_year" };
			OnRequest?.Invoke(dr);

			BS.DataSource = dr.Responce;
			BS.ResetBindings(false);
		}
	}
}
