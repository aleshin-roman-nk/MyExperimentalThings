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
 * 
 */

namespace UIImagine
{
	public partial class Form1 : Form
	{
        List<Entity1> markers = new List<Entity1>();
        List<ProjItem> projItems = new List<ProjItem>();

		public Form1()
		{
			InitializeComponent();
            entity1BindingSource1.DataSource = markers;
            entity1BindingSource1.ResetBindings(false);

            lvMain.ItemSelectionChanged += LvMain_ItemSelectionChanged;
            MakeItems();
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

        private void btnAddItem_Click(object sender, EventArgs e)
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
            projItems.Add(new ProjItem { 
                Name = "12-02-2020",
                Body = "Some text"
            });
            projItems.Add(new ProjItem
            {
                Name = "Working on gerund",
                Body = "Some text practice"
            });
            projItems.Add(new ProjItem
            {
                Name = "English conversation",
                Body = "Some text about"
            });
            projItems.Add(new ProjItem
            {
                Name = "My words",
                Body = "Articles"
            });
        }

        private void LvMain_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected) ;
                //listBox1.Items.Add(e.Item.Text);
        }
    }
}
