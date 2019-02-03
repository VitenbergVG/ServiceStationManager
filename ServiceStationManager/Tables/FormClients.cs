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
    public partial class FormClients : Form
    {
        ClassDB db;
        private string loginDB;
        private string passDB;
        private string ipDB;
        private string portDB;

        public FormClients(string loginDB, string passDB, string ipDB, string portDB)
        {
            InitializeComponent();

            this.loginDB = loginDB;
            this.passDB = passDB;
            this.ipDB = ipDB;
            this.portDB = portDB;

            db = new ClassDB(ipDB, portDB, loginDB, passDB);

            dgvClients.ColumnCount = 6;
            dgvClients.Columns[0].HeaderCell.Value = "ID Клиента";
            dgvClients.Columns[1].HeaderCell.Value = "Фамилия";
            dgvClients.Columns[2].HeaderCell.Value = "Имя";
            dgvClients.Columns[3].HeaderCell.Value = "Отчество";
            dgvClients.Columns[4].HeaderCell.Value = "Мобильный телефон";
            dgvClients.Columns[5].HeaderCell.Value = "Номер СТС машины";
            db.LoadTables("clients", dgvClients);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (db.Delete("clients", "id_client", dgvClients) == 0)
            {
                MessageBox.Show("Невозможно удалить клиента, так как информация о работах с его машиной ещё числится в БД", "Ошибка");
            }
            else
            {
                dgvClients.Rows.Clear();
                db.LoadTables("clients", dgvClients);
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dgvClients.Rows.Clear();
            db.SearchInClients(tbSearch.Text, dgvClients);
        }

        private void dgvClients_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string currentRow = dgvClients.CurrentRow.Cells[0].Value.ToString();
            FormAboutCar fac = new FormAboutCar(currentRow, loginDB, passDB, ipDB, portDB);
            fac.ShowDialog();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormAddClient fAdd = new FormAddClient(loginDB, passDB, ipDB, portDB);
            fAdd.ShowDialog();
            dgvClients.Rows.Clear();
            db.LoadTables("clients", dgvClients);
        }
    }
}
