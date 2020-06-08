using Costs.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Costs.DB
{
	public class DirectoryDB
	{
		/// <summary>
		/// Возвращает плоскую коллекцию ключей директорий, относительно root, включая root. Если root == null возвращает всю коллекцию
		/// </summary>
		/// <param name="root"></param>
		/// <returns></returns>
		public static List<Directory> Read(Directory root = null)
		{
			var list = readDB();

			List<Directory> result = null;

			if (root == null)
				result = list;
			else result = readAllChildren(list, root);

			return result;
		}

		public static void Write(Directory dirKey)
		{
			using (AppData db = new AppData())
			{
				db.Entry(dirKey).State = dirKey.ID == 0 ? System.Data.Entity.EntityState.Added : System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
			}
		}

		static List<Directory> readAllChildren(List<Directory> sourceDirs, Directory root)
		{
			List<Directory> findResult = new List<Directory>();

			// Добавляем в буффер результата входящий корень
			findResult.Add(root);

			// Все элементы, которые ссылаются на root
			var allChildren = sourceDirs.Where(x => x.ParentID == root.ID).ToList();

			// Проход по каждому дочернему
			foreach (var item in allChildren)
				findResult.AddRange(readAllChildren(sourceDirs, item));

			// Добавляем все найденные дочерние
			//findResult.AddRange(allChildren); // Это лишнее, так как есть findResult.Add(root);

			return findResult;
		}

		static List<Directory> readDB()
		{
			using (AppData db = new AppData())
			{
				return db.Directories.ToList();
			}
		}
	}
}
