using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PanelControllerExp02.Panels
{
	public class PanelController
	{
		public Panel ContainerPanels { get; set; }

		LinkedList<UserControl> userControls = new LinkedList<UserControl>();

		public PanelController()
		{

		}

		PanelA panelA = new PanelA();
		PanelB panelB = new PanelB();
	}
}
