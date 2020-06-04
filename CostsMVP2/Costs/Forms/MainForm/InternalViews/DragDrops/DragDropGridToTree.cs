using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costs.Forms.Main.InternalViews.DragDrops
{
	/*
	 * СЕРЬЕЗНЫЙ НЕДОСТАТОК РАБОТЫ АЛГОРИТМА:
	 * 
	 * 1. Добавить окно подтверждения переноса
	 * 2. Проводить проверку возможности перемещения директории.
	 *		Не допускать ситуации, если директория переносится в саму себя
	 * 
	 * А Так как мне нужно двигаться дальше, приступать к освоению ASP и другие более серьъезные вещи,
	 *		Перетаскивание пока отложить. А перемещения сделать через диалоговые окна
	 * 
	 * 
	 */

	public class DragDropGridToTree
	{
		DataGridView dataGridView;
		TreeView treeView;

		public event Action<Purchase, Directory> MovePurchase;
		public event Action<Directory, Directory> MoveDirectory;

		public DragDropGridToTree(DataGridView grid, TreeView tree)
		{
			dataGridView = grid;
			treeView = tree;
			wire();
		}

		void wire()
		{
			dataGridView.MouseMove += dataGridView_MouseMove;
			treeView.DragDrop +=  treeView_DragDrop;
			treeView.DragOver +=  treeView_DragOver;
			treeView.DragEnter += treeView_DragEnter;
			treeView.MouseMove += treeView_MouseMove;
		}

		#region Source handlers
		private void dataGridView_MouseMove(object sender, MouseEventArgs e)
		{
			// Из за этого алгоритма возникла путанница. Так как я начинал тащить из другого контрола, проходя над этим, автоматически запускается драг здесь
			if (e.Button == MouseButtons.Left)
			{
				var row = getRowAtPoint(dataGridView, new Point(e.X, e.Y));
				if (row != null)
					dataGridView.DoDragDrop(row.DataBoundItem, DragDropEffects.Move);
			}
		}

		private DataGridViewRow getRowAtPoint(DataGridView grid, Point point)
		{
			var o = dataGridView.HitTest(point.X, point.Y);

			if (o.RowIndex >= 0)
				return grid.Rows[o.RowIndex];
			else
				return null;
		}

		private void treeView_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				var node = getTreeNodeAtPoint(treeView, new Point(e.X, e.Y));

				if (node != null)
				{
					treeView.DoDragDrop(node.Tag, DragDropEffects.Move);
				}
			}
		}

		private TreeNode getTreeNodeAtPoint( TreeView treeView, Point point )
		{
			TreeNode node = treeView.GetNodeAt(point.X, point.Y);

			return node;
		}
		#endregion

		#region Destination

		private void treeView_DragDrop(object sender, DragEventArgs e)
		{
			// 1. Получаем бросаемый объект
			TreeView tv = sender as TreeView;
			Point pt = tv.PointToClient(new Point(e.X, e.Y));
			TreeNode toNode = tv.GetNodeAt(pt);
			if (toNode == null) return;

			Directory toDir = toNode.Tag as Directory;

			// 2. Проверяем соответствие типа
			if (e.Data.GetData(typeof(Purchase)) is Purchase o)
			{
				MovePurchase(o, toDir);
				//customizeTreeViewNode(toNode, CustomizeTreeViewMode.Default);
			}
			else if(e.Data.GetData(typeof(Directory)) is Directory dir)
			{
				if (dir.ID != toDir.ID)
				MoveDirectory(dir, toDir);
			}

			customizeTreeViewNode(toNode, CustomizeTreeViewMode.Default);
		}

		TreeNode lastNode = null;
		private void treeView_DragOver(object sender, DragEventArgs e)
		{
			if (!(
				e.Data.GetDataPresent(typeof(Directory)) ||
				e.Data.GetDataPresent(typeof(Purchase))
				)) return;

			Point p = treeView.PointToClient(new Point(e.X, e.Y));
			TreeNode currentNode = treeView.GetNodeAt(p.X, p.Y);

			if (currentNode == null)
			{
				if (lastNode != null) customizeTreeViewNode(lastNode, CustomizeTreeViewMode.Default);
				lastNode = null;
				return;
			}

			customizeTreeViewNode(currentNode, CustomizeTreeViewMode.Selected);

			if (lastNode != null && lastNode != currentNode)
			{
				customizeTreeViewNode(lastNode, CustomizeTreeViewMode.Default);
			}

			lastNode = currentNode;
		}

		private enum CustomizeTreeViewMode { Default, Selected };

		private void customizeTreeViewNode(TreeNode node, CustomizeTreeViewMode mode)
		{
			switch (mode)
			{
				case CustomizeTreeViewMode.Default:
						node.BackColor = Color.White;
						node.ForeColor = Color.Black;
					break;
				case CustomizeTreeViewMode.Selected:
						node.BackColor = Color.FromArgb(0x1b, 0xa2, 0xac);
						node.ForeColor = Color.WhiteSmoke;
					break;
				default:
					break;
			}
		}

		private void treeView_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(Directory)) || e.Data.GetDataPresent(typeof(Purchase)))
			{
				e.Effect = DragDropEffects.Move;
			}
		}
		#endregion
	}
}
