using DrRomic.BL;
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

namespace DrRomic
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

			panelController.OnMessage += PanelController_Message;
			panelController.OnRequest += PanelController_Request;
		}

		private void PanelController_Request(Requset obj)
		{
			OnRequest?.Invoke(obj);
		}

		public event Action<string> OnMessage;
		public event Action<Requset> OnRequest;

		public void SetText(string msg)
		{
		}

		private void PanelController_Message(string obj)
		{
			OnMessage?.Invoke(obj);
		}

		public void Init()
		{
			panelController.TurnFirst();
		}
	}
}
