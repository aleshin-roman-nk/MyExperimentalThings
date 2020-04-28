using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragDropMechanism
{
	public class MoveFromTo<T>
		where T: class
	{
		ListView lvSource;
		ListView lvDesc;
		Action<T> moveProg;

		public MoveFromTo(ListView src, ListView desc, Action<T> move_prog)
		{
			lvSource = src;
			lvDesc = desc;
			moveProg = move_prog;

			lvSource.ItemDrag += lvSource_ItemDrag;
			lvDesc.DragDrop += lvDesc_DragDrop;
			lvDesc.DragEnter += lvDesc_DragEnter;
		}
		private void lvSource_ItemDrag(object sender, ItemDragEventArgs e)
		{
			ListView lv = ((ListView)sender);
			var p = (e.Item as ListViewItem).Tag as T;
			if (p == null) return;
			lv.DoDragDrop(p, DragDropEffects.All);
		}
		private void lvDesc_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(T)))
			{
				var item = (T)e.Data.GetData(typeof(T));

				moveProg(item);
			}
		}
		private void lvDesc_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(T)))
			{
				e.Effect = DragDropEffects.All;
			}
		}
	}
}
