using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceStationManager.Tables
{
    public partial class FormShowRepairsForClient : Form
    {
        ClassDB db;
        public FormShowRepairsForClient(ClassDB db, string idClient)
        {
            InitializeComponent();
            this.db = db;

            dgvRepairsClient.ColumnCount = 6;
            dgvRepairsClient.Columns[0].HeaderCell.Value = "Id клиента";
            dgvRepairsClient.Columns[1].HeaderCell.Value = "CТС машины";
            dgvRepairsClient.Columns[2].HeaderCell.Value = "Id ремонтной работы";
            dgvRepairsClient.Columns[3].HeaderCell.Value = "Id сотрудника";
            dgvRepairsClient.Columns[4].HeaderCell.Value = "Дата";
            dgvRepairsClient.Columns[5].HeaderCell.Value = "Время окончания работы";
            db.GetPerformedRepairsForClient(idClient, dgvRepairsClient);
        }
    }
}
