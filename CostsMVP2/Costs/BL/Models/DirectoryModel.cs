using Costs.DB;
using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.Models
{
	public class DirectoryModel
	{
		public Directory Make( string dirName, Directory parent = null )
		{
			return new Directory { Name = dirName, ParentID = parent == null ? 0 : parent.ID };
		}
		public bool MoveDirectory( Directory directory, Directory targetDir )
		{
			if (directory.ID == targetDir.ID) return false;

			directory.ParentID = targetDir.ID;

			using (AppData db = new AppData())
			{
				db.Entry(directory).State = System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
			}

			return true;
		}
		public bool IsParent(Directory movingDir, Directory toDir, IEnumerable<Directory> dirs)
		{
			if (movingDir.ParentID == toDir.ID) return true;

			Directory dir = toDir;

			while (dir.ParentID > 0)
			{
				dir = getParentDir(dirs, dir);

				if (dir != null)
				{
					if (movingDir.ID == dir.ID)
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
		public void CreateDirectory(string dirName, Directory parentDir)
		{
			if (parentDir == null || string.IsNullOrWhiteSpace(dirName)) return;

			using (AppData db = new AppData())
			{
				Directory dir = new Directory { Name = dirName, ParentID = parentDir.ID };
				db.Directories.Add(dir);
				db.SaveChanges();
			}
		}
		public bool DeleteDirectory(Directory dir)
		{
			using (AppData db = new AppData())
			{
				Directory chldDir = db.Directories.FirstOrDefault(x => x.ParentID == dir.ID);
				if (chldDir != default(Directory)) return false;

				Purchase p = db.Purchases.FirstOrDefault(x => x.DirectoryID == dir.ID);
				if (p != default(Purchase)) return false;

				db.Entry(dir).State = System.Data.Entity.EntityState.Deleted;
				db.SaveChanges();
			}

			return true;
		}
		public IEnumerable<Directory> GetDirectories()
		{
			return DirectoryDB.Read();
		}
		public void RenameDirectory(string dirName, Directory dir)
		{
			dir.Name = dirName;
			UpdateDirectory(dir);
		}
		public void UpdateDirectory(Directory dir)
		{
			if (dir == null) return;

			using (AppData db = new AppData())
			{
				db.Entry(dir).State = System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
			}
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
