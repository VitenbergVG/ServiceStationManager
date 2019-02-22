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
    public partial class FormPicWorkHours : Form
    {
        ClassDB db;
        public string currentRow;

        public FormPicWorkHours(ClassDB db)
        {
            InitializeComponent();
            this.db = db;
            dgvWorkHours.ColumnCount = 4;
            dgvWorkHours.Columns[0].HeaderCell.Value = "ID Смены";
            dgvWorkHours.Columns[1].HeaderCell.Value = "Дата";
            dgvWorkHours.Columns[2].HeaderCell.Value = "Фамилия сотрудника";
            dgvWorkHours.Columns[3].HeaderCell.Value = "Должность";
            db.SearchWorkHoursForPic(dgvWorkHours);
        }

        public void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentRow = dgvWorkHours.CurrentRow.Cells[0].Value.ToString();
            Hide();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dgvWorkHours.Rows.Clear();
            db.SearchInWorkHours(tbSearch.Text, dgvWorkHours);
        }
    }
}
