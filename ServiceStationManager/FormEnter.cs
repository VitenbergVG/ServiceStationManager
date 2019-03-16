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
            if (tbIP.Text == "" || tbLogin.Text == "" || tbLoginDB.Text == "" || tbPass.Text == "" || tbPassDB.Text == "" || tbPort.Text == "")
            {
                MessageBox.Show("Неверно указаны данные для подключения к БД", "Ошибка");
                error = true;
            }
            else
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
                    Hide();
                    switch (tbLogin.Text)
                    {
                        case "admin":
                            if (tbPass.Text == "admin")
                            {
                                statusLogin = ADMIN;
                                FormMain fmAdmin = new FormMain(db, statusLogin);
                                fmAdmin.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Введены неверные данные", "Ошибка");
                            }
                            break;

                        case "user":
                            statusLogin = USER;
                            FormMain fmUser = new FormMain(db, statusLogin);

                            fmUser.ShowDialog();
                            break;

                        default:
                            MessageBox.Show("Введены неверные данные");
                            break;
                    }
                }
            }
        }

        private void tbPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            Application.Exit();
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp fh = new FormHelp();
            fh.ShowDialog();
        }

        private void запуститьПрограммуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            notifyIcon1.Visible = false;

            FormEnter fe = new FormEnter();
            if (!fe.Visible)
            {
                fe.ShowDialog();
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Hide();
            notifyIcon1.Visible = false;

            FormEnter fe = new FormEnter();
            if (!fe.Visible)
            {
                fe.ShowDialog();
            }
        }
    }
}
