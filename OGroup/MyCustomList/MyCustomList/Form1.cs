using MyCustomList.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCustomList
{
	public partial class Form1 : Form
	{
		List<ListItem> _items;

		ListItem _selectedItem = null;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			_items = new List<ListItem>
			{
				new ListItem { Title = "Заметка 1", Message = "Вы никогда не задумывались, почему мы стареем и умираем?", Icon = Resources.profile, IconBackground = Color.BlueViolet },
				new ListItem { Title = "Заметка 2", Message = "Вы никогда не задумывались, почему мы стареем и умираем?", Icon = Resources.profile, IconBackground = Color.BlueViolet },
				new ListItem { Title = "Заметка 3", Message = "Вы никогда не задумывались, почему мы стареем и умираем?", Icon = Resources.profile, IconBackground = Color.BlueViolet },
				new ListItem { Title = "Заметка 4", Message = "Вы никогда не задумывались, почему мы стареем и умираем?", Icon = Resources.profile, IconBackground = Color.BlueViolet },
				new ListItem { Title = "Заметка 5", Message = "Вы никогда не задумывались, почему мы стареем и умираем?", Icon = Resources.profile, IconBackground = Color.BlueViolet },
				new ListItem { Title = "Заметка 6", Message = "Вы никогда не задумывались, почему мы стареем и умираем?", Icon = Resources.profile, IconBackground = Color.BlueViolet },
				new ListItem { Title = "Заметка 7", Message = "Вы никогда не задумывались, почему мы стареем и умираем?", Icon = Resources.profile, IconBackground = Color.Yellow },
				new ListItem { Title = "Заметка 8", Message = "Вы никогда не задумывались, почему мы стареем и умираем?", Icon = Resources.profile, IconBackground = Color.BlueViolet },
				new ListItem { Title = "Заметка 9", Message = "Вы никогда не задумывались, почему мы стареем и умираем?", Icon = Resources.profile, IconBackground = Color.Crimson },
				new ListItem { Title = "Заметка 10", Message = "Вы никогда не задумывались, почему мы стареем и умираем?", Icon = Resources.profile, IconBackground = Color.BlueViolet },
				new ListItem { Title = "Заметка 11", Message = "Вы никогда не задумывались, почему мы стареем и умираем?", Icon = Resources.profile, IconBackground = Color.BlueViolet },
				new ListItem { Title = "Заметка 12", Message = "Вы никогда не задумывались, почему мы стареем и умираем?", Icon = Resources.profile, IconBackground = Color.BlueViolet },
				new ListItem { Title = "Заметка 13", Message = "Вы никогда не задумывались, почему мы стареем и умираем?", Icon = Resources.profile, IconBackground = Color.BlueViolet }
			};

			displayItems(_items);
		}

		private void displayItems(IEnumerable<ListItem> i)
		{
			flowLayoutPanel1.Controls.Clear();

			foreach (var item in i)
			{
				item.Click -= picture_click;
				item.Click += picture_click;
				flowLayoutPanel1.Controls.Add(item);
			}
		}

		void picture_click(object sender, EventArgs e)
		{
			if (_selectedItem != null)
				_selectedItem.BorderStyle = BorderStyle.None;
			_selectedItem = (ListItem)sender;
			_selectedItem.BorderStyle = BorderStyle.FixedSingle;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ICreateNoteForm noteForm = new CreateNoteForm();
			var res = noteForm.Display();
			
			if (res.ResultCode == FormResultCode.Ok)
			{
				var i = new ListItem { Title = noteForm.Title, Message = noteForm.Message, Icon = Resources.profile, IconBackground = Color.DarkGoldenrod };
				_items.Add(i);
				displayItems(_items);
			}
		}

		private void flowLayoutPanel1_Click(object sender, EventArgs e)
		{

		}

		private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
		{
			
		}
	}
}
