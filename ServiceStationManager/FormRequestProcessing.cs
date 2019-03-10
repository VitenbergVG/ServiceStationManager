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
    public partial class FormRequestProcessing : Form
    {
        public FormRequestProcessing()
        {
            InitializeComponent();
        }

        private void btRequestProcessing_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void rbDatePic_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDatePic.Checked)
            {
                dateTimePicker1.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
                toolStripStatusLabelDate.Text = "Сегодня";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            toolStripStatusLabelDate.Text = dateTimePicker1.Text;
        }
    }
}
