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
    public partial class FormAddEmployee : Form
    {
        ClassDB db;
        bool edit = false;
        string idEmployee;

        public FormAddEmployee(ClassDB db)
        {
            InitializeComponent();
            this.db = db;
            db.SearchPosition(cbPosition);
        }

        public FormAddEmployee(ClassDB db, string idEmployee, string surname, string name, string patronimyc,
            string phoneNumber, string position, string rating)
        {
            InitializeComponent();
            this.db = db;
            edit = true;
            db.SearchPosition(cbPosition);
            tbRating.Enabled = true;

            this.idEmployee = idEmployee;
            tbSurname.Text = surname;
            tbName.Text = name;
            tbPatronimyc.Text = patronimyc;
            tbPhone.Text = phoneNumber;
            cbPosition.Text = position;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbSurname.Text == "" || tbName.Text == "" || tbPatronimyc.Text == "" || tbPhone.Text == "" || cbPosition.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "Ошибка");
            }
            else
            {
                string factQuery;
                if (!edit)
                {
                    factQuery = "(`surname`, `name`, `patronimyc`, `phone_number`,`position_position`, " +
                        "`rating`) VALUES('" + tbSurname.Text + "', '" + tbName.Text + "', '" +
                        tbPatronimyc.Text + "', '" +
                            tbPhone.Text.Replace(" ", "").Replace("(", "").Replace(")", "") + "', '" + cbPosition.Text + "', '" + tbRating.Text + "');";
                    db.Add("employees", factQuery);
                }
                else
                {
                    factQuery = "`surname` = '" + tbSurname.Text + "', `name` = '" + tbName.Text + "', `patronimyc` = '" +
                        tbPatronimyc.Text + "', `phone_number` = '" + tbPhone.Text.Replace(" ", "").Replace("(", "").Replace(")", "")
                        + "',`position_position` = '" + cbPosition.Text + "', `rating` = '" + tbRating.Text + "'";
                    db.Edit("employees", "id_employee", idEmployee, factQuery);
                }

                Hide();
            }
        }
    }
}
