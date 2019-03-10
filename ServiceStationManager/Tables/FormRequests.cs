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
    public partial class FormRequests : Form
    {
        ClassDB db;

        TabControl tabControl;

        public FormRequests(ClassDB db, TabControl tabControl)
        {
            InitializeComponent();

            this.db = db;

            this.tabControl = tabControl;

            dgvRequests.ColumnCount = 5;
            dgvRequests.Columns[0].HeaderCell.Value = "ID заявки";
            dgvRequests.Columns[1].HeaderCell.Value = "Категория";
            dgvRequests.Columns[2].HeaderCell.Value = "ID клиента";
            dgvRequests.Columns[3].HeaderCell.Value = "Описание";
            dgvRequests.Columns[4].HeaderCell.Value = "Статус обработки";
            db.LoadTables("requests", dgvRequests);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string id = dgvRequests.CurrentRow.Cells[0].Value.ToString();

            db.Delete("requests", "id_request", id);
            dgvRequests.Rows.Clear();
            db.LoadTables("requests", dgvRequests);
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            dgvRequests.Rows.Clear();
            db.LoadTables("requests", dgvRequests);
        }

        private void btRequestProcessing_Click(object sender, EventArgs e)
        {
            FormRequestProcessing frp = new FormRequestProcessing();
            frp.ShowDialog();
            


            //int id = Convert.ToInt32(dgvRequests.CurrentRow.Cells[0].Value);
            //db.Delete("requests", "id_request", id);
            

            //TabPage newTabPage = new TabPage();
            //tabControl.TabPages.Add(newTabPage);
            //UserControlClientsToday ucct = new UserControlClientsToday(db, newTabPage);
            //ucct.Dock = DockStyle.Fill;

            //string idClient = dgvRequests.CurrentRow.Cells[2].Value.ToString();
            //string categoryRepairs = dgvRequests.CurrentRow.Cells[1].Value.ToString();

            //ucct.idClient = Convert.ToInt32(idClient);
            //db.ShowPickedClient(idClient, "surname", ucct.tbSurnameDriver);
            //db.ShowPickedClient(idClient, "name", ucct.tbNameDriver);
            //db.ShowPickedClient(idClient, "patronimyc", ucct.tbPatronimycDriver);
            //db.ShowPickedClient(idClient, "phone_number", ucct.tbPhoneNumber);

            //ucct.tbNumberSTSCar.Text = db.ShowPickedCar(idClient, "number_sts");
            //ucct.tbBrandCar.Text = db.ShowPickedCar(idClient, "brand");
            //ucct.tbModelCar.Text = db.ShowPickedCar(idClient, "model");
            //ucct.cbYearCreated.Text = db.ShowPickedCar(idClient, "year_created");
            //newTabPage.Controls.Add(ucct);

            //newTabPage.Text = ucct.tbNameDriver.Text + "/" + ucct.tbModelCar.Text;

            //tabControl.SelectedTab = newTabPage;

            //Hide();

            //FormAddRepairForCurrentClient farfcc = new FormAddRepairForCurrentClient(db, categoryRepairs);
            //farfcc.ShowDialog();
            
            //if (StaticData.DataBufferNameRepair != null && StaticData.DataBufferEmployee != null)
            //{
            //    if (ucct.clbRepairs.Items.Contains(StaticData.DataBufferNameRepair))
            //    {
            //        DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите добавить уже запланированную ремонтную работу ещё раз?", "Подтверждение", MessageBoxButtons.YesNo);
            //        if (dialogResult == DialogResult.No)
            //        {
            //            return;
            //        }
            //    }

            //    //Обновление списка работ после закрытия дочерней формы
            //    ucct.clbRepairs.Items.Add(StaticData.DataBufferNameRepair);
            //    ucct.lbEmployeesRepairs.Items.Add(StaticData.DataBufferEmployee);

            //    db.SearchCostRepairs(StaticData.DataBufferNameRepair, ucct.lbRepairsCosts);

            //    int totalCost = 0;

            //    for (int i = 0; i < ucct.lbRepairsCosts.Items.Count; i++)
            //    {
            //        totalCost += Convert.ToInt32(ucct.lbRepairsCosts.Items[i].ToString());
            //    }

            //    ucct.lbRepairsTotalCost.Text = "Итоговая\nстоимость:\n" + totalCost + " рублей";

            //    ucct.toolStripProgressBarStatusRepairs.Maximum = ucct.clbRepairs.Items.Count;
            //    ucct.toolStripProgressBarStatusRepairs.Value = ucct.clbRepairs.CheckedItems.Count;
            //}
        }
    }
}
