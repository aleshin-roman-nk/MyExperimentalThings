using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costs.Forms.Common
{
	public class DataGridViewDrop<T>
		where T : class
	{
		DataGridView desc;

		public event Action<T> ItemDrop;

		public DataGridViewDrop(DataGridView desc)
		{
			this.desc = desc;

			this.desc.DragDrop += desc_DragDrop;
			this.desc.DragEnter += desc_DragEnter;
			this.desc.AllowDrop = true;
		}

		private void desc_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(T)))
			{
				var item = (T)e.Data.GetData(typeof(T));

				ItemDrop?.Invoke(item);
			}
		}
		private void desc_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(T)))
			{
				e.Effect = DragDropEffects.All;
			}
		}
	}
}
