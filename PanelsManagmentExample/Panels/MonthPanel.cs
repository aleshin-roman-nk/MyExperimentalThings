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
	public partial class MonthPanel : UserControl, IPanel
	{
		public object CurrentObject => BS.Current;

		public IEnumerable<GridPanelColumn> Columns
		{
			get
			{
				List<GridPanelColumn> c = new List<GridPanelColumn>();

				c.Add(new GridPanelColumn("Имя месяца", "MName", "col1", 300));

				return c;
			}
		}

		public BindingSource BS { get; } = new BindingSource();
		public event Action<string> OnMessage;
		public event Action<Requset> OnRequest;

		public MonthPanel()
		{
			InitializeComponent();
			this.Visible = false;
		}

		void IPanel.Enter(object obj)
		{
			var dr = new Requset { Request = "months", Data = obj };

			OnRequest?.Invoke(dr);

			var y = obj as Year;

			txtYear.Text = y.Name;

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
			return null;
		}
	}
}
