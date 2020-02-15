using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Этот проект - протипирование приложения. Черновой - экспериментальный вариант.
 * Здесь я хочу продумать, чего я вообще хочу.
 * Упрощенные модели
 * 
 * 
 * Описание элементов формы
 *      Проекты
 *          содержатся все долгосрочные проекты, над которыми работаю
 *          
 *  >>>
 *  12-02-2020 16-10
 *  Панель файлов проекта и панель функции маркеров отдельно.
 *      В панель файлов (материалов) проекта добавляем нужные файлы.
 *      Для каждого проекта создается своя папка.
 *  Данный проект не имеет индексного файла проектов.
 *      Просматривая каждую папку, проверяем файл-признак, что эта папка - проект системы.
 * 
 *  Создать настроенный MVP проект - шаблон.
 * 
 * !!!
 * >>>
 * Мне надо поработать в EXCEL чтобы лучше понять, что мне на самом деле нужно для регистрации расхода времени и планирования объемов.
 * 
 * Банк планов работ. Это то что я запланировал делать. В банк добавляется учет потраченного времени на элемент
 * 
 * >>>
 * 13-02-2020
 * пока все в файлах, текст, в файлах делать отдельной строкой маркеры.
 * один проект - одна папка. в папке отдельный файл планов в формате json.
 * пока отработать алгоритм поиска и анализа тегов. тег старт, после этого ожидание тега стоп.
 *      если снова тег старт, ошибка.
 *      при работе рабочий весь текст в поле - это объект в рабочей памяти.
 *      интерактивное отслеживание открыт - закрыт.
 *      при новой операции (помещение тега) перепроверять все строки.
 *      но конечно, в этом случае лучше проверять не строками а посимвольный разбор.
 * в папке моих работ в корне:
 *      папки всех проектов
 *      администрирующие приложения
 *      папка каждого проекта содержит файл плана
 *          при загрузке приложения, читаются все файлы планов из папки каждого проекта и строится общая коллекция планов.
 * 
 * 
 */

namespace UIImagine
{
	public partial class Form1 : Form
	{
        List<Entity1> markers = new List<Entity1>();
        List<ProjItem> projItems = new List<ProjItem>();
        IMonthChoose monthChoose;

        public Form1()
		{
			InitializeComponent();
            entity1BindingSource1.DataSource = markers;
            entity1BindingSource1.ResetBindings(false);

            foreach (DataGridViewColumn item in gridCalendar.Columns)
                item.SortMode = DataGridViewColumnSortMode.NotSortable;

            lvMain.ItemSelectionChanged += LvMain_ItemSelectionChanged;

            MakeItems();

            monthChoose = monthChoose1;

            monthChoose.MonthChoosed += MonthChoose_MonthChoosed;
            fetchMobthGrid(monthChoose.Date);
        }

        private void MonthChoose_MonthChoosed(DateTime obj)
        {
            fetchMobthGrid(obj);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            markers.Add(Entity1.StartMarker());
            entity1BindingSource1.ResetBindings(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            markers.Add(Entity1.StopMarker());
            entity1BindingSource1.ResetBindings(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (markers.Count == 0) return;
            var ent = markers.Last();

            markers.Remove(ent);

            entity1BindingSource1.ResetBindings(false);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
        }

        void fetchMobthGrid(DateTime dt)
        {
            gridCalendar.Rows.Clear();

            var month = GetDates(dt.Year, dt.Month);

            int weekOfMonth = gridCalendar.Rows.Add();
            listBox2.Items.Clear();

            foreach (var item in month)
            {
                int dayOfWeek = int.Parse(item.DayOfWeek.ToString("d"));
				if (dayOfWeek == 0) dayOfWeek = 6;
				else
					dayOfWeek = dayOfWeek - 1;

				string txt = $"{item.Day}";

                if(dayOfWeek == 6)
                {
                    gridCalendar.Rows[weekOfMonth].Cells[dayOfWeek].Value = txt;
                    weekOfMonth = gridCalendar.Rows.Add();
                }
                else
                    gridCalendar.Rows[weekOfMonth].Cells[dayOfWeek].Value = txt;
            }
        }

        private void btnReloadItems_Click(object sender, EventArgs e)
        {
            lvMain.Items.Clear();

            foreach (var item in projItems)
            {
                var o = lvMain.Items.Add(item.Name);
                o.Tag = item;
                o.SubItems.Add(item.Body);
                o.ImageIndex = 0;
            }
        }

        public List<DateTime> GetDates(int year, int month)
        {
            return Enumerable.Range(1, DateTime.DaysInMonth(year, month))
                             // Days: 1, 2 ... 31 etc.
                             .Select(day => new DateTime(year, month, day))
                             // Map each day to a date
                             .ToList(); // Load dates into a list
        }

        private void MakeItems()
        {
            foreach (var item in GetDates(2020, 2))
            {
                projItems.Add(new ProjItem
                {
                    Name = $"{item.Day} ({item.ToString("dddd")})",
                    Body = "Some text"
                });
            }


            //projItems.Add(new ProjItem { 
            //    Name = "Понедельник",
            //    Body = "Some text"
            //});
            //projItems.Add(new ProjItem
            //{
            //    Name = "Вторник",
            //    Body = "Some text practice"
            //});
            //projItems.Add(new ProjItem
            //{
            //    Name = "Среда",
            //    Body = "Some text about"
            //});
            //projItems.Add(new ProjItem
            //{
            //    Name = "Четверг",
            //    Body = "Articles"
            //});
        }

        private void LvMain_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected) ;
                //listBox1.Items.Add(e.Item.Text);
        }

        private void gridCalendar_SelectionChanged(object sender, EventArgs e)
        {
            if (gridCalendar.SelectedCells.Count == 0) return;
            if (gridCalendar.SelectedCells[0] == null) return;
            if (gridCalendar.SelectedCells[0].Value == null)
            {
                txtDay.Text = "-";
                return;
            }

            txtDay.Text = gridCalendar.SelectedCells[0].Value.ToString();
        }
    }
}
