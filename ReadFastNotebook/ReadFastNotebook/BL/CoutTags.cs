using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Просто выявить два блока заключенных между парами {}
//		и получить все блоки текста, включая {}, для девериализации JSON

namespace ReadFastNotebook.BL
{
	/*
	 * in
	 * {Name=Roman{Age=41;Color=Black}}{Name=Natasha{Age=37;Color=Yellow}}
	 * 
	 * out
	 * objects count 4
	 * Name=Roman
	 *		|->Age=41;Color=Black
	 * Name=Natasha
	 *		|->Age=37;Color=Yellow
	 * 
	 * 
	 */

	public class CoutTags
	{
		public string[] GetObjs(string src)
		{
			List<string> result = new List<string>();

			string currStr = "";
			int cmCnt = 0;
			bool objStarted = false;
			foreach (var item in src)
			{
				currStr += item;
				if (item == '{')
				{
					cmCnt++;
				}
				else if (item == '}')
				{
					cmCnt--;
				}
			}
		}
	}

	class Node
	{
		public string Body { get; set; }
		public List<Node> Children { get; set; } = new List<Node>();
		public Node Parent { get; set; }
	}
}
