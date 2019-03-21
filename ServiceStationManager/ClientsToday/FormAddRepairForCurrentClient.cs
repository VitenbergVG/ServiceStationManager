using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceStationManager.ClientsToday
{
    public partial class FormAddRepairForCurrentClient : Form
    {
        ClassDB db;
        
        public FormAddRepairForCurrentClient(ClassDB db)
        {
            InitializeComponent();
            this.db = db;
            db.SearchCategoriesRepairs(cbCategoryRepairs);
        }

        public FormAddRepairForCurrentClient(ClassDB db, string categoryRepairs)
        {
            InitializeComponent();
            this.db = db;
            db.SearchCategoriesRepairs(cbCategoryRepairs);
            cbCategoryRepairs.Text = categoryRepairs;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (cbNameRepairs.Text != "" && cbEmployee.Text != "")
            {
                StaticData.DataBufferNameRepair = cbNameRepairs.Text;
                StaticData.DataBufferEmployee = cbEmployee.Text;
                StaticData.DataBufferQuantityDays = Convert.ToInt32(nudQuantityDays.Value);
                Hide();
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка");
            }
        }

        private void cbCategoryRepairs_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbNameRepairs.Items.Clear();
            db.SearchNameRepairs(cbCategoryRepairs.Text.ToString(), cbNameRepairs);
        }

        private void cbNameRepairs_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbEmployee.Items.Clear();
            db.SearchSurnameEmployeesForRepair(cbEmployee, cbNameRepairs.Text.ToString());
        }

        private void FormAddRepairForCurrentClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            StaticData.DataBufferNameRepair = null;
            StaticData.DataBufferEmployee = null;
            StaticData.DataBufferQuantityDays = 0;
        }
    }
}
