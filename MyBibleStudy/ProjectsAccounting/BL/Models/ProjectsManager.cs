﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Для инициализации передается директория, в которой содержится json-файл с информиацией о проектах директории
 *		какие директории считать проектами
 *	каждому проекту выделяется папка, внутри которой так же файл с информацией о проекте: название, части проекта
 *	и в папке проекта недельные папки, внутри которых уже содержатся сессии.
 * 
 * Создание нового проекта.
 *	1. Добавляем новый проект, даем имя.
 *	1.1	Автоматически добавляется часть проекта с именем Без имени
 *	
 *	
 *	
 *>>>
 * Задачи:
 *	Показать запланированные сессии на выбранной дате. Сессии всех проектов.
 *	Сессия может не ссылаться ни на какой проект. Такие сессии будут выводиться в категории "Другие задачи"
 *	Хочу, чтобы каждый проект был в своей папке. Так как могут быть файлы проекта.
 *		Скорее всего универсального решения не получиться ввиду индивидаульности работ.
 *			Ввиду этого данный проект - это только трекер с возможностью кратко описывать поставленные задачи, т.е. что сделать за сессию.
 *				А так же зафиксировать потреченное время (старт - стоп, паузы)
 *					Сырцы проекта - это отдельная тема.
 *	
 *	Мне нужно: выбрав ячейку даты, увитель какие сесси содержатся в ней.
 *				возможность планировать на месяц вперед и на каждую неделю.
 *				просмотр сессий проекта за неделю и за месяц.
 *				можно иметь банк долгосрочных проектов
 *				это приложение - единая точка всех проектов, поэтому вся информация по всем проектам дожлна располагаться
 *				    в одном файле/папке и пути относительными (я еще не решил что использовать sqlite или папки и json)
 *				окно просмотра статистики и работа с сессиями, назначение сессий по дням - это разные окна.
 *				список проектов и список частей - это один listbox (listview) - нажав ентер на проект выводится список его частей или пукт default
 *	
 *	
 * Еще раз, что мне надо?... Как я хочу работать?
 *  Я могу ставить перед собой крупные и небольшие задачи (проекты)
 *  Я хочу расписывать месячную и недельную программу-график работы по проектам.
 *      В это входит, какие материалы проработать, какую часть проекта программы продумать, написать.
 *  Мне нужна функция расписания на неделю но с возможностью вносить изменения по ходу дела.
 *  Мне нужно фиксировать, сколько времени потратил на выполнение данной части проекта.
 *  Начиная новый день я не должен гадать в муках, что мне делать.
 *      Спокойно, ни о чем не беспокоясь браться за запланированный объем.
 *      Для этого необходимо умело планировать задачи на месяц (более крупные части) и неделю (более подробный план)
 *      Но при всем при этом руководствоваться здравым смыслом и проявлять гибкость в зависимости от возникших ситуаций.
 *  
 *  
 *  
 *  
 *  
 *  >>>
 *  22-03-2020 3-01 ВАЖНО к реализации проекта
 *  Исходя из вышесказанного, прложение должно поддерживать:
 *      Банк крупных задач (проектов).
 *          Возможно функция закрыть проект и не отображать такие в банке задач
 *      Банк задач месяца, недели.
 *          По ходу периода уже создаются сессии реального выполнения.
 *          !!!В бумажной тетради я бы так и делал: Выделил лист начала недели, вписал бы список задач недели с примерным описание когда выполнять,
 *          !!!            и на следующих листах бы кратко описывал результат и задраченное время.
 *              Выходит сущность недели содержит список задач,
 *              Каждая задача ссылается на проект. А выполненная сессия ссылается на запланированную задачу.
 *                  Если проект закончился (например он небольшой), закрываю его и в дальнейшем в банке задачь можно отключить его отображение.
 *                      Ну а индивидуальну проблему English.Listening можно так и решить, отказавшись от частей подпроектв как таковых
 *                          поэтому подходит такое решение:
 *                              Project <- Task <- Session
 *                              Т.е. в конце недели составляю список задачь на след неделю, при выполнении, создаю сессию, и приложение требует указать
 *                                  к какой задаче это относится.
 *                                      Сущность задачи имеет поле - член с запланированным кол-м часов на неделю. Т.е. задачу можно выполнять в несколько сессий.
 *                          Задача - не часть проекта.
 *                          Банк задач содержит сущность недели а не сущность проекта.
 *                          Хотя все же может проект иметь список задач как в контексте недели так и месяца так и вобщем.
 *                              Так же задача содержит список сессий недели. 
 *                          Сущность проекта может загружаться в соответствии с контектом, или параметрами выборки.
 *                          
 *                          >>>
 *                          23-03-2020 3-52
 *                          Перетащил задачу на окно дня - создал сессию.
 *                          Перетащил проект на окно недели (список задач недели) - создал задачу.
 *                          После этого задачи и сесси можно редактировать. Задаче дать имя содержания, сессии... пока незнаю... :)
 *                          
 *  >>>
 *  23-03-2020 16-04
 *  Приложение получает папку, содержащую проект-тракинги. Т.е. всю базу тракингов проектов.
 *      И эта папка отслеживается гитом.
 * 
 * 
 *  >>>
 *  25-03-2020 15-36
 *  Структура данных модели
 *      Банк проектов
 *      Банк задач -> проект
 *      Сессии -> задача -> проект
 * 
 */

namespace ProjectsAccounting.BL.Models
{
	public class ProjectsManager
	{
		string rootDir;
		const string rootInfoFile = "projects.json";

		List<string> projects;

		public ProjectsManager(string proj_directory)
		{
			rootDir = proj_directory[proj_directory.Length - 1] == '\\' ? proj_directory : proj_directory + '\\';
			readProjects(rootDir);
		}

		public IEnumerable<string> Projects { get { return projects; } }
		public void AddProject(string projectName)
		{
			projects.Add(projectName);

			string dirName = $"{rootDir}{projectName}";

			if (Directory.Exists(dirName)) return;

			Directory.CreateDirectory(dirName);

			string j = Newtonsoft.Json.JsonConvert.SerializeObject(projects, Newtonsoft.Json.Formatting.Indented);
			File.WriteAllText($"{rootDir}{rootInfoFile}", j, Encoding.UTF8);
		}

		void readProjects(string rootDr)
		{
			string infFile = $"{rootDir}{rootInfoFile}";
			projects = new List<string>();

			if (!File.Exists(infFile)) return;
			string j = File.ReadAllText(infFile, Encoding.UTF8);
			projects = Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(j);
		}
	}
}
