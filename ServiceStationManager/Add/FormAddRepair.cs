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
            textBox1.Text = (db.LastRepair() + 1).ToString();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "" || cbCategory.Text == "" || cbPosition.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "Ошибка");
            }
            else
            {
                string factQuery;
                factQuery = "(`id_repair`, `name`, `category`, `cost`, `position_position`) VALUES('" +
                          textBox1.Text + "', '" + textBox2.Text + "', '" + cbCategory.Text + "', '" + textBox4.Text + "', '" + cbPosition.Text + "');";
                db.Add("repairs", factQuery);
                this.Hide();
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }
    }
}
