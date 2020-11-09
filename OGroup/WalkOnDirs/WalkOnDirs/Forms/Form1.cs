using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalkOnDirs.BL;

namespace WalkOnDirs
{
	public partial class Form1 : Form
	{
		BindingSource bs;
		DirectoryCollection directoryCollection;
		Directory currentDir;

		public Form1()
		{
			InitializeComponent();

			directoryCollection = new DirectoryCollection();
			bs = new BindingSource();
			currentDir = directoryCollection.GetRoot();// root
			_enterDir(currentDir);
			listBox1.DataSource = bs;
			listBox1.DisplayMember = "Name";
		}

		Directory _currentDirInUI => bs.Current as Directory;

		private void _enterDir(Directory dir)
		{
			var dirs = directoryCollection.GetChildrenOf(dir);

			if (dirs.Count() == 0) return;

			currentDir = dir;
			bs.DataSource = dirs;
			bs.ResetBindings(false);

			label1.Text = directoryCollection.GetFullPathOf(currentDir);
		}

		private void _exitDir()
		{
			currentDir = directoryCollection.GetParentOf(currentDir);
			bs.DataSource = directoryCollection.GetChildrenOf(currentDir);
			bs.ResetBindings(false);

			label1.Text = directoryCollection.GetFullPathOf(currentDir);
		}

		private void listBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				_enterDir(_currentDirInUI);
			}
			else if (e.KeyCode == Keys.Back)
			{
				_exitDir();
			}
		}
	}
}
