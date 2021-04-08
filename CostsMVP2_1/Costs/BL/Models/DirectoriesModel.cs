using Costs.DB;
using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Models
{

	/*
	 * >>> 14-08-2020 08:25
	 * Или модель коллекции (DirecrotyCollectionModel) возвращает коллекцию моделей (IEnumerable<DirectoryModel>)
	 *	При таком решении проблема - прямой доступ к полям сущности
	 */
	public class DirectoriesModel
	{
		public IEnumerable<Directory> Directories { get; private set; } = null;

		//public void Load()
		//{
		//	Directories = DirectoryDBA.ReadAll();
		//}

		public string GetDirFullName(int dirid)
		{
			List<Directory> dirs = new List<Directory>();

			int parentid = 0;

			Directory curr = GetDirectory(dirid);

			do
			{
				dirs.Add(curr);
				parentid = curr.ParentID;
				curr = GetDirectory(parentid);
			}
			while (parentid > 0);

			dirs.Reverse();

			StringBuilder res = new StringBuilder();

			foreach (var item in dirs)
			{
				res.Append($"{item.Name} \\ ");
			}

			string ress = res.ToString();
			ress = ress.TrimEnd(' ', '\\');

			return ress;
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

		// В репозиторий
		public IEnumerable<Directory> GetDirectories()
		{
			Directories = DirectoryDBA.ReadAll();
			return Directories;
			//return DirectoryDBA.ReadAll();
		}

		// В репозиторий
		public Directory GetDirectory(int id)
		{
			using (AppData db = new AppData())
			{
				return db.Directories.FirstOrDefault(x => x.ID == id);
			}
		}
	}
}
