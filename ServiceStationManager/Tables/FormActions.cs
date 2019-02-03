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

        private string loginDB;
        private string passDB;
        private string portDB;
        private string ipDB;

        public FormActions(string loginDB, string passDB, string ipDB, string portDB)
        {
            InitializeComponent();

            this.loginDB = loginDB;
            this.passDB = passDB;
            this.ipDB = ipDB;
            this.portDB = portDB;

            db = new ClassDB(ipDB, portDB, loginDB, passDB);

            dgvActions.ColumnCount = 3;
            dgvActions.Columns[0].HeaderCell.Value = "ID";
            dgvActions.Columns[1].HeaderCell.Value = "Название";
            dgvActions.Columns[2].HeaderCell.Value = "Текст";

            db.LoadTables("actions", dgvActions);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormAddAction faa = new FormAddAction(loginDB, passDB, ipDB, portDB);
            faa.ShowDialog();
            dgvActions.Rows.Clear();
            db.LoadTables("actions", dgvActions);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            db.Delete("actions", "id_action", dgvActions);
            dgvActions.Rows.Clear();
            db.LoadTables("actions", dgvActions);
        }
    }
}
