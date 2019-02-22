﻿using System;
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
            int id = Convert.ToInt32(dgvClients.CurrentRow.Cells[0].Value);

            if (db.Delete("clients", "id_client", id) == 0)
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
    }
}
