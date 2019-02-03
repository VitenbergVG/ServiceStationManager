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

        private string loginDB;
        private string passDB;
        private string ipDB;
        private string portDB;

        public FormEmployees(string loginDB, string passDB, string ipDB, string portDB)
        {
            InitializeComponent();

            this.loginDB = loginDB;
            this.passDB = passDB;
            this.ipDB = ipDB;
            this.portDB = portDB;

            db = new ClassDB(ipDB, portDB, loginDB, passDB);

            dgvEmployees.ColumnCount = 6;
            dgvEmployees.Columns[0].HeaderCell.Value = "ID сотрудника";
            dgvEmployees.Columns[1].HeaderCell.Value = "Фамилия";
            dgvEmployees.Columns[2].HeaderCell.Value = "Имя";
            dgvEmployees.Columns[3].HeaderCell.Value = "Отчество";
            dgvEmployees.Columns[4].HeaderCell.Value = "Мобильный телефон";
            dgvEmployees.Columns[5].HeaderCell.Value = "Должность";
            db.LoadTables("employees", dgvEmployees);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormAddEmployee fAdd = new FormAddEmployee(loginDB, passDB, ipDB, portDB);
            fAdd.ShowDialog();
            dgvEmployees.Rows.Clear();
            db.LoadTables("employees", dgvEmployees);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (db.Delete("employees", "id_employee", dgvEmployees) == 0)
            {
                MessageBox.Show("Невозможно удалить сотрудника, так как информация о его расписании или работах ещё числится в БД", "Ошибка");
            }
            else
            {
                dgvEmployees.Rows.Clear();
                db.LoadTables("employees", dgvEmployees);
            }
        }
    }
}
