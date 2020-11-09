using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCustomList
{
	public partial class ListItem : UserControl
	{
		public ListItem()
		{
			InitializeComponent();
		}

		private string _title;
		private string _message;
		private Image _image;
		private Color _iconBackground;

		[Category("Custom props")]
		public string Title
		{
			get { return _title; }
			set { _title = value; lblTitle.Text = _title; }
		}
		[Category("Custom props")]
		public Color IconBackground
		{
			get { return _iconBackground; }
			set { _iconBackground = value; panel1.BackColor = _iconBackground; }
		}

		[Category("Custom props")]
		public string Message
		{
			get { return _message; }
			set { _message = value; lblMessage.Text = _message; }
		}
		[Category("Custom props")]
		public Image Icon
		{
			get { return _image; }
			set { _image = value; pictureBox1.Image = _image; }
		}

		private void ListItem_MouseEnter(object sender, EventArgs e)
		{
			this.BackColor = Color.Silver;
		}

		private void ListItem_MouseLeave(object sender, EventArgs e)
		{
			this.BackColor = Color.White;
		}
	}
}
