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
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить работу?", "Система управления СТО", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                db.Delete("repairs", "id_repair", id);
                dataGridView1.Rows.Clear();
                db.LoadTables("repairs", dataGridView1);
            }
        }

        private void редактироватьРаботуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string idRepair = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string category = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            string cost = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            string position = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            FormAddRepair far = new FormAddRepair(db, idRepair, name, category, cost, position);
            far.ShowDialog();
            dataGridView1.Rows.Clear();
            db.LoadTables("repairs", dataGridView1);
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }
    }
}
