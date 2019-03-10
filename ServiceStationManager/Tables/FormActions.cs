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
    public partial class FormActions : Form
    {
        ClassDB db;

        public FormActions(ClassDB db)
        {
            InitializeComponent();

            this.db = db;

            dgvActions.ColumnCount = 3;
            dgvActions.Columns[0].HeaderCell.Value = "ID";
            dgvActions.Columns[1].HeaderCell.Value = "Название";
            dgvActions.Columns[2].HeaderCell.Value = "Текст";

            db.LoadTables("actions", dgvActions);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormAddAction faa = new FormAddAction(db);
            faa.ShowDialog();
            dgvActions.Rows.Clear();
            db.LoadTables("actions", dgvActions);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string id = dgvActions.CurrentRow.Cells[0].Value.ToString();
            db.Delete("actions", "id_action", id);
            dgvActions.Rows.Clear();
            db.LoadTables("actions", dgvActions);
        }

        private void dgvActions_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvActions.CurrentCell = dgvActions.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }

        private void редактироватьАкциюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string idAction = dgvActions.CurrentRow.Cells[0].Value.ToString();
            string name = dgvActions.CurrentRow.Cells[1].Value.ToString();
            string text = dgvActions.CurrentRow.Cells[2].Value.ToString();

            FormAddAction faa = new FormAddAction(db, idAction, name, text);
            faa.ShowDialog();
            dgvActions.Rows.Clear();
            db.LoadTables("actions", dgvActions);
        }
    }
}
