using Costs.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costs.Forms
{
	/*
	 * Вот так по отдельности модели составных вьюшек.
	 * 
	 * Если несколько текстбоксов например... можно объединить интерфейсом
	 * 
	 */

	// Добавить средства для запоминания позиции дерева. В противном случае перезагрузка приводит к свертыванию всего дерева
	// Записать какие раскрытые и на какой ноде находилсь подсветка

	/// <summary>
	/// Обслуживание TreeView дерева директории категорий
	/// </summary>
	class DirectoriesTreeView
	{
		TreeView treeView;
		KbdHandler kbdHandler = new KbdHandler();

		List<int> expandedNodesID = new List<int>();
		TreeNode current = null;

		public event Action<Directory> CurrentDirectoryChanged;

		public event Action<Directory> DeleteDirectory;
		public event Action<Directory> CreateDirectory;
		public event Action<Directory> RenameDirectory;

		public DirectoriesTreeView(TreeView trView)
		{
			treeView = trView;
			kbdHandler.SetControl(treeView);
			setupKeys();
			wire();
		}

		void wire()
		{
			treeView.AfterSelect += TreeView_AfterSelect;
			treeView.AfterExpand += TreeView_AfterExpand;
			treeView.AfterCollapse += TreeView_AfterCollapse;
		}

		private void TreeView_AfterCollapse(object sender, TreeViewEventArgs e)
		{
			expandedNodesID.Remove(tag_dir(e.Node).ID);
		}

		private void TreeView_AfterExpand(object sender, TreeViewEventArgs e)
		{
			expandedNodesID.Add(tag_dir(e.Node).ID);
		}

		void unwire()
		{
			treeView.AfterSelect -= TreeView_AfterSelect;
		}

		private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			current = e.Node;
			CurrentDirectoryChanged?.Invoke(Current);
		}

		public void SetItems(List<Directory> listDir)
		{
			this.Fill(listDir);

			this.treeView.SelectedNode = treeView.Nodes[0];

			// Expanding marked nodes
			if (expandedNodesID.Count > 0)
			{
				treeView.AfterExpand -= TreeView_AfterExpand;
				treeView.AfterCollapse -= TreeView_AfterCollapse;

				foreach (var item in expandedNodesID)
				{
					TreeNode node = treeView.Nodes.Cast<TreeNode>().FirstOrDefault(x => tag_dir(x).ID == item);

					if (node != default(TreeNode))
						node.Expand();
				}

				treeView.AfterExpand += TreeView_AfterExpand;
				treeView.AfterCollapse += TreeView_AfterCollapse;
			}

			if (current != null)
			{
				TreeNode node1 = treeView.Nodes.Cast<TreeNode>().FirstOrDefault(x => tag_dir(x).ID == tag_dir(current).ID);
				if (node1 != default(TreeNode))
				{
					treeView.SelectedNode = node1;
				}
			}
		}

		private void setupKeys()
		{
			kbdHandler.AddKey(Keys.Delete, () => { DeleteDirectory?.Invoke(Current); });
			kbdHandler.AddKey(Keys.N, () => { CreateDirectory?.Invoke(Current); });
			kbdHandler.AddKey(Keys.R, () => { RenameDirectory?.Invoke(Current); });
		}

		/// <summary>
		/// Получает на вход список сущностей директорий и выстраивает в дерево в соответствии с ссылками.
		/// Отрисовывает древовидную структуру.
		/// Отслеживает и оповещает при изменении какой узел выбран
		/// </summary>
		/// <param name="treeView"></param>
		/// <param name="listDir"></param>
		void Fill(List<Directory> listDir)
		{
			treeView.Nodes.Clear();

			// Из коллекции Directory строим плоскую коллекцию TreeNode
			var nodes = listDir.Select((x) => {
				return new TreeNode
				{
					Text = x.Name,
					Tag = x
				};
			}).ToList();

			// Связывание коллекции TreeNode между собой в дерево
			// По обобщению. Это может быть вынесено в лямбду. Или паттерн фабричный метод.
			// Зацикливание было тупо в деффекте в файле бд. Некорректные ссылки директорий ХАХАХАХАХА
			foreach (var item in nodes)
			{
				// Ищем родителя текущего item
				var itemParent = nodes.FirstOrDefault(x => tag_dir(item).ParentID == tag_dir(x).ID);

				if (itemParent != null)
					itemParent.Nodes.Add(item);
			}

			// Коренные элементы, у которых ParentID указывает на 0. Именно их добавляем в контрол TreeView
			List<TreeNode> rootNodes = nodes.Where(x => tag_dir(x).ParentID == 0).ToList();

			treeView.Nodes.AddRange(rootNodes.ToArray());
		}

		public Directory Current { get { return tag_dir(treeView.SelectedNode); } }

		Directory tag_dir(TreeNode node)
		{
			return (Directory)node.Tag;
		}
	}
}
