using MyEngDictionary.BL.DBA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEngDictionary.BL.Models
{
	public class GeneralModel
	{
		public static int PhraseCount
		{
			get
			{
				return GeneralInfoDBA.GetPhraseCount();
			}
		}
	}
}
