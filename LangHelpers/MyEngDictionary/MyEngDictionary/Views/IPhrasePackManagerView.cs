using DialCommuna.FormResult;
using MyEngDictionary.BL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEngDictionary.Views
{
	public interface IPhrasePackManagerView
	{
		void PutPhrasePackCollection(IEnumerable<PhrasePack> groups);
		ViewResult<PhrasePack> Go();

		event EventHandler<CRUDRequest<PhrasePack>> PhrasePackCRUDRequset;
	}
}
