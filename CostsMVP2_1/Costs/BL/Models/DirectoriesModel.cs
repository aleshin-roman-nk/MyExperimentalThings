using Costs.DB;
using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Models
{
	public class DirectoriesModel
	{
		public IEnumerable<Directory> Directories { get; private set; } = null;

		public void Load()
		{
			Directories = DirectoryDBA.ReadAll();
		}

		public IEnumerable<Directory> ReadAllChildren(Directory root)
		{
			var stack = new Stack<Directory>();

			Func<Directory, IEnumerable<Directory>> getChildren = (parent_dir) =>
			{
				return Directories.Where(x => x.ParentID == parent_dir.ID).ToList();
			};

			stack.Push(root);
			while (stack.Any())
			{
				var next = stack.Pop();
				yield return next;
				foreach (var child in getChildren(next))
					stack.Push(child);
			}
		}
		public bool IsParent(Directory child, Directory parent)
		{
			if (child.ParentID == parent.ID) return true;

			Directory dir = parent;

			while (dir.ParentID > 0)
			{
				dir = getParentDir(Directories, dir);

				if (dir != null)
				{
					if (child.ID == dir.ID)
						return true;
				}
				else break;
			}

			return false;
		}
		Directory getParentDir(IEnumerable<Directory> dirs, Directory dir)
		{
			return dirs.FirstOrDefault(x => x.ID == dir.ParentID);
		}

		public IEnumerable<Directory> GetDirectories()
		{
			return DirectoryDBA.ReadAll();
		}

		public Directory GetDirectory(int id)
		{
			using (AppData db = new AppData())
			{
				return db.Directories.FirstOrDefault(x => x.ID == id);
			}
		}
	}
}
