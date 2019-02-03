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
    public partial class FormWorkHours : Form
    {
        ClassDB db;

        private string loginDB;
        private string passDB;
        private string portDB;
        private string ipDB;

        List<DateTime> dates;
        List<int> idEmployees;
        List<string> surnameEmployees;

        public FormWorkHours(string loginDB, string passDB, string ipDB, string portDB)
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

            dgvWorkHours.ColumnCount = 14;
            dgvWorkHours.Columns[0].HeaderCell.Value = today.ToShortDateString();

            for (int i = 1; i < 14; i++)
            {
                dates.Add(today.AddDays(i));
                dgvWorkHours.Columns[i].HeaderCell.Value = dates[i].ToShortDateString();
            }

            db.WorkHoursNameEmployees(dgvWorkHours, idEmployees, surnameEmployees, dates);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormAddWorkHours fawh = new FormAddWorkHours(loginDB, passDB, ipDB, portDB, dates, surnameEmployees, idEmployees);
            fawh.ShowDialog();
            dgvWorkHours.Rows.Clear();
            RefreshTable();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int indexRow = dgvWorkHours.CurrentCell.RowIndex;
            int indexCol = dgvWorkHours.CurrentCell.ColumnIndex;

            db.DeleteFromWorkHours(idEmployees[indexRow], dates[indexCol].ToString("yyyy-MM-dd"));
            RefreshTable();
        }
    }
}
