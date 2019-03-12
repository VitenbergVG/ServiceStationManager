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
    public partial class FormEmployees : Form
    {
        ClassDB db;

        public FormEmployees(ClassDB db)
        {
            InitializeComponent();

            this.db = db;

            dgvEmployees.ColumnCount = 7;
            dgvEmployees.Columns[0].HeaderCell.Value = "ID сотрудника";
            dgvEmployees.Columns[1].HeaderCell.Value = "Фамилия";
            dgvEmployees.Columns[2].HeaderCell.Value = "Имя";
            dgvEmployees.Columns[3].HeaderCell.Value = "Отчество";
            dgvEmployees.Columns[4].HeaderCell.Value = "Мобильный телефон";
            dgvEmployees.Columns[5].HeaderCell.Value = "Должность";
            dgvEmployees.Columns[6].HeaderCell.Value = "Соредняя оценка";
            db.LoadTables("employees", dgvEmployees);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormAddEmployee fAdd = new FormAddEmployee(db);
            fAdd.ShowDialog();
            dgvEmployees.Rows.Clear();
            db.LoadTables("employees", dgvEmployees);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string id = dgvEmployees.CurrentRow.Cells[0].Value.ToString();

            if (db.Delete("employees", "id_employee", id) == 0)
            {
                MessageBox.Show("Невозможно удалить сотрудника, так как информация о его расписании или работах ещё числится в БД", "Ошибка");
            }
            else
            {
                dgvEmployees.Rows.Clear();
                db.LoadTables("employees", dgvEmployees);
            }
        }

        private void редактироватьСотрулникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string idEmployee = dgvEmployees.CurrentRow.Cells[0].Value.ToString();
            string surname = dgvEmployees.CurrentRow.Cells[1].Value.ToString();
            string name = dgvEmployees.CurrentRow.Cells[2].Value.ToString();
            string patronimyc = dgvEmployees.CurrentRow.Cells[3].Value.ToString();
            string phoneNumber = dgvEmployees.CurrentRow.Cells[4].Value.ToString();
            string position = dgvEmployees.CurrentRow.Cells[5].Value.ToString();
            string rating = dgvEmployees.CurrentRow.Cells[6].Value.ToString();

            FormAddEmployee fac = new FormAddEmployee(db, idEmployee, surname, name, patronimyc, 
                phoneNumber, position, rating);
            fac.ShowDialog();
            dgvEmployees.Rows.Clear();
            db.LoadTables("employees", dgvEmployees);
        }

        private void dgvEmployees_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvEmployees.CurrentCell = dgvEmployees.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }
    }
}
