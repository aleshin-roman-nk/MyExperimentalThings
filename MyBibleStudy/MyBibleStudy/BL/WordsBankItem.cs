using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBibleStudy.BL
{
	public class WordsBankItem
	{
		public string Name { get; set; }
		public string Title { get; set; }
		public string Body { get; set; }
		public List<TagTopic> Tags { get; set; }
	}
}
