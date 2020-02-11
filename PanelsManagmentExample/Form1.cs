using PanelsManagmentExample.BL;
using PanelsManagmentExample.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelsManagmentExample
{
	public partial class Form1 : Form, IMainView
	{
		PanelController panelController;

		public Form1()
		{
			InitializeComponent();

			panelController = new PanelController();
			panelController.SetGridPanel(gridPanel1);
			panelController.Add(yearPanel1);
			panelController.Add(monthPanel1);

			panelController.Message += PanelController_Message;
			panelController.Request += PanelController_Request;

			
		}

		private void PanelController_Request(ReqData obj)
		{
			Request?.Invoke(obj);
		}

		public event Action<string> Message;
		public event Action<ReqData> Request;

		public void SetText(string msg)
		{
			txtOut.Text = msg;
			//textBox1.AppendText($"{msg}{Environment.NewLine}");
		}

		private void PanelController_Message(string obj)
		{
			Message?.Invoke(obj);
		}

		public void Init()
		{
			panelController.TurnFirst();
		}
	}
}
