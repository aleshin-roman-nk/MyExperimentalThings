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

	public static class CoutTags
	{
		public static string[] GetObjs(string src)
		{
			List<string> result = new List<string>();

			string currStr = "";
			int cmCnt = 0;
			bool objStarted = false;
			foreach (var item in src)
			{
				if (item == '{')
				{
					cmCnt++;
					objStarted = true;
				}
				else if (item == '}')
				{
					cmCnt--;
					currStr += item;

					if (cmCnt == 0)
					{
						objStarted = false;
						result.Add(currStr);
						currStr = "";
					}
				}

				if(objStarted)
					currStr += item;
			}

			return result.ToArray(); ;
		}
	}

	class Node
	{
		public string Body { get; set; }
		public List<Node> Children { get; set; } = new List<Node>();
		public Node Parent { get; set; }
	}
}
