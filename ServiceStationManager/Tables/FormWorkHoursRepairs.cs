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

        List<DateTime> dates;
        List<int> idEmployees;
        List<string> surnameEmployees;

        public FormWorkHoursRepairs(ClassDB db)
        {
            InitializeComponent();

            this.db = db;

            RefreshTable();
        }


        private void RefreshTable()
        {
            dgvWorkHoursRepairs.Rows.Clear();
            dates = new List<DateTime>();//Список дат
            idEmployees = new List<int>();//Список id сотрудников
            surnameEmployees = new List<string>();//Список фамилий сотрудников

            DateTime today = DateTime.Today;

            dgvWorkHoursRepairs.ColumnCount = 21;

            for (int i = -7; i < 14; i++)
            {
                dates.Add(today.AddDays(i));
            }

            for (int i = 0; i < 21; i++)
            {
                dgvWorkHoursRepairs.Columns[i].HeaderCell.Value = dates[i].ToShortDateString();
            }

            db.WorkHoursRepairsNameEmployees(dgvWorkHoursRepairs, idEmployees, surnameEmployees, dates);

            dgvWorkHoursRepairs.FirstDisplayedCell = dgvWorkHoursRepairs.Rows[0].Cells[7];
            dgvWorkHoursRepairs.CurrentCell = dgvWorkHoursRepairs.Rows[0].Cells[7];
            dgvWorkHoursRepairs.Columns[7].DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormAddWorkHoursRepair fawh = new FormAddWorkHoursRepair(db);
            fawh.ShowDialog();
            RefreshTable();
        }

        private void dgvWorkHoursRepairs_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string surnameEmployee = dgvWorkHoursRepairs.Rows[dgvWorkHoursRepairs.CurrentCell.RowIndex].HeaderCell.Value.ToString();
            DateTime date = Convert.ToDateTime(dgvWorkHoursRepairs.Columns[dgvWorkHoursRepairs.CurrentCell.ColumnIndex].HeaderText.ToString());
            string strDate = date.ToString("yyyy-MM-dd");

            FormAboutCurrentRepair facr = new FormAboutCurrentRepair(db, surnameEmployee, strDate);
            facr.ShowDialog();
            RefreshTable();
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
