using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskBank.BL;
using TaskBank.BL.DBAccess;
using Task = TaskBank.BL.Entities.Task;

namespace TaskBank
{
	public partial class Form1 : Form
	{
		TaskCollection _taskCollection;
		BindingSource bs;

		Task currentTask = null;
		bool isTaskChanged = false;

		public Form1()
		{
			InitializeComponent();

			//_taskCollection = new TaskCollection();
			bs = new BindingSource();
			//displayTasks(_taskCollection.Tasks);
		}

		private void displayTasks(IEnumerable<Task> tcollection)
		{
			dataGridView1.Columns.Clear();

			dataGridView1.AutoGenerateColumns = false;
			DataGridViewTextBoxColumn c = new DataGridViewTextBoxColumn();
			c.Width = 400;
			c.HeaderText = "Задачи";
			c.DataPropertyName = "Text";
			c.Name = "Text";
			dataGridView1.Columns.Add(c);
			bs.DataSource = tcollection;
			dataGridView1.DataSource = bs;
			dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			//dataGridView1.Columns["Text"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

			richTextBox1.DataBindings.Clear();
			richTextBox1.DataBindings.Add("Text", bs, "Text");
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			isTaskChanged = true;
		}

		private void richTextBox1_Enter(object sender, EventArgs e)
		{
			currentTask = bs.Current as Task;

			Text = "richTextBox1_Enter";
		}

		private void richTextBox1_Leave(object sender, EventArgs e)
		{
			currentTask = null;
			isTaskChanged = false;

			Text = "richTextBox1_Leave";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			TaskCollectionDb dbModel = new TaskCollectionDb();
			var list = dbModel.GetTasks();
			_taskCollection = new TaskCollection(list);
			displayTasks(_taskCollection.Tasks);
		}
	}
}
