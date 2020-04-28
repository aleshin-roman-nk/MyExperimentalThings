using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costs.Forms.Main
{
	public class KeyboardTreeDirectories// Сделать более удобный механизм привязки к клавишам
	{
		Dictionary<Keys, Action> keyMap;

		TreeView tree;

		public event Action<Directory> DeleteDirectory;
		public event Action<Directory> CreateDirectory;
		public event Action<Directory> RenameDirectory;

		public KeyboardTreeDirectories(TreeView tv)
		{
			tree = tv;
			keyMap = new Dictionary<Keys, Action>();
			setupKeys();
			wire();
		}

		void wire()
		{
			tree.KeyDown += Grid_KeyDown;
		}

		private void Grid_KeyDown(object sender, KeyEventArgs e)
		{
			if (keyMap.ContainsKey(e.KeyCode))
			{
				keyMap[e.KeyCode]();
				e.Handled = true;
			}
		}

		private void setupKeys()
		{
			keyMap[Keys.Delete] = () =>
			{
				DeleteDirectory?.Invoke(current);
			};

			keyMap[Keys.N] = () =>
			{
				CreateDirectory?.Invoke(current);
			};

			keyMap[Keys.R] = () =>
			{
				RenameDirectory?.Invoke(current);
			};
		}

		public Directory current { get { return tree.SelectedNode.Tag as Directory; } }
	}
}
