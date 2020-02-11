using PanelsManagmentExample.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanelsManagmentExample.Panels
{
	public class PanelController
	{
		IGridPanel gridPanel;
		List<IPanel> panels = new List<IPanel>();
		int pos = 0;

		public event Action<string> Message;
		public event Action<ReqData> Request;

		public void SetGridPanel(IGridPanel gp)
		{
			gridPanel = gp;
			gridPanel.Next += GridPanel_Next;
			gridPanel.Back += GridPanel_Back;
		}
		public void Add(IPanel panel)
		{
			panel.Message += Panel_Message;
			panel.Request += Panel_Request;
			panel.Hide();
			panels.Add(panel);
		}

		public void TurnFirst()
		{
			pos = 0;
			ClearGridPanel();
			ActivateCurrent();
		}

		private void Panel_Request(ReqData obj)
		{
			Request?.Invoke(obj);
		}

		private void Panel_Message(string obj)
		{
			Message?.Invoke(obj);
		}

		private void GridPanel_Back()
		{
			TurnBack();
		}

		private void GridPanel_Next()
		{
			TurnNext();
		}
		private bool CanTurnNext { get { return pos < panels.Count - 1; } }
		private bool CanTurnPrev { get { return pos > 0; } }
		private void Next()
		{
			if (pos == panels.Count - 1) return;
			pos++;
		}

		private void Prev()
		{
			if (pos == 0) return;
			pos--;
		}

		private void ActivateCurrent()
		{
			if (panels.Count == 0) return;
			panels[pos].Activate(gridPanel);
			panels[pos].Show();
		}

		private void LeaveCurrent()
		{
			if (panels.Count == 0) return;
			panels[pos].Leave();
			panels[pos].Hide();
		}

		private void LoseCurrent()
		{
			if (panels.Count == 0) return;
			panels[pos].Lose();
			panels[pos].Hide();
		}

		private void ClearGridPanel()
		{
			gridPanel.Clear();
		}

		private void TurnNext()
		{
			if (!CanTurnNext) return;
			LeaveCurrent();
			Next();
			ClearGridPanel();
			ActivateCurrent();
		}

		private void TurnBack()
		{
			if (!CanTurnPrev) return;
			LoseCurrent();
			Prev();
			ClearGridPanel();
			ActivateCurrent();
		}
	}
}
