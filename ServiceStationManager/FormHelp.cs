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
    public partial class FormHelp : Form
    {
        int currentIndex = 0;
        List<Image> listHelpImages = new List<Image>();//Список справочных изображений
        public FormHelp()
        {
            InitializeComponent();
            listHelpImages.Add(Properties.Resources.Help1);
            listHelpImages.Add(Properties.Resources.disk_multiple);
            listHelpImages.Add(Properties.Resources.help);
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = listHelpImages[currentIndex++];
        }

        private void btPrev_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = listHelpImages[currentIndex--];
        }
    }
}
