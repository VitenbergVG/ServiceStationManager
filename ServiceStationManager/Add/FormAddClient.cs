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
        bool edit = false;
        string idClient;

        public FormAddClient(ClassDB db)
        {
            InitializeComponent();
            this.db = db;
            db.SearchSTSCars(cbNumSTS);
        }

        public FormAddClient(ClassDB db, string idClient, string surname, string name,
            string patronimyc, string phone, string numSTS)
        {
            InitializeComponent();
            edit = true;
            this.db = db;
            db.SearchSTSCars(cbNumSTS);

            this.idClient = idClient;
            tbSurname.Text = surname;
            tbName.Text = name;
            tbPatronimyc.Text = patronimyc;
            tbPhone.Text = phone;
            cbNumSTS.Text = numSTS;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string factQuery;

            if (tbSurname.Text == "" || tbName.Text == "" || tbPatronimyc.Text == "" || tbPhone.Text == "" || cbNumSTS.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "Ошибка");
            }
            else
            {
                if (!edit)
                {
                    factQuery = "(surname, name, patronimyc, phone_number, cars_number_sts) VALUES('" +
                                          tbSurname.Text + "', '" + tbName.Text + "', '" + tbPatronimyc.Text + "', '" +
                                          tbPhone.Text.Replace(" ", "").Replace("(", "").Replace(")", "") + "', '" + cbNumSTS.Text + "');";
                    db.Add("clients", factQuery);

                }
                else
                {
                    factQuery = "surname = '" + tbSurname.Text + "', name = '" + tbName.Text + "', " +
                        "patronimyc = '" + tbPatronimyc.Text + "', phone_number = '" +
                        tbPhone.Text.Replace(" ", "").Replace("(", "").Replace(")", "") +
                        "', cars_number_sts = '" + cbNumSTS.Text + "'";
                    db.Edit("clients", "id_client", idClient, factQuery);
                }

                Hide();
            }
        }
    }
}
