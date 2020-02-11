using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PanelsManagmentExample.BL;

/*
 * От родителдьского класса не можем наследоваться в форме.
 * 
 * 
 * Думаю можно создать класс, который принимает композитом ссылку на форму.
 * 
 */

namespace PanelsManagmentExample.Panels
{
	public partial class MonthPanel : UserControl, IPanel
	{
		int currentId { get; set; } = -1;

		BindingSource bsMain;

		public MonthPanel()
		{
			InitializeComponent();
			bsMain = new BindingSource();
			bsMain.CurrentChanged += BsMain_CurrentChanged;
		}

		private void BsMain_CurrentChanged(object sender, EventArgs e)
		{
			if (bsMain.Current == null) return;
			var o = bsMain.Current as EntA;
			currentId = o.Id;
			Message?.Invoke($"Month panel current item: {o.Name}");
		}

		private IEnumerable<GridPanelColumn> GetColumns()
		{
			List<GridPanelColumn> c = new List<GridPanelColumn>();

			c.Add(new GridPanelColumn("Имя месяца", "Name", "col1", 300));

			return c;
		}

		public event Action<string> Message;
		public event Action<ReqData> Request;

		void IPanel.Activate(IGridPanel gridPanel)
		{
			//Message?.Invoke($"Month Panel activated");

			var dr = new ReqData { DataType = "months" };

			Request?.Invoke(dr);

			bsMain.DataSource = dr.Responce;

			gridPanel.SetBindingSource(bsMain);
			foreach (var item in GetColumns())
			{
				gridPanel.AddColumn(item);
			}

			//Message?.Invoke($"Month Panel {(bsMain.Current as EntA).Name} requires DATA");
		}

		void IPanel.Hide()
		{
			this.Visible = false;
		}

		void IPanel.Show()
		{
			this.Visible = true;
		}

		void IPanel.Lose()
		{
			currentId = -1;
			bsMain.DataSource = null;
			//Message?.Invoke($"Month Panel: lost");
		}

		void IPanel.Leave()
		{
			//Message?.Invoke($"Month Panel {(bsMain.Current as EntA).Name} has LEFT");
			//Message?.Invoke($"Month Panel: left");
		}
	}
}
