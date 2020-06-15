using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costs.Forms.Main.InternalViews.DragDrops
{
	public class ProductTypePurchaseDragDrop<T>
		where T : class
	{
		ListView src;
		DataGridView desc;
		Action<T> dropProg;

		public ProductTypePurchaseDragDrop(ListView src, DataGridView desc, Action<T> drop_prog)
		{
			this.src = src;
			this.desc = desc;
			dropProg = drop_prog;

			this.src.ItemDrag += src_ItemDrag;
			this.desc.DragDrop += desc_DragDrop;
			this.desc.DragEnter += desc_DragEnter;
			this.desc.AllowDrop = true;
		}
		private void src_ItemDrag(object sender, ItemDragEventArgs e)
		{
			ListView lv = ((ListView)sender);
			var p = (e.Item as ListViewItem).Tag as T;
			if (p == null) return;
			lv.DoDragDrop(p, DragDropEffects.All);
		}
		private void desc_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(T)))
			{
				var item = (T)e.Data.GetData(typeof(T));

				dropProg(item);
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
