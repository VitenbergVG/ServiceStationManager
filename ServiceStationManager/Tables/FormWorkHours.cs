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

        List<DateTime> dates;
        List<int> idEmployees;
        List<string> surnameEmployees;

        public FormWorkHours(ClassDB db)
        {
            InitializeComponent();

            this.db = db;

            RefreshTable();
        }

        private void RefreshTable()
        {
            dates = new List<DateTime>();//Список дат
            idEmployees = new List<int>();//Список id сотрудников
            surnameEmployees = new List<string>();//Список фамилий сотрудников

            DateTime today = DateTime.Today;

            dgvWorkHours.ColumnCount = 21;

            for (int i = -7; i < 14; i++)
            {
                dates.Add(today.AddDays(i));
            }

            for (int i = 0; i < 21; i++)
            {
                dgvWorkHours.Columns[i].HeaderCell.Value = dates[i].ToShortDateString();
            }

            db.WorkHoursNameEmployees(dgvWorkHours, idEmployees, surnameEmployees, dates);

            dgvWorkHours.FirstDisplayedCell = dgvWorkHours.Rows[0].Cells[7];
            dgvWorkHours.CurrentCell = dgvWorkHours.Rows[0].Cells[7];
            dgvWorkHours.Columns[7].DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormAddWorkHours fawh = new FormAddWorkHours(db, dates, surnameEmployees, idEmployees);
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
