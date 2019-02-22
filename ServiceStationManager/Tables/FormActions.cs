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
            int id = Convert.ToInt32(dgvActions.CurrentRow.Cells[0].Value);
            db.Delete("actions", "id_action", id);
            dgvActions.Rows.Clear();
            db.LoadTables("actions", dgvActions);
        }
    }
}
