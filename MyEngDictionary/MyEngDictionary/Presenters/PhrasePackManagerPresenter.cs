using DialCommuna.FormResult;
using MyEngDictionary.BL.Entities;
using MyEngDictionary.BL.Models;
using MyEngDictionary.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEngDictionary.Presenters
{
	public class PhrasePackManagerPresenter : IPresenter
	{
		IPhrasePackManagerView _phrasePackManagerView;
		PhrasePackManagerModel _phrasePackManagerModel;

		public PhrasePackManagerPresenter(IPhrasePackManagerView v)
		{
			_phrasePackManagerView = v;
			_phrasePackManagerModel = new PhrasePackManagerModel();
			_phrasePackManagerView.PhrasePackCRUDRequset += _phrasePackManagerView_PhrasePackCRUDRequset;
		}

		private void _phrasePackManagerView_PhrasePackCRUDRequset(object sender, CRUDRequest<BL.Entities.PhrasePack> e)
		{
			if(e.CRUDCode == CRUDType.Create)
			{
				var res = DialCommuna.Dialogs.InputText.Show("Введите название новой группы");
				if(res.Answer == ViewAnswer.Ok)
				{
					PhrasePack pack = new PhrasePack();
					
					pack.Name = res.Data;
					_phrasePackManagerModel.Save(pack);
					_reloadView();
				}
			}else if(e.CRUDCode == CRUDType.Delete)
			{
				if(DialCommuna.Dialogs.UserAnswerYes.Show($"Удалить пакет {e.Data.Name}?", "УДАЛЕНИЕ ПАКЕТА"))
				{
					_phrasePackManagerModel.Delete(e.Data);
					_reloadView();
				}
			}
		}

		// executor (does something to make requested data then returns it)
		public void Init(IPresenterHub hub)
		{
			// Регистрируем обработку команды 
			hub.RegisterCommand(EventType.SelectPhrasePack, _run);
		}

		ViewResult<object> _run(object o)
		{
			_clear();
			_reloadView();
			var res = _phrasePackManagerView.Go();
			return new ViewResult<object> { Answer = res.Answer, Data = res.Data };
		}

		void _clear()
		{

		}

		void _reloadView()
		{
			_phrasePackManagerView.PutPhrasePackCollection(_phrasePackManagerModel.GetAll());
		}
	}
}
