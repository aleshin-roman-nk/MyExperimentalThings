using DrRomic.UI;
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

namespace DrRomic
{
	public partial class Form1 : Form
	{
        List<Entity1> markers = new List<Entity1>();
        List<ProjItem> projItems = new List<ProjItem>();
        IMyCalendar calendar;

        public Form1()
		{
			InitializeComponent();
            //entity1BindingSource1.DataSource = markers;
            //entity1BindingSource1.ResetBindings(false);

            //foreach (DataGridViewColumn item in gridCalendar.Columns)
            //    item.SortMode = DataGridViewColumnSortMode.NotSortable;

            //lvMain.ItemSelectionChanged += LvMain_ItemSelectionChanged;

            //MakeItems();

            //monthChoose = monthChoose1;

            //monthChoose.MonthChoosed += MonthChoose_MonthChoosed;
            //fetchMobthGrid(monthChoose.Date);

            calendar = myCalendar1;

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

        private void MakeItems()
        {
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

        private void myCalendar1_DateChoosed(DateTime obj)
        {

        }
    }
}
