using ServiceStationManager.ClientsToday;
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

        //Клиенты сегодня
        int i = 1;

        string timeStartRepair;

        public FormMain(int statusLogin, string loginDB, string passDB, string ipDB, string portDB)
        {
            InitializeComponent();

            toolStripBtDeleteClient.Enabled = false;

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

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }

        //Для неизвестного клиента
        private void CreateTab(UserControlClientsToday ucct)
        {
            TabPage newTabPage = new TabPage("Клиент" + i++);
            tabControl1.TabPages.Add(newTabPage);
            newTabPage.Controls.Add(ucct);
            tabControl1.SelectedTab = newTabPage;
        }

        //Для клиента из БД
        private void CreateTab(string currentClient, UserControlClientsToday ucct)
        {
            db.ShowPickedClient(currentClient, "id_client", ucct.tbIdDriver);
            db.ShowPickedClient(currentClient, "surname", ucct.tbSurnameDriver);
            db.ShowPickedClient(currentClient, "name", ucct.tbNameDriver);
            db.ShowPickedClient(currentClient, "patronimyc", ucct.tbPatronimycDriver);
            db.ShowPickedClient(currentClient, "phone_number", ucct.tbPhoneNumber);

            db.ShowPickedCar(currentClient, "number_sts", ucct.tbNumberSTSCar);
            db.ShowPickedCar(currentClient, "brand", ucct.tbBrandCar);
            db.ShowPickedCar(currentClient, "model", ucct.tbModelCar);
            db.ShowPickedCar(currentClient, "year_created", ucct.tbYearCar);

            TabPage newTabPage = new TabPage(ucct.tbNameDriver.Text + "/" + ucct.tbModelCar.Text);
            tabControl1.TabPages.Add(newTabPage);
            newTabPage.Controls.Add(ucct);
            tabControl1.SelectedTab = newTabPage;
        }

        private void toolStripBtNewClient_Click(object sender, EventArgs e)
        {
            timeStartRepair = DateTime.Now.ToString("HH:mm:ss");
            UserControlClientsToday ucct = new UserControlClientsToday(loginDB, passDB, ipDB, portDB);
            ucct.Dock = DockStyle.Fill;

            DialogResult dialogResult = MessageBox.Show("Добавить клиента из уже существующих?", "Новый клиент", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                FormPicClient fpc = new FormPicClient(loginDB, passDB, ipDB, portDB);
                fpc.ShowDialog();
                CreateTab(fpc.currentRow, ucct);
            }
            else if (dialogResult == DialogResult.No)
            {
                CreateTab(ucct);
            }
            toolStripBtDeleteClient.Enabled = true;
        }

        private void toolStripBtDeleteClient_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Завершить работу с клиентом?", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);

                if (tabControl1.TabPages.Count == 0)
                {
                    toolStripBtDeleteClient.Enabled = false;
                }

            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
    }
}
