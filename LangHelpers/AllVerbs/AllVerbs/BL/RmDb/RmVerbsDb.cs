using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllVerbs.BL.RmDb
{
	/// <summary>
	/// Моя база данных, распределенная в одной директории в разных файлах.
	/// Директории и файлы внутри базы:
	/// data.json - состояние базы (номера последних id)
	/// v00000.json - файлы слов словаря
	/// t00000.json - файлы тегов
	/// </summary>
	public class RmVerbsDb
	{
		public RmVerbsDb(string path)
		{

		}


	}
}
