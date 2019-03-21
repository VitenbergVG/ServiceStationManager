using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceStationManager
{
    public partial class FormViewWorkHours : Form
    {
        public FormViewWorkHours()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            Pen penBlack = new Pen(Color.Black);

            if ((e.Column == 0 || e.Column == 1) && e.Row == 0)
            {
                e.Graphics.FillRectangle(Brushes.Green, e.CellBounds);
                e.Graphics.DrawRectangle(penBlack, e.CellBounds);
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString("Электрик", new Font("Times", 15), Brushes.Black, e.CellBounds, sf);
            }
            else if (e.Column == 2 && e.Row == 0)
            {
                e.Graphics.FillRectangle(Brushes.Orange, e.CellBounds);
                e.Graphics.DrawRectangle(penBlack, e.CellBounds);
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString("Маляр\nПодборщик краски", new Font("Times", 15), Brushes.Black, e.CellBounds, sf);
            }
            else if (e.Column == 0 && e.Row == 1)
            {
                e.Graphics.FillRectangle(Brushes.Aqua, e.CellBounds);
                e.Graphics.DrawRectangle(penBlack, e.CellBounds);
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString("Диагност", new Font("Times", 15), Brushes.Black, e.CellBounds, sf);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.Brown, e.CellBounds);
                e.Graphics.DrawRectangle(penBlack, e.CellBounds);
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                e.Graphics.DrawString("Слесарь", new Font("Times", 15), Brushes.Black, e.CellBounds, sf);
            }
        }
    }
}
