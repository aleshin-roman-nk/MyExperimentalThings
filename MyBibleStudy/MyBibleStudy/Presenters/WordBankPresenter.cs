using MyBibleStudy.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBibleStudy
{
	public class WordBankPresenter
	{
		IRepetitionView view;
		WordsBankModel model;

		public WordBankPresenter(IRepetitionView v)
		{
			view = v;
			model = new WordsBankModel();

			view.BtnSaveAll += View_BtnSaveAll;
			view.BtnCreatePack += View_BtnCreatePack;
			view.BtnDeletePack += View_BtnDeletePack;
			view.BtnDeleteWord += View_BtnDeleteWord;
			view.BtnCreateWord += View_BtnCreateWord;
			view.BtnClosing += View_BtnClosing;

			view.SetPacks(model.GetWordPacks());
		}

		private void View_BtnClosing(IEnumerable<WordPack> obj)
		{
			model.SaveAll(obj);
		}

		private void View_BtnDeleteWord(WordsBankItem arg1, WordPack arg2)
		{
			model.DeleteWord(arg1, arg2);
			model.Save(arg2);
			view.SetPacks(model.GetWordPacks());
		}

		private void View_BtnSaveAll(IEnumerable<WordPack> obj)
		{
			model.SaveAll(obj);
			view.SetPacks(model.GetWordPacks());
		}

		private void View_BtnCreateWord(string arg1, WordPack arg2)
		{
			arg2.WordsBankItems.Add(new WordsBankItem { Name = arg1});
			model.Save(arg2);
			view.SetPacks(model.GetWordPacks());
		}

		private void View_BtnDeletePack(WordPack obj)
		{
			model.DeletePack(obj);
			view.SetPacks(model.GetWordPacks());
		}

		private void View_BtnCreatePack(string name)
		{
			CreateAndSave(name);
		}

		private void CreateAndSave(string packname)
		{
			if (model.IsPackExists(packname) && !MyDialogs.UserAnswerYes($"Пак {packname} уже существует. Перезаписать?"))
				return;

			WordPack wp = new WordPack();
			wp.Name = packname;
			model.Save(wp);
			view.SetPacks(model.GetWordPacks());
		}

		public void Go()
		{
			view.ShowForm();
		}
	}
}
