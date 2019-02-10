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
        //internal object clbRepairs;
        ClassDB db;
        
        public FormAddRepairForCurrentClient(string loginDB, string passDB, string ipDB, string portDB)
        {
            InitializeComponent();
            db = new ClassDB(ipDB, portDB, loginDB, passDB);
            db.SearchCategoriesRepairs(cbCategoryRepairs);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (cbNameRepairs.Text != "" && cbEmployee.Text != "")
            {
                StaticData.DataBufferNameRepair = cbNameRepairs.Text;
                StaticData.DataBufferEmployee = cbEmployee.Text;
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
    }
}
