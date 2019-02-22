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
    public partial class FormRepairs : Form
    {
        ClassDB db;

        public FormRepairs(ClassDB db)
        {
            InitializeComponent();

            this.db = db;

            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].HeaderCell.Value = "ID работы";
            dataGridView1.Columns[1].HeaderCell.Value = "Наименование";
            dataGridView1.Columns[2].HeaderCell.Value = "Категория";
            dataGridView1.Columns[3].HeaderCell.Value = "Цена";
            dataGridView1.Columns[4].HeaderCell.Value = "Должность";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            db.LoadTables("repairs", dataGridView1);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormAddRepair fAdd = new FormAddRepair(db);
            fAdd.ShowDialog();
            dataGridView1.Rows.Clear();
            db.LoadTables("repairs", dataGridView1);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

            db.Delete("repairs", "id_repair", id);
            dataGridView1.Rows.Clear();
            db.LoadTables("repairs", dataGridView1);
        }
    }
}
