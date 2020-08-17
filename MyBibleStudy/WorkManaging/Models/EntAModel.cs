using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkManaging.Entities;

namespace WorkManaging.Models
{
	public class EntAModel
	{
		public EntAModel(EntA ent)
		{

		}
	}

	/*
	 * 
	 * >>> 14-08-2020 01:53
	 * Одна идея
	 * EntA, EntAModel(EntA)
	 * 
	 * Другая идея
	 * композитная модель
	 * Ее создает некая EntAFactory
	 * 
	 * Или общий data source, обращаясь к которому презентер получает коллекцию сущностей или моделей сущностей
	 * 
	 * Задача строится от окна полдьзователя.
	 * Нужно четко сформировать функции окна.
	 * Затем проектировать логику обработки данных.
	 * 
	 * 
	 */
}
