using MySql.Data.MySqlClient;
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
    public partial class FormEnter : Form
    {
        int statusLogin = 0;

        const int ADMIN = 1;
        const int USER = 2;

        bool error = false;

        ClassDB db;

        public FormEnter()
        {
            InitializeComponent();
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            db = new ClassDB(tbIP.Text, tbPort.Text, tbLoginDB.Text, tbPassDB.Text);
            try
            {
                MySqlConnection testConnect = db.conn;
                testConnect.Open();
                testConnect.Close();
                error = false;
            }
            catch
            {
                MessageBox.Show("Неверно указаны данные для подключения к БД", "Ошибка");
                error = true;
            }

            if (!error)
            {
                switch (tbLogin.Text)
                {
                    case "admin":
                        if (tbPass.Text == "admin")
                        {
                            statusLogin = ADMIN;
                            FormMain fmAdmin = new FormMain(statusLogin, tbLoginDB.Text, tbPassDB.Text, tbIP.Text, tbPort.Text);
                            fmAdmin.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Введены неверные данные", "Ошибка");
                        }
                        break;

                    case "user":
                        statusLogin = USER;
                        FormMain fmUser = new FormMain(statusLogin, tbLoginDB.Text, tbPassDB.Text, tbIP.Text, tbPort.Text);

                        fmUser.ShowDialog();
                        break;

                    default:
                        MessageBox.Show("Введены неверные данные");
                        break;
                }
            }
        }
    }
}
