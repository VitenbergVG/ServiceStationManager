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
    public partial class FormAddWorkHoursRepair : Form
    {
        ClassDB db;

        private string loginDB;
        private string passDB;
        private string portDB;
        private string ipDB;

        int idRepair;
        int idClient;
        int idWorkHours;

        public FormAddWorkHoursRepair(string loginDB, string passDB, string ipDB, string portDB)
        {
            InitializeComponent();

            this.loginDB = loginDB;
            this.passDB = passDB;
            this.ipDB = ipDB;
            this.portDB = portDB;

            db = new ClassDB(ipDB, portDB, loginDB, passDB);

            db.SearchCategoriesRepairs(cbCategoryRepair);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string factQuery;
            factQuery = "(`work_hours_id_work_hours`, `repairs_id_repair`, `clients_id_client`, `time_start`, `time_finish`) VALUES('" +
                       idWorkHours + "', '" + idRepair + "', '" + idClient + "', '" + textBox4.Text + "', '" + textBox5.Text + "');";
            db.Add("current_repairs", factQuery);
            Hide();
        }

        private void btPicClient_Click(object sender, EventArgs e)
        {
            FormPicClient fpc = new FormPicClient(loginDB, passDB, ipDB, portDB);
            fpc.ShowDialog();
            labelClient.Text = fpc.currentRow;
            idClient = Convert.ToInt32(fpc.currentRow);
        }

        private void cbCategoryRepair_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbNameRepair.Items.Clear();
            db.SearchNameRepairs(cbCategoryRepair.Text.ToString(), cbNameRepair);
        }

        private void cbNameRepair_SelectedIndexChanged(object sender, EventArgs e)
        {
            idRepair = db.SearchIdRepairs(cbNameRepair.Text.ToString());
        }

        private void btPicWorkHours_Click(object sender, EventArgs e)
        {
            FormPicWorkHours fpwh = new FormPicWorkHours(loginDB, passDB, ipDB, portDB);
            fpwh.ShowDialog();
            labelWorkHours.Text = fpwh.currentRow;
            idWorkHours = Convert.ToInt32(fpwh.currentRow);
        }
    }
}
