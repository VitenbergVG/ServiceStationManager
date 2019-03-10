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
        bool edit = false;

        //Для добавления
        public FormAddCar(ClassDB db)
        {
            InitializeComponent();

            this.db = db;

            checkBoxIsDateEmpty.Checked = true;

            for (int i = DateTime.Now.Year; i >= 1970; i--)
            {
                cbYear.Items.Add(i);
            }
        }

        //Для редактирования
        public FormAddCar(ClassDB db, string numSTSCar, string brand, string model,
            string yearCreated, string dateTO)
        {
            InitializeComponent();

            edit = true;

            this.db = db;

            btAdd.Text = "Редактировать";

            tbNumSTS.Enabled = false;

            if (dateTO == "")
            {
                checkBoxIsDateEmpty.Checked = true;
            }
            else
            {
                dtpDateTO.Value = Convert.ToDateTime(dateTO);
            }

            for (int i = DateTime.Now.Year; i >= 1970; i--)
            {
                cbYear.Items.Add(i);
            }

            tbNumSTS.Text = numSTSCar;
            tbBrand.Text = brand;
            tbModel.Text = model;
            cbYear.Text = yearCreated;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string factQuery;

            if (tbNumSTS.Text == "" || tbBrand.Text == "" || tbModel.Text == "" || cbYear.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "Ошибка");
            }
            else
            {
                if (!edit)
                {
                    if (!checkBoxIsDateEmpty.Checked)
                    {
                        factQuery = "(number_sts, brand, model, year_created, date_to) VALUES('" +
                              tbNumSTS.Text.Replace(" ", "") + "', '" + tbBrand.Text + "', '" + tbModel.Text + "', '" + cbYear.Text + "', '"
                              + dtpDateTO.Value.ToString("yyyy-MM-dd") + "');";
                    }
                    else
                    {
                        factQuery = "(number_sts, brand, model, year_created) VALUES('" +
                             tbNumSTS.Text.Replace(" ", "") + "', '" + tbBrand.Text + "', '" + tbModel.Text + "', '" + cbYear.Text + "');";
                    }

                    db.Add("cars", factQuery);

                }
                else
                {
                    factQuery = "brand = '" + tbBrand.Text + "', " + "model = '" +
                    tbModel.Text + "', year_created = '" + cbYear.Text + "', date_to = '"
                    + dtpDateTO.Value.ToString("yyyy-MM-dd") + "'";

                    db.Edit("cars", "number_sts", tbNumSTS.Text.Replace(" ", ""), factQuery);
                }

                Hide();
            }
        }

        private void tbNumSTS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back && (e.KeyChar != (char)Keys.Delete)))
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
