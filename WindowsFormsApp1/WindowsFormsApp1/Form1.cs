using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
		BindingSource bsList1 = new BindingSource();
		BindingSource bsList2 = new BindingSource();

		List<A> list1;
		List<A> list2;

		public Form1()
		{
			InitializeComponent();

			list1 = new List<A> { new A { Name = "Roman" }, new A { Name = "Nataly"}, new A { Name = "Vitaly"} };

			list2 = new List<A>();

			bsList1.DataSource = list1;
			bsList2.DataSource = list2;

			listBox1.DataSource = bsList1;
			listBox1.DisplayMember = "Name";

			listBox2.DataSource = bsList2;
			listBox2.DisplayMember = "Name";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var cur = listBox1.SelectedItem as A;

			if (cur == null) return;

			list1.Remove(cur);
			list2.Add(cur);

			bsList1.ResetBindings(false);
			bsList2.ResetBindings(false);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var cur = listBox2.SelectedItem as A;

			if (cur == null) return;

			list2.Remove(cur);
			list1.Add(cur);

			bsList1.ResetBindings(false);
			bsList2.ResetBindings(false);
		}
	}

	class A
	{
		public string Name { get; set; }
	}
}
