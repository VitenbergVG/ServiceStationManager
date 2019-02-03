using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceStationManager.Add
{
    public partial class FormAddRepair : Form
    {
        ClassDB db;

        public FormAddRepair(string loginDB, string passDB, string ipDB, string portDB)
        {
            InitializeComponent();

            db = new ClassDB(ipDB, portDB, loginDB, passDB);
            db.SearchPosition(cbPosition);
            db.SearchCategoriesRepairs(cbCategory);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string factQuery;
            factQuery = "(`id_repair`, `name`, `category`, `cost`, `position_position`) VALUES('" +
                      textBox1.Text + "', '" + textBox2.Text + "', '" + cbCategory.Text + "', '" + textBox4.Text + "', '" + cbPosition.Text + "');";
            db.Add("repairs", factQuery);
            this.Hide();
        }
    }
}
