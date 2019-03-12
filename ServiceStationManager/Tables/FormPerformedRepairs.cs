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
    public partial class FormPerformedRepairs : Form
    {
        ClassDB db;
        public FormPerformedRepairs(ClassDB db)
        {
            InitializeComponent();
            this.db = db;

            dgvRepairs.ColumnCount = 6;
            dgvRepairs.Columns[0].HeaderCell.Value = "Id клиента";
            dgvRepairs.Columns[1].HeaderCell.Value = "CТС машины";
            dgvRepairs.Columns[2].HeaderCell.Value = "Id ремонтной работы";
            dgvRepairs.Columns[3].HeaderCell.Value = "Id сотрудника";
            dgvRepairs.Columns[4].HeaderCell.Value = "Дата";
            dgvRepairs.Columns[5].HeaderCell.Value = "Время окончания работы";
            db.GetPerformedRepairs(dgvRepairs);
        }
    }
}
