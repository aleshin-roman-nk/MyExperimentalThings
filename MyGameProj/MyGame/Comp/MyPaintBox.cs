using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClock
{
	public class MyPaintBox: PictureBox
	{
		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);

			DoPaint?.Invoke(pe);
		}

		public event Action<PaintEventArgs> DoPaint;
	}
}
