using ServiceStationManager.ClientsToday;
using ServiceStationManager.Tables;
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

        //Клиенты сегодня
        int i = 1;
        int numberTab = -1;//Номер вкладки, выделенной контекстным меню

        public FormMain(ClassDB db, int statusLogin)
        {
            InitializeComponent();

            //Подготовительные этапы (Обновление некоторых таблиц БД, и тд) - прериквизиты
            db.DisableSafeMode();//Отключаем safe mode MySQL
            db.SetStausEmployee();//Обновляем статусы для сотрудников


            //Завершение пререквизитов

            toolStripBtDeleteClient.Enabled = false;
            toolStripBtSave.Enabled = false;
            this.db = db;

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
            FormClients fclients = new FormClients(db);
            fclients.ShowDialog();
        }

        private void списокАвтомобилейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCars fcars = new FormCars(db);
            fcars.ShowDialog();
        }

        private void списокСотрудниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmployees fe = new FormEmployees(db);
            fe.ShowDialog();
        }

        private void заявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRequests fr = new FormRequests(db, tabControl1);
            fr.ShowDialog();
        }

        private void списокАкцийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormActions fa = new FormActions(db);
            fa.ShowDialog();
        }

        private void видыРемонтныхРаботToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRepairs fr = new FormRepairs(db);
            fr.ShowDialog();
        }

        private void расписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWorkHours fwh = new FormWorkHours(db);
            fwh.ShowDialog();
        }

        private void расписаниеРаботToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWorkHoursRepairs fwhr = new FormWorkHoursRepairs(db);
            fwhr.ShowDialog();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }

        //Для неизвестного клиента
        private void CreateTab()
        {
            toolStripBtSave.Enabled = true;
            TabPage newTabPage = new TabPage("Клиент" + i++);
            tabControl1.TabPages.Add(newTabPage);

            UserControlClientsToday ucct = new UserControlClientsToday(db, newTabPage);
            ucct.Dock = DockStyle.Fill;

            newTabPage.Controls.Add(ucct);
            tabControl1.SelectedTab = newTabPage;

            toolStripBtSave.Click += (sender, args) =>
            {
                if (ucct.tbSurnameDriver.Text == "" || ucct.tbNameDriver.Text == "" || ucct.tbPatronimycDriver.Text == ""
                || ucct.tbBrandCar.Text == "" || ucct.tbModelCar.Text == "" || ucct.cbYearCreated.Text == ""
                || ucct.tbNumberSTSCar.Text == "")
                {
                    MessageBox.Show("Пожалуйста, заполните все поля");
                    return;
                }

                db.UpdateOrInsertClient(ucct.idClient, ucct.tbSurnameDriver.Text, ucct.tbNameDriver.Text, ucct.tbPatronimycDriver.Text,
                    ucct.tbPhoneNumber.Text, ucct.tbBrandCar.Text, ucct.tbModelCar.Text, ucct.cbYearCreated.Text,
                    ucct.tbNumberSTSCar.Text);
                newTabPage.Text = ucct.tbNameDriver.Text + "/" + ucct.tbModelCar.Text;
                MessageBox.Show("Изменения сохранены");
            };
        }

        //Для клиента из БД
        private void CreateTab(string currentClient)
        {
            toolStripBtSave.Enabled = true;
            TabPage newTabPage = new TabPage();
            tabControl1.TabPages.Add(newTabPage);

            UserControlClientsToday ucct = new UserControlClientsToday(db, newTabPage);
            ucct.Dock = DockStyle.Fill;

            ucct.idClient = Convert.ToInt32(currentClient);
            db.ShowPickedClient(currentClient, "surname", ucct.tbSurnameDriver);
            db.ShowPickedClient(currentClient, "name", ucct.tbNameDriver);
            db.ShowPickedClient(currentClient, "patronimyc", ucct.tbPatronimycDriver);
            db.ShowPickedClient(currentClient, "phone_number", ucct.tbPhoneNumber);

            ucct.tbNumberSTSCar.Text = db.ShowPickedCar(currentClient, "number_sts");
            ucct.tbBrandCar.Text = db.ShowPickedCar(currentClient, "brand");
            ucct.tbModelCar.Text = db.ShowPickedCar(currentClient, "model");
            ucct.cbYearCreated.Text = db.ShowPickedCar(currentClient, "year_created");
            newTabPage.Controls.Add(ucct);

            newTabPage.Text = ucct.tbNameDriver.Text + "/" + ucct.tbModelCar.Text;

            tabControl1.SelectedTab = newTabPage;

            toolStripBtSave.Click += (sender, args) =>
            {
                if (ucct.tbSurnameDriver.Text == "" || ucct.tbNameDriver.Text == "" || ucct.tbPatronimycDriver.Text == ""
                || ucct.tbBrandCar.Text == "" || ucct.tbModelCar.Text == "" || ucct.cbYearCreated.Text == ""
                || ucct.tbNumberSTSCar.Text == "")
                {
                    MessageBox.Show("Пожалуйста, заполните все поля");
                    return;
                }

                db.UpdateOrInsertClient(ucct.idClient, ucct.tbSurnameDriver.Text, ucct.tbNameDriver.Text, ucct.tbPatronimycDriver.Text,
                    ucct.tbPhoneNumber.Text, ucct.tbBrandCar.Text, ucct.tbModelCar.Text, ucct.cbYearCreated.Text,
                    ucct.tbNumberSTSCar.Text);
                newTabPage.Text = ucct.tbNameDriver.Text + "/" + ucct.tbModelCar.Text;
                MessageBox.Show("Изменения сохранены");
            };
        }

        //Для продленного клиента
        private void CreateTab(string currentClient, List<int> idRepairs, int quantityDays)
        {
            toolStripBtSave.Enabled = true;
            TabPage newTabPage = new TabPage();
            tabControl1.TabPages.Add(newTabPage);

            UserControlClientsToday ucct = new UserControlClientsToday(db, newTabPage, idRepairs, quantityDays);
            ucct.Dock = DockStyle.Fill;

            ucct.idClient = Convert.ToInt32(currentClient);
            db.ShowPickedClient(currentClient, "surname", ucct.tbSurnameDriver);
            db.ShowPickedClient(currentClient, "name", ucct.tbNameDriver);
            db.ShowPickedClient(currentClient, "patronimyc", ucct.tbPatronimycDriver);
            db.ShowPickedClient(currentClient, "phone_number", ucct.tbPhoneNumber);

            ucct.tbNumberSTSCar.Text = db.ShowPickedCar(currentClient, "number_sts");
            ucct.tbBrandCar.Text = db.ShowPickedCar(currentClient, "brand");
            ucct.tbModelCar.Text = db.ShowPickedCar(currentClient, "model");
            ucct.cbYearCreated.Text = db.ShowPickedCar(currentClient, "year_created");
            newTabPage.Controls.Add(ucct);

            newTabPage.Text = ucct.tbNameDriver.Text + "/" + ucct.tbModelCar.Text;

            tabControl1.SelectedTab = newTabPage;

            toolStripBtSave.Click += (sender, args) =>
            {
                if (ucct.tbSurnameDriver.Text == "" || ucct.tbNameDriver.Text == "" || ucct.tbPatronimycDriver.Text == ""
                || ucct.tbBrandCar.Text == "" || ucct.tbModelCar.Text == "" || ucct.cbYearCreated.Text == ""
                || ucct.tbNumberSTSCar.Text == "")
                {
                    MessageBox.Show("Пожалуйста, заполните все поля");
                    return;
                }

                db.UpdateOrInsertClient(ucct.idClient, ucct.tbSurnameDriver.Text, ucct.tbNameDriver.Text, ucct.tbPatronimycDriver.Text,
                    ucct.tbPhoneNumber.Text, ucct.tbBrandCar.Text, ucct.tbModelCar.Text, ucct.cbYearCreated.Text,
                    ucct.tbNumberSTSCar.Text);
                newTabPage.Text = ucct.tbNameDriver.Text + "/" + ucct.tbModelCar.Text;
                MessageBox.Show("Изменения сохранены");
            };
        }

        private void toolStripBtNewClient_Click(object sender, EventArgs e)
        {
            if (TLPWelcome.Visible)
            {
                TLPWelcome.Visible = false;
            }

            DialogResult dialogResult = MessageBox.Show("Добавить клиента из уже существующих?", "Новый клиент", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                FormPicClient fpc = new FormPicClient(db);
                fpc.ShowDialog();
                CreateTab(fpc.currentRow);
            }
            else if (dialogResult == DialogResult.No)
            {
                CreateTab();
            }
            toolStripBtDeleteClient.Enabled = true;
        }

        private void toolStripBtDeleteClient_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Завершить работу с клиентом? Все внесённые изменения не сохранятся", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);

                if (tabControl1.TabPages.Count == 0)
                {
                    toolStripBtDeleteClient.Enabled = false;
                    toolStripBtSave.Enabled = false;
                }
            }
        }

        private void всеОтложенныеКлиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<int> idExtentionClients = new List<int>();
            List<int> idExtentionRepairs = new List<int>();
            List<int> quantityDays = new List<int>();

            db.SearchExtensionClients(idExtentionClients, idExtentionRepairs, quantityDays);
            //Логика следующего цикла - неправильна надо сделать скорее всего двойной цикл для 
            //клиентов и отдельно для отложенных работ тк их больше
            for (int i = 0; i < idExtentionClients.Count; i++)
            {
                CreateTab(idExtentionClients[i].ToString(), idExtentionRepairs, quantityDays[i]);
            }

            if (tabControl1.TabCount != 0)
            {
                toolStripBtDeleteClient.Enabled = true;
            }
        }

        private void выбратьКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPicExtensionClients fpec = new FormPicExtensionClients(db);
            fpec.ShowDialog();

            List<int> idExtensionRepairs = db.GetExtensionWorksForPickClient(fpec.currentRow);
            CreateTab(fpec.currentRow.ToString(), idExtensionRepairs, fpec.quantityDays);

            if (tabControl1.TabCount != 0)
            {
                toolStripBtDeleteClient.Enabled = true;
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp fh = new FormHelp();
            fh.ShowDialog();
        }

        private void списокВсехРаботToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPerformedRepairs fpr = new FormPerformedRepairs(db);
            fpr.ShowDialog();
        }

        private void наглядноеРасписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormViewWorkHours fvwh = new FormViewWorkHours();
            fvwh.ShowDialog();
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                for (int i = 0; i < tabControl1.TabCount; i++)
                {
                    // получаем область таба и проверяем входит ли курсор в него или нет
                    Rectangle r = tabControl1.GetTabRect(i);
                    if (r.Contains(e.Location))
                    {
                        // показываем контекстое меню и сохраняем номер таба
                        numberTab = i;
                        contextMenuTabControl.Show(tabControl1, e.Location);
                    }
                }
            }
        }

        private void ContextMenuItemDeleteClient_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Завершить работу с клиентом? Все внесённые изменения не сохранятся", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                tabControl1.TabPages.RemoveAt(numberTab);

                if (tabControl1.TabPages.Count == 0)
                {
                    toolStripBtDeleteClient.Enabled = false;
                    toolStripBtSave.Enabled = false;
                }
            }
        }
    }
}
