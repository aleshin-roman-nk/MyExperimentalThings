using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Costs.Views.Parts;
using Costs.Views.EventArgs;
using Costs.Entities;
using Costs.Forms.Common;

namespace Costs.Forms.UC
{
	public partial class DirectoriesUC : UserControl, IDirectoriesViewPart
	{
		DirectoriesTreeViewHandler directoriesTreeViewHandler;

		public DirectoriesUC()
		{
			InitializeComponent();

			treeView1.PathSeparator = " \\ ";

			directoriesTreeViewHandler = new DirectoriesTreeViewHandler(treeView1);

			directoriesTreeViewHandler.DragDrop.DirectoryDropped += (e) => DirectoryDroppedCmd?.Invoke(e);
			directoriesTreeViewHandler.DragDrop.PurchaseDropped += (e) => CommandPurchaseDropped?.Invoke(e);

			directoriesTreeViewHandler.DeleteDirectory += (e) => DeleteDirectoryCmd?.Invoke(e);
			directoriesTreeViewHandler.RenameDirectory += (e) => RenameDirectoryCmd?.Invoke(e);
			directoriesTreeViewHandler.CreateDirectory += (e) => CommandCreateDirectory?.Invoke(e);
			directoriesTreeViewHandler.CurrentDirectoryChanged += (e) => CurrentDirChanged?.Invoke(e);
		}

		public Directory Current => directoriesTreeViewHandler.Current;

		public event Action<DirectoryDroppedEventArg> DirectoryDroppedCmd;
		public event Action<PurchaseDroppedEventArg> CommandPurchaseDropped;
		public event Action<Directory> CommandCreateDirectory;
		public event Action<Directory> RenameDirectoryCmd;
		public event Action<Directory> DeleteDirectoryCmd;
		public event Action<Directory> CurrentDirChanged;

		public void SetDirectories(IEnumerable<Directory> dirList)
		{
			directoriesTreeViewHandler.SetItems(dirList);
		}

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			textBox1.Text = treeView1.SelectedNode.FullPath;
		}
	}
}
