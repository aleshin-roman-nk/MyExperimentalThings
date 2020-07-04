using Costs.DB;
using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.BL.Models
{
	public static class DirectoryModelExtention
	{
		public static void Attach(this Directory _thisDir, Directory dir)
		{
			if (_thisDir.ID == dir.ID) throw new ArgumentException("Попытка перенести директорию саму в себя");

			dir.ParentID = _thisDir.ID;
			DirectoryDBA.Save(dir);
		}
		public static void Attach(this Directory _thisDir, Purchase p)
		{
			p.DirectoryID = _thisDir.ID;
			p.Directory = _thisDir;

			PurchasesDBA.Save(p);
		}
		public static void CreateChild(this Directory _thisDir, string child_name)
		{
			Directory dir = new Directory { Name = child_name, ParentID = _thisDir.ID };
			DirectoryDBA.Save(dir);
		}

		public static void Save(this Directory _thisDir, Directory dir)
		{
			DirectoryDBA.Save(dir);
		}
		public static void Rename(this Directory _thisDir, string newname)
		{
			_thisDir.Name = newname;
			DirectoryDBA.Save(_thisDir);
		}
		public static void Delete(this Directory _thisDir)
		{
			if (DirectoryDBA.HasChildren(_thisDir)) throw new ArgumentException($"Директория '{_thisDir.Name}' содержит вложенные директории");
			if (DirectoryDBA.HasPurchases(_thisDir)) throw new ArgumentException($"Директория '{_thisDir.Name}' содержит покупки");

			DirectoryDBA.Delete(_thisDir);
		}
	}
}
