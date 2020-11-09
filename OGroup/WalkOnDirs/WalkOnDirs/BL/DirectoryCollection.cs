using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkOnDirs.BL
{
	public class DirectoryCollection
	{
		List<Directory> _dirs;
		Directory _root;
		public DirectoryCollection()
		{
			_dirs = new List<Directory>();

			_dirs.Add(new Directory { Id = 1, Name = "English", ParentId = 0 });
			_dirs.Add(new Directory { Id = 2, Name = "Listening", ParentId = 1 });
			_dirs.Add(new Directory { Id = 3, Name = "Grammar", ParentId = 1 });

			_dirs.Add(new Directory { Id = 4, Name = "Programming", ParentId = 0 });
			_dirs.Add(new Directory { Id = 5, Name = ".NET", ParentId = 4 });
			_dirs.Add(new Directory { Id = 6, Name = "ASP", ParentId = 4 });
			_dirs.Add(new Directory { Id = 7, Name = "GIT", ParentId = 4 });

			_dirs.Add(new Directory { Id = 8, Name = "Spirit", ParentId = 0 });
			_dirs.Add(new Directory { Id = 9, Name = "Bible reading", ParentId = 8 });
			_dirs.Add(new Directory { Id = 10, Name = "Publishing", ParentId = 9 });
			_dirs.Add(new Directory { Id = 11, Name = "Meetings", ParentId = 9 });

			_dirs.Add(new Directory { Id = 12, Name = "Arduino", ParentId = 0 });
			_dirs.Add(new Directory { Id = 13, Name = "Kolonna", ParentId = 12 });
			_dirs.Add(new Directory { Id = 14, Name = "Teplitsa", ParentId = 12 });
		}

		public IEnumerable<Directory> GetChildrenOf(Directory dir)
		{
			return (from res in _dirs
				   where res.ParentId == dir.Id
					select res)
				   .ToList();
		}

		public string GetFullPathOf(Directory dir)
		{
			List<string> res = new List<string>();

			var d = dir;

			while(d != _root)
			{
				res.Add(d.Name);
				d = GetParentOf(d);
			}

			res.Reverse();

			StringBuilder strb = new StringBuilder();

			foreach (var item in res)
			{
				strb.Append($"{item}\\");
			}

			return strb.ToString();
		}

		public Directory GetParentOf(Directory dir)// подумать как возвращать не null
		{
			var res = _dirs.FirstOrDefault(x => x.Id == dir.ParentId);
			if (res == null) res = GetRoot();
			return res;
		}

		public Directory GetRoot()
		{
			if(_root == null) _root = new Directory { Id = 0, Name = "Root" };
			return _root;
		}
	}
}
