using StudyProtocol.DbAccess;
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
			var insertText = str + Environment.NewLine;
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
                listBox1.Items.Add(item);
            }
        }
    }
}
