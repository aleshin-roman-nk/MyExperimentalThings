using Costs.DB;
using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.BL.Models
{
	public class DirectoryModelTools
	{
		Directory _thisDir;

		public void __set(Directory dir)
		{
			_thisDir = dir;
		}

		public void Attach(Directory dir)
		{
			if (_thisDir.ID == dir.ID) throw new ArgumentException("Попытка перенести директорию саму в себя");

			dir.ParentID = _thisDir.ID;
			DirectoryDBA.Save(dir);
		}
		public void Attach(Purchase p)
		{
			p.DirectoryID = _thisDir.ID;
			p.Directory = _thisDir;

			PurchasesDBA.Save(p);
		}
		public void CreateChild(string child_name)
		{
			Directory dir = new Directory { Name = child_name, ParentID = _thisDir.ID };
			DirectoryDBA.Save(dir);
		}

		public void Save(Directory dir)
		{
			DirectoryDBA.Save(dir);
		}
		public void Rename(string newname)
		{
			_thisDir.Name = newname;
			DirectoryDBA.Save(_thisDir);
		}
		public void Delete()
		{
			if (DirectoryDBA.HasChildren(_thisDir)) throw new ArgumentException($"Директория '{_thisDir.Name}' содержит вложенные директории");
			if (DirectoryDBA.HasPurchases(_thisDir)) throw new ArgumentException($"Директория '{_thisDir.Name}' содержит покупки");

			DirectoryDBA.Delete(_thisDir);
		}
	}
}
