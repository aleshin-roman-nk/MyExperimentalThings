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
using TaskBank.BL.Models;
using TaskBank.Dlg;
using TaskBank.Dlg.forms;
using RmTask = TaskBank.BL.Entities.RmTask;

namespace TaskBank
{
	public partial class Form1 : Form
	{
		TaskBankModel _taskCollection;
		BindingSource bs;

		RmTask currentTask = null;
		bool isTaskChanged = false;

		public Form1()
		{
			InitializeComponent();

			//_taskCollection = new TaskCollection();
			bs = new BindingSource();
			//displayTasks(_taskCollection.Tasks);

			dataGridView1.AutoGenerateColumns = false;

			DataGridViewTextBoxColumn c1 = new DataGridViewTextBoxColumn
			{
				Width = 40,
				HeaderText = "#",
				DataPropertyName = "Id",
				Name = "Id"
			};
			DataGridViewTextBoxColumn c2 = new DataGridViewTextBoxColumn
			{
				Width = 400,
				HeaderText = "Задачи",
				DataPropertyName = "Text",
				Name = "Text"
			};
			dataGridView1.Columns.Add(c1);
			dataGridView1.Columns.Add(c2);
			dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			//dataGridView1.Columns["Text"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

			init();
		}

		private void displayTasks(IEnumerable<RmTask> tcollection)
		{
			bs.DataSource = tcollection;
			dataGridView1.DataSource = bs;
			
			richTextBox1.DataBindings.Clear();
			richTextBox1.DataBindings.Add("Text", bs, "Text");
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{
			isTaskChanged = true;
		}

		private void richTextBox1_Enter(object sender, EventArgs e)
		{
			currentTask = bs.Current as RmTask;

			Text = "richTextBox1_Enter";
		}

		private void richTextBox1_Leave(object sender, EventArgs e)
		{
			currentTask = null;
			isTaskChanged = false;

			Text = "richTextBox1_Leave";
		}

		private void init()
		{
			RmTaskRepository dbModel = new RmTaskRepository();
			var list = dbModel.GetAll();
			_taskCollection = new TaskBankModel(list);
			displayTasks(_taskCollection.Tasks);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			RmTaskRepository dbModel = new RmTaskRepository();

			IRmTaskForm f = new RmTaskForm();

			var res = f.Show("prompt");

			if (string.IsNullOrEmpty(res))
				return;

			dbModel.Create(res);

			var list = dbModel.GetAll();
			_taskCollection = new TaskBankModel(list);
			displayTasks(_taskCollection.Tasks);
		}
	}
}
