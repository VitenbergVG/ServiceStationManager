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
    public partial class FormRequests : Form
    {
        ClassDB db;

        private string loginDB;
        private string passDB;
        private string portDB;
        private string ipDB;

        public FormRequests(string loginDB, string passDB, string ipDB, string portDB)
        {
            InitializeComponent();

            this.loginDB = loginDB;
            this.passDB = passDB;
            this.ipDB = ipDB;
            this.portDB = portDB;

            db = new ClassDB(ipDB, portDB, loginDB, passDB);

            dgvRequests.ColumnCount = 4;
            dgvRequests.Columns[0].HeaderCell.Value = "ID заявки";
            dgvRequests.Columns[1].HeaderCell.Value = "Категория";
            dgvRequests.Columns[2].HeaderCell.Value = "ID клиента";
            dgvRequests.Columns[3].HeaderCell.Value = "Описание";
            db.LoadTables("requests", dgvRequests);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            db.Delete("requests", "id_request", dgvRequests);
            dgvRequests.Rows.Clear();
            db.LoadTables("requests", dgvRequests);
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            dgvRequests.Rows.Clear();
            db.LoadTables("requests", dgvRequests);
        }
    }
}
