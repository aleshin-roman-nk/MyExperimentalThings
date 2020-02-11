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
 * Конкретизация запроса либо здесь, тогда 
 * 
 * Класс-панель-модуль, подключается к каждой панели, принимает себе DataGrid. Панеди в конечном итоге работают с этой сеткой:
 *	создают профиль, отслеживают изменение позиции.
 *>>>>>>		А может сетку так же оформить в UserControl, и пусть все эти панели между собой взаимодейстут. По моему это более логично!!!
 *		А панель с сеткой пустит через интерфейс. Т.е. UserControl с сеткой реализует интерфейс, и этот интерфейс передаюм желающим панелям.
 *			Контроллер позиции.
 * 
 */

namespace PanelsManagmentExample.Panels
{
	public partial class YearPanel : UserControl, IPanel
	{
		BindingSource bsMain;
		int currentId { get; set; } = -1;

		public event Action<string> Message;
		public event Action<ReqData> Request;

		public YearPanel()
		{
			InitializeComponent();

			bsMain = new BindingSource();
			bsMain.CurrentItemChanged += BsMain_CurrentItemChanged;
		}

		private void BsMain_CurrentItemChanged(object sender, EventArgs e)
		{
			if (bsMain.Current == null) return;
			var o = bsMain.Current as EntA;
			currentId = o.Id;
			Message?.Invoke($"Year panel current item: {o.Name}");
		}

		void IPanel.Leave()
		{
			Message?.Invoke($"Year Panel {(bsMain.Current as EntA).Name} has LEFT");
		}

		void IPanel.Lose()
		{
			currentId = -1;
			bsMain.DataSource = null;
		}

		void IPanel.Activate(IGridPanel gridPanel)
		{
			foreach (var item in GetColumns())
			{
				gridPanel.AddColumn(item);
			}

			var dr = new ReqData { DataType = "years" };
			Request?.Invoke(dr);
			bsMain.DataSource = dr.Responce;
			gridPanel.SetBindingSource(bsMain);
		}

		void IPanel.Hide()
		{
			this.Visible = false;
		}

		void IPanel.Show()
		{
			this.Visible = true;
		}

		private IEnumerable<GridPanelColumn> GetColumns()
		{
			List<GridPanelColumn> c = new List<GridPanelColumn>();

			c.Add(new GridPanelColumn("Имя года", "Name", "col1", 300));

			return c;
		}
	}
}
