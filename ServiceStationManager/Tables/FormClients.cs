using ServiceStationManager.Tables;
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
        public FormClients(ClassDB db)
        {
            InitializeComponent();

            this.db = db;

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
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить клиента?", "Система управления СТО", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string id = dgvClients.CurrentRow.Cells[0].Value.ToString();

                if (db.Delete("clients", "id_client", id) == 0)
                {
                    MessageBox.Show("Невозможно удалить клиента, так как информация о работах с его машиной ещё числится в БД", "Система управления СТО", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dgvClients.Rows.Clear();
                    db.LoadTables("clients", dgvClients);
                }
            }

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dgvClients.Rows.Clear();
            db.SearchInClients(toolStripTBSearch.Text, dgvClients);
        }

        private void dgvClients_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string currentRow = dgvClients.CurrentRow.Cells[0].Value.ToString();
            FormAboutCar fac = new FormAboutCar(db, currentRow);
            fac.ShowDialog();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormAddClient fAdd = new FormAddClient(db);
            fAdd.ShowDialog();
            dgvClients.Rows.Clear();
            db.LoadTables("clients", dgvClients);
        }

        private void toolStripBtEdit_Click(object sender, EventArgs e)
        {
            string idClient = dgvClients.CurrentRow.Cells[0].Value.ToString();
            string surname = dgvClients.CurrentRow.Cells[1].Value.ToString();
            string name = dgvClients.CurrentRow.Cells[2].Value.ToString();
            string patronimyc = dgvClients.CurrentRow.Cells[3].Value.ToString();
            string phone = dgvClients.CurrentRow.Cells[4].Value.ToString();
            string numSTS = dgvClients.CurrentRow.Cells[5].Value.ToString();

            FormAddClient fac = new FormAddClient(db, idClient, surname, name, patronimyc, phone, numSTS);
            fac.ShowDialog();
            dgvClients.Rows.Clear();
            db.LoadTables("clients", dgvClients);
        }

        private void toolStripTBSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btSearch_Click(this, new EventArgs());
            }
        }

        private void dgvClients_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvClients.CurrentCell = dgvClients.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void просмотрРаботToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string idClient = dgvClients.CurrentRow.Cells[0].Value.ToString();
            FormShowRepairsForClient fsrfc = new FormShowRepairsForClient(db, idClient);
            fsrfc.ShowDialog();
        }
    }
}
