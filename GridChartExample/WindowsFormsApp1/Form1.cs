using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
	public partial class Form1 : Form
	{
        List<SeriesChartType> chart_types = new List<SeriesChartType>();
        List<pointMy> col = new List<pointMy>();
        BindingSource bs = new BindingSource();
        BindingSource bsData = new BindingSource();
		public Form1()
		{
			InitializeComponent();
            fullChart();
            foreach (SeriesChartType suit in (SeriesChartType[])Enum.GetValues(typeof(SeriesChartType)))
            {
                chart_types.Add(suit);
            }
            bs.DataSource = chart_types;
            comboBox1.DataSource = bs;
			bs.CurrentItemChanged += Bs_CurrentItemChanged;
            bsData.DataSource = col;
            dataGridView1.DataSource = bsData;
        }

		private void Bs_CurrentItemChanged(object sender, EventArgs e)
		{
            var r = (SeriesChartType)bs.Current;
            chart1.Series[0].ChartType = r;
        }

		class pointMy
		{
            public int name { get; set; }
            public int val { get; set; }
		}

        private void fullChart()
		{
            this.chart1.Series.Clear();

            Random r = new Random();
            int date = 1;

            int total_sum = 0;

            // Data arrays
            
            for(int i = 0; i<31; i++)
			{
                int amount = r.Next(1, 5);
                col.Add(new pointMy { name = date++, val = amount });
                total_sum += amount;

            }

            // Set palette
            this.chart1.Palette = ChartColorPalette.Berry;

            // Set title
            this.chart1.Titles.Add("2021 Январь");

            Series series = this.chart1.Series.Add($"Total time: {total_sum} hrs");
            series.ChartType = SeriesChartType.Column;

            chart1.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.VariableCount;

            // Add series.
            foreach (var item in col)
			{
                series.Points.AddXY(item.name.ToString(), item.val);
			}
        }


		private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
		{
            if (this.dataGridView1.Columns["Column2"].Index ==
                    e.ColumnIndex && e.RowIndex >= 0)
            {
                Rectangle newRect = new Rectangle(e.CellBounds.X + 1,
                    e.CellBounds.Y + 1, e.CellBounds.Width - 4,
                    e.CellBounds.Height - 4);

                using (
                    Brush gridBrush = new SolidBrush(this.dataGridView1.GridColor),
                    backColorBrush = new SolidBrush(e.CellStyle.BackColor))
                {
                    using (Pen gridLinePen = new Pen(gridBrush))
                    {
                        // Erase the cell.
                        e.Graphics.FillRectangle(backColorBrush, e.CellBounds);

                        // Draw the grid lines (only the right and bottom lines;
                        // DataGridView takes care of the others).
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left,
                            e.CellBounds.Bottom - 1, e.CellBounds.Right - 1,
                            e.CellBounds.Bottom - 1);
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1,
                            e.CellBounds.Top, e.CellBounds.Right - 1,
                            e.CellBounds.Bottom);

                        // Draw the inset highlight box.
                        e.Graphics.DrawRectangle(Pens.Blue, newRect);

                        // Draw the text content of the cell, ignoring alignment.
                        if (e.Value != null)
                        {
                            e.Graphics.DrawString((String)e.Value, e.CellStyle.Font,
                                Brushes.Crimson, e.CellBounds.X + 2,
                                e.CellBounds.Y + 2, StringFormat.GenericDefault);
                        }
                        e.Handled = true;
                    }
                }
            }
        }
	}
}
