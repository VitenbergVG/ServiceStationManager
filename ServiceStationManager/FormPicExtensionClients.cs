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
    public partial class FormPicExtensionClients : Form
    {
        public int currentRow;
        public int quantityDays;

        ClassDB db;

        public FormPicExtensionClients(ClassDB db)
        {
            this.db = db;

            InitializeComponent();
            dgvExtentionWorks.ColumnCount = 7;
            dgvExtentionWorks.Columns[0].HeaderCell.Value = "ID клиента";
            dgvExtentionWorks.Columns[1].HeaderCell.Value = "Фамилия";
            dgvExtentionWorks.Columns[2].HeaderCell.Value = "Имя";
            dgvExtentionWorks.Columns[3].HeaderCell.Value = "Номер телефона";
            dgvExtentionWorks.Columns[4].HeaderCell.Value = "Марка";
            dgvExtentionWorks.Columns[5].HeaderCell.Value = "Модель";
            dgvExtentionWorks.Columns[6].HeaderCell.Value = "Количество дней";

            db.SearchExtentionWorksForPic(dgvExtentionWorks);
        }

        private void dgvExtentionWorks_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            currentRow = Convert.ToInt32(dgvExtentionWorks.CurrentRow.Cells[0].Value);
            quantityDays = Convert.ToInt32(dgvExtentionWorks.CurrentRow.Cells[6].Value);
            Hide();
        }
    }
}
