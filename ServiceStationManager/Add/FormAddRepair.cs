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
        bool edit = false;

        public FormAddRepair(ClassDB db)
        {
            InitializeComponent();

            this.db = db;
            db.SearchPosition(cbPosition);
            db.SearchCategoriesRepairs(cbCategory);
            tbIDRepair.Text = (db.LastRepair() + 1).ToString();
        }

        public FormAddRepair(ClassDB db, string idRepair, string name, string category,
            string cost, string position)
        {
            InitializeComponent();

            this.db = db;
            edit = true;

            db.SearchPosition(cbPosition);
            db.SearchCategoriesRepairs(cbCategory);

            tbIDRepair.Enabled = false;

            tbIDRepair.Text = idRepair;
            tbName.Text = name;
            cbCategory.Text = category;
            tbCost.Text = cost;
            cbPosition.Text = position;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbIDRepair.Text == "" || tbName.Text == "" || tbCost.Text == "" || cbCategory.Text == "" || cbPosition.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "Ошибка");
            }
            else
            {
                string factQuery;

                if (!edit)
                {
                    factQuery = "(`id_repair`, `name`, `category`, `cost`, `position_position`) VALUES('" +
                            tbIDRepair.Text + "', '" + tbName.Text + "', '" + cbCategory.Text + "', '" + tbCost.Text + "', '" + cbPosition.Text + "');";
                    db.Add("repairs", factQuery);
                }
                else
                {
                    factQuery = "`name` = '" + tbName.Text + "', `category` = '" + cbCategory.Text + "', " +
                        "`cost` = '"+ tbCost.Text + "', `position_position` = '"+ cbPosition.Text + "'";
                    db.Edit("repairs", "id_repair", tbIDRepair.Text, factQuery);
                }

                Hide();
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
