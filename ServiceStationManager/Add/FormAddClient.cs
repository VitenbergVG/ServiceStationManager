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
    public partial class FormAddClient : Form
    {
        ClassDB db;

        public FormAddClient(ClassDB db)
        {
            InitializeComponent();
            this.db = db;
            db.SearchSTSCars(cbNumSTS);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || cbNumSTS.Text =="")
            {
                 MessageBox.Show("Заполните все поля!", "Ошибка");
            }
            else
            {
                string factQuery;
                factQuery = "(surname, name, patronimyc, phone_number, cars_number_sts) VALUES('" +
                          textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + cbNumSTS.Text + "');";
                db.Add("clients", factQuery);
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
    }
}
