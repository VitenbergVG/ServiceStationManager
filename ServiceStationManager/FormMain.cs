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
    public partial class FormMain : Form
    {
        //StatusLogin
        const int ADMIN = 1;
        const int USER = 2;

        ClassDB db;

        private string loginDB;
        private string passDB;
        private string portDB;
        private string ipDB;

        public FormMain(int statusLogin, string loginDB, string passDB, string ipDB, string portDB)
        {
            InitializeComponent();

            this.loginDB = loginDB;
            this.passDB = passDB;
            this.ipDB = ipDB;
            this.portDB = portDB;

            db = new ClassDB(ipDB, portDB, loginDB, passDB);

            if (statusLogin == USER)
            {
                Text = "Система управления станцией технического обслуживания (Вы вошли как Штатный сотрудник)";
                списокСотрудниковToolStripMenuItem.Enabled = false;
                списокАкцийToolStripMenuItem.Enabled = false;
                расписаниеToolStripMenuItem.Enabled = false;
            }

            if (statusLogin == ADMIN)
            {
                Text = "Система управления станцией технического обслуживания (Вы вошли как Администратор)";
            }
        }

        private void списокКлиентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClients fclients = new FormClients(loginDB, passDB, ipDB, portDB);
            fclients.ShowDialog();
        }

        private void списокАвтомобилейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCars fcars = new FormCars(loginDB, passDB, ipDB, portDB);
            fcars.ShowDialog();
        }

        private void списокСотрудниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmployees fe = new FormEmployees(loginDB, passDB, ipDB, portDB);
            fe.ShowDialog();
        }

        private void заявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRequests fr = new FormRequests(loginDB, passDB, ipDB, portDB);
            fr.ShowDialog();
        }

        private void списокАкцийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormActions fa = new FormActions(loginDB, passDB, ipDB, portDB);
            fa.ShowDialog();
        }

        private void видыРемонтныхРаботToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRepairs fr = new FormRepairs(loginDB, passDB, ipDB, portDB);
            fr.ShowDialog();
        }

        private void расписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWorkHours fwh = new FormWorkHours(loginDB, passDB, ipDB, portDB);
            fwh.ShowDialog();
        }

        private void расписаниеРаботToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWorkHoursRepairs fwhr = new FormWorkHoursRepairs(loginDB, passDB, ipDB, portDB);
            fwhr.ShowDialog();
        }
    }
}
