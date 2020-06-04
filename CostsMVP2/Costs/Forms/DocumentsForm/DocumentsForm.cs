using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Показ элементов только одного чека.
 * 
 * Все вводы от юзера, логика UI ввода может размещаться в view отделе. Именно на внесение данных, изменений состояния данных
 *		отправляется в модель.
 *		Это означает, главный view не должен обращаться к презентеру чтобы ввести строку.
 *		Попробовать реализовать эту идею.
 * 
 * 
 */

namespace Costs.Forms.PayDocumentsForm
{
	public partial class PayDocForm : Form
	{
		public PayDocForm()
		{
			InitializeComponent();
		}
	}
}
