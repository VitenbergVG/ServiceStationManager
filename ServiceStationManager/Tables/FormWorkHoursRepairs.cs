using ServiceStationManager.Add;
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
    public partial class FormWorkHoursRepairs : Form
    {
        ClassDB db;

        private string loginDB;
        private string passDB;
        private string portDB;
        private string ipDB;

        List<DateTime> dates;
        List<int> idEmployees;
        List<string> surnameEmployees;

        public FormWorkHoursRepairs(string loginDB, string passDB, string ipDB, string portDB)
        {
            InitializeComponent();

            this.loginDB = loginDB;
            this.passDB = passDB;
            this.ipDB = ipDB;
            this.portDB = portDB;

            db = new ClassDB(ipDB, portDB, loginDB, passDB);

            RefreshTable();
        }


        private void RefreshTable()
        {
            dates = new List<DateTime>();//Список дат
            idEmployees = new List<int>();//Список id сотрудников
            surnameEmployees = new List<string>();//Список фамилий сотрудников

            DateTime today = DateTime.Today;

            dates.Add(today);

            dgvWorkHoursRepairs.ColumnCount = 14;
            dgvWorkHoursRepairs.Columns[0].HeaderCell.Value = today.ToShortDateString();

            for (int i = 1; i < 14; i++)
            {
                dates.Add(today.AddDays(i));
                dgvWorkHoursRepairs.Columns[i].HeaderCell.Value = dates[i].ToShortDateString();
            }

            db.WorkHoursRepairsNameEmployees(dgvWorkHoursRepairs, idEmployees, surnameEmployees, dates);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormAddWorkHoursRepair fawh = new FormAddWorkHoursRepair(loginDB, passDB, ipDB, portDB);
            fawh.ShowDialog();
            dgvWorkHoursRepairs.Rows.Clear();
            RefreshTable();
        }

        private void dgvWorkHoursRepairs_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string surnameEmployee = dgvWorkHoursRepairs.Rows[dgvWorkHoursRepairs.CurrentCell.RowIndex].HeaderCell.Value.ToString();
            DateTime date = Convert.ToDateTime(dgvWorkHoursRepairs.Columns[dgvWorkHoursRepairs.CurrentCell.ColumnIndex].HeaderText.ToString());
            string strDate = date.ToString("yyyy-MM-dd");

            FormAboutCurrentRepair facr = new FormAboutCurrentRepair(loginDB, passDB, ipDB, portDB, surnameEmployee, strDate);
            facr.ShowDialog();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить всю рабочую смену " +
                "выбранного сотрудника и все ремонтные работы, выполненные им в эту смену?", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int indexRow = dgvWorkHoursRepairs.CurrentCell.RowIndex;
                int indexCol = dgvWorkHoursRepairs.CurrentCell.ColumnIndex;

                db.DeleteFromWorkHours(idEmployees[indexRow], dates[indexCol].ToString("yyyy-MM-dd"));

                RefreshTable();
            }


        }
    }
}
