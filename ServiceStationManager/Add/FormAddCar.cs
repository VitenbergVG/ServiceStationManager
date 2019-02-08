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
    public partial class FormAddCar : Form
    {
        ClassDB db;

        public FormAddCar(string loginDB, string passDB, string ipDB, string portDB)
        {
            InitializeComponent();

            db = new ClassDB(ipDB, portDB, loginDB, passDB);

            checkBoxIsDateEmpty.Checked = true;

            for (int i = DateTime.Now.Year; i >= 1970; i--)
            {
                cbYear.Items.Add(i);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbNumSTS.Text == "" || tbBrand.Text == "" || tbModel.Text == "" || cbYear.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "Ошибка");
            }
            else
            {
                string factQuery;

                if (!checkBoxIsDateEmpty.Checked)
                {
                    factQuery = "(number_sts, brand, model, year_created, date_to) VALUES('" +
                          tbNumSTS.Text + "', '" + tbBrand.Text + "', '" + tbModel.Text + "', '" + cbYear.Text + "', '"
                          + dtpDateTO.Value.ToString("yyyy-MM-dd") + "');";
                }
                else
                {
                    factQuery = "(number_sts, brand, model, year_created) VALUES('" +
                         tbNumSTS.Text + "', '" + tbBrand.Text + "', '" + tbModel.Text + "', '" + cbYear.Text + "');";
                }

                db.Add("cars", factQuery);
                Hide();
            }

        }

        private void tbNumSTS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void checkBoxIsDateEmpty_CheckedChanged(object sender, EventArgs e)
        {
            dtpDateTO.Enabled = !checkBoxIsDateEmpty.Checked;
        }
    }
}
