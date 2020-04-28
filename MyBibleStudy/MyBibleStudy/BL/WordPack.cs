using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBibleStudy.BL
{
	public class WordPack
	{
		public string Name { get; set; }
		public List<WordsBankItem> WordsBankItems { get; set; } = new List<WordsBankItem>();
	}
}
