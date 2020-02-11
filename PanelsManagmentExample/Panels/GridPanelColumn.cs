using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanelsManagmentExample.Panels
{
	public class GridPanelColumn
	{
		public string Header { get; set; }
		public string EntityPropertyName { get; set; }
		public string Name { get; set; }
		public int Width { get; set; }

		public GridPanelColumn(string header, string entityPropertyName, string name, int width)
		{
			Header = header;
			EntityPropertyName = entityPropertyName;
			Name = name;
			Width = width;
		}
	}
}
