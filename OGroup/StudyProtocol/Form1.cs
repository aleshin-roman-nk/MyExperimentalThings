﻿using StudyProtocol.DbAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * 
 * >>> Главная задача проекта - подсчитывать время и регистрировать эффективность выполняемой работы.
 * 
 * Пока будем записывать объекты в json формате.
 * 
 * 1. Создание файла сегодняшнего протокола
 * 2. Имя файла по шаблону prc_DD_MM_YYYY.txt
 * 
 * Вообще нужно продумать алгоритм организации моей работы.
 *	
 * 
 * 
 * Программа регистрирует начало, конец рабты.
 *	Создание рабочей смены.
 *	Кнопки старта, паузы, продолжения, закрытия.
 *	Кнопки добавления файлов, в которых содержится работа.
 *	Исходники это может быть папка какого то проекта.
 *		Это позволит суммировать общее время, работы, запывать по сменам, что конкретно сделано, какие вопросы поднимались и их решение.
 *			Так как файл работы может быть один, над которым работал много дней.
 *			
 *	Дожна быть конкретная постановка задачи, что сегодня должен завершить.
 *	
 *	!!! ТЕКУЩАЯ ЗАДАЧА
 *	>>> Пока просто регистрируем начало, паузы, возобновление, окончание, в комментарии ссылка на исходник работы.
 *			Исходник можно линковать автоматически, создавая текстовый файл.
 * 
 * 
 * >>>
 * 10-02-2020
 * Пока не буду делать сложно с использованием сложной логики и sqlite и EF
 *		Один проект (задача) - одна папка, в которой json файлы с описанием цели.
 *		При старте загружаем все эти папки, или фитаем json файл с описанием что нужно загрузить (какие папки)
 *		Хотя это можно и с sqlite сделать, пока мне нужно опять вспоминать и тренировать навык углубленнолй работы с EF
 *		    сложные выборки и т.д.
 * Механизм:
 *      Открываем день
 *      День содержит работы
 *      Работы содержат маркеры старта, паузы, продолжения, остановки.
 * 
 * >>>
 * 11-02-2020 22-51
 * Сделать генерацию файла sqlite ручным способом.
 * Каждый новые проект - новый файл sqlite со всей внутренней структурой.
 * 
 * >>>
 * Касательно панельной логики.
 *  Составные панели, построенные посредством интерфейсов.
 *      Или панель полная, с гридом и контролами. И передают управление друг другу через общий контроллер.
 *      Таблица команд в виде dictionary. Это касательно обработки запросов (команд)
 *  
 * Функция запланировать какой конкретно материал работать.
 * 
 * >>>
 * 12-02-2020 6-42
 * Вообще пусть корнем домена будет объект проекта.
 *  Просто будем добавлять маркеры страт, пауза, продолжить, стоп.
 *  И вообще, мне нужно приложение, в котором я могу архивировать изучаемый материл, а потом повторять.
 *          ХОТЯ это вполне может быть тетрадь. Записывать конспекты, слова, конструкции.
 *              Модет отдельная папка на компьютере, в которой лежат файлы - карточки повторения.
 *                  Единственно, можно написать приложение, которое управляет, что и когда мне нужно повторить.
 *                  
 * Способ обертки...
 *      плоская сущность
 *      обертка - класс, который берет указатель на оборачиваемый класс, но предоставляет методы.
 *          и именно эта обертка передается в рабочий слой.
 *              или обертка - это интерфейс. вобщем проработать эту версию практически. а вообще мне следует тщатиельно изучать популярные шаблоны проектирпования
 *   Поэксперентировать с интерфейсным взатмодействием компонентов IView
 *      Т.е. если механизм UI дастаточно сложен, он должен состоять из компонентов, которые склеиваются интерфейсами.
 *      Очевидно, если контроллер универсально работает с компонентами, которые могут добавляться, однозначно должен быть какой то общий протокол требований
 *          которые добюавляемый компонент должен подчиняться.
 *          
 *   Касательно идеи работы с проектами. Одно окно, в котором можно создавать новые проект, присваивать ему иконку.
 *      Войдя в этот проект, выводится файлы и др компоненты этого проекта, в том числе и функция учета затраченного времени (меркеры времени).
 *    
 *   Первое что нужно сделать при разработке, четко очертить конечную цель, что я хочу сделать.
 *      Прорисовать интерфейс, продумать функционал.
 *      Открывать какой-нибудь векторный редактор и рисовать схемы.
 *      
 *   Первая часть разработки не должна быть работой над сохранением, базой данных.
 *      Пишем сущности, доменную модель.
 *      И лишь в последнюю очередь пишем часть хранения.
 *      
 *   Представлять панели приложения, которые сменяются.
 *   Думаю лучше всего предоставлять контроллеру / презентеру интерфейс комбинированного IView
 *   
 *   
 *   ****
 *   * Агрессивно продвигаться вперед вперед вперед
 *   ****
 *   
 *   Всегда надо понимать, в IView, панели мы отдаем какой то блок данных, структуру.
 *      IU уже само знает что делаль, как показать.
 *          Контроллер / презентер уже только ожидает запрос от UI системы
 *   
 * 
 */

namespace StudyProtocol
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnPause_Click_1(object sender, EventArgs e)
		{
			insertText($"[*]: {DateTime.Now.ToString("HH-mm-ss")}");
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			insertText($">>> {DateTime.Now.ToString("HH-mm-ss")}");
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			insertText($"<<< {DateTime.Now.ToString("HH-mm-ss")}");
		}

		private void btnContinue_Click(object sender, EventArgs e)
		{
			insertText($"|>: {DateTime.Now.ToString("HH-mm-ss")}");
		}

		private void insertText(string str)
		{
			var insertText = Environment.NewLine + str + Environment.NewLine;
			var selectionIndex = richTextBox1.SelectionStart;
			richTextBox1.Text = richTextBox1.Text.Insert(selectionIndex, insertText);
			richTextBox1.SelectionStart = selectionIndex + insertText.Length;
		}

        private void button1_Click(object sender, EventArgs e)
        {
            var dlist = Directory.GetDirectories(Directory.GetCurrentDirectory(), "PRJ.*");

            listBox1.Items.Clear();
            foreach (var item in dlist)
            {
                var l = item.Split(new char[] { '\\', '/' });

                listBox1.Items.Add(l.Last());
            }
        }
    }
}