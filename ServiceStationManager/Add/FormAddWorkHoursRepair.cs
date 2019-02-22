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

        int idRepair = -1;
        int idClient = -1;
        int idWorkHours = -1;

        public FormAddWorkHoursRepair(ClassDB db)
        {
            InitializeComponent();

            this.db = db;

            db.SearchCategoriesRepairs(cbCategoryRepair);
            cbStatusRepair.SelectedIndex = 0;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (idWorkHours == -1 || cbCategoryRepair.Text == "" || idRepair == -1 || idClient == -1)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка");
            }
            else
            {
                string factQuery;

                if (!cbTimeStartIsEmpty.Checked && !cbTimeFinishIsEmpty.Checked)
                {
                    factQuery = "(`work_hours_id_work_hours`, `repairs_id_repair`, `clients_id_client`, " +
                        "`time_start`, `time_finish`, `status_repair`) " +
                        "VALUES('" + idWorkHours + "', '" + idRepair + "', '" + idClient + "', '" + 
                        dtpStart.Text + "', '" + dtpFinish.Text + "', '" + cbStatusRepair.Text + "');";
                }
                else if (cbTimeStartIsEmpty.Checked && !cbTimeFinishIsEmpty.Checked)
                {
                    factQuery = "(`work_hours_id_work_hours`, `repairs_id_repair`, `clients_id_client`, " +
                        "`time_finish`, `status_repair`) " +
                        "VALUES('" + idWorkHours + "', '" + idRepair + "', '" + idClient + "', '" + 
                        dtpFinish.Text + "', '" + cbStatusRepair.Text + "');";
                }
                else
                {
                    factQuery = "(`work_hours_id_work_hours`, `repairs_id_repair`, `clients_id_client`, " +
                        "`time_start`, `status_repair`) " +
                        "VALUES('" + idWorkHours + "', '" + idRepair + "', '" + idClient + "', '" + 
                        dtpStart.Text + "', '" + cbStatusRepair.Text + "');";
                }

                db.Add("current_repairs", factQuery);
                Hide();
            }
        }

        private void btPicClient_Click(object sender, EventArgs e)
        {
            FormPicClient fpc = new FormPicClient(db);
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
            FormPicWorkHours fpwh = new FormPicWorkHours(db);
            fpwh.ShowDialog();
            labelWorkHours.Text = fpwh.currentRow;
            idWorkHours = Convert.ToInt32(fpwh.currentRow);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dtpStart.Enabled = !cbTimeStartIsEmpty.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dtpFinish.Enabled = !cbTimeFinishIsEmpty.Checked;
        }
    }
}
