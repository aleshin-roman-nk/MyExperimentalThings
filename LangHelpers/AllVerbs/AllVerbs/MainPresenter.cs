using AllVerbs.BL;
using AllVerbs.Deb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllVerbs
{
	public class MainPresenter
	{
		IMainView _view;
		RmVerbRepository repo;// Usually we pass an object like this (db content access) as interface when creating an instance of
								// MAIN presenter. So, when presenter is simple, I better don't write complicated code.

		public MainPresenter(IMainView v)
		{
			_view = v;
			repo = new RmVerbRepository();

			_view.WordFilterChanged += _view_WordFilterChanged;
			_view.SaveWord += _view_SaveWord;
			_view.UpdateView += _view_UpdateView;
			_view.DeleteWord += _view_DeleteWord;

			_view.DisplayWords(repo.GetAll());
			_view.DisplayVerbAmount(repo.GetAmountOfAllVerbs());
		}

		private void _view_DeleteWord(RmWord obj)
		{
			repo.Delete(obj.Id);
		}

		private void _view_UpdateView()
		{
			_view.DisplayWords(repo.GetWordsStartingWith(_view.WordFilterText));
			_view.DisplayVerbAmount(repo.GetAmountOfAllVerbs());
		}

		private void _view_SaveWord(RmWord obj)
		{
			repo.Save(obj);
		}

		private void _view_WordFilterChanged()
		{
			var data = repo.GetWordsStartingWith(_view.WordFilterText);
			_view.DisplayWords(data);
		}
	}
}
