using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrRomic.UI
{
	public partial class GridPanel : UserControl, IGridPanel
	{
		public GridPanel()
		{
			InitializeComponent();

			dgMain.AutoGenerateColumns = false;
		}

		public event Action Next;
		public event Action Back;

		private void addColumn(GridPanelColumn col)
		{
			DataGridViewTextBoxColumn c = new DataGridViewTextBoxColumn
			{
				DataPropertyName = col.EntityPropertyName,
				HeaderText = col.Header,
				Name = col.Name,
				ReadOnly = true,
				Width = col.Width
			};

			dgMain.Columns.Add(c);
		}
		private void setColumns(IEnumerable<GridPanelColumn> columns)
		{
			foreach (var item in columns)
				addColumn(item);
		}
		public void Clear()
		{
			dgMain.DataSource = null;
			dgMain.Columns.Clear();
		}
		private void dgMain_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				Next?.Invoke();
				e.Handled = true;
			}
			else if (e.KeyCode == Keys.Back)
			{
				Back?.Invoke();
				e.Handled = true;
			}
		}
		public void Attach(IPanel panel)
		{
			dgMain.DataSource = panel.BS;
			setColumns(panel.Columns);
		}
	}
}
