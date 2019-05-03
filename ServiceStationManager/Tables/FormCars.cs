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
    public partial class FormCars : Form
    {
        ClassDB db;

        public FormCars(ClassDB db)
        {
            InitializeComponent();

            this.db = db;

            dgvCars.ColumnCount = 5;
            dgvCars.Columns[0].HeaderCell.Value = "СТС";
            dgvCars.Columns[1].HeaderCell.Value = "Марка";
            dgvCars.Columns[2].HeaderCell.Value = "Модель";
            dgvCars.Columns[3].HeaderCell.Value = "Год выпуска";
            dgvCars.Columns[4].HeaderCell.Value = "Дата последнего ТО";
            db.LoadTables("cars", dgvCars);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить автомобиль?", "Система управления СТО", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string id = dgvCars.CurrentRow.Cells[0].Value.ToString();

                if (db.Delete("cars", "number_sts", id) == 0)
                {
                    MessageBox.Show("Невозможно удалить автомобиль, так как информация о его владельце ещё числится в БД", "Система управления СТО", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dgvCars.Rows.Clear();
                    db.LoadTables("cars", dgvCars);
                }
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormAddCar fAdd = new FormAddCar(db);
            fAdd.ShowDialog();
            dgvCars.Rows.Clear();
            db.LoadTables("cars", dgvCars);
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            dgvCars.Rows.Clear();
            db.SearchInCars(toolStripTBSearch.Text, dgvCars);
        }

        private void toolStripBtEdit_Click(object sender, EventArgs e)
        {
            string id = dgvCars.CurrentRow.Cells[0].Value.ToString();
            string brand = dgvCars.CurrentRow.Cells[1].Value.ToString();
            string model = dgvCars.CurrentRow.Cells[2].Value.ToString();
            string yearCreated = dgvCars.CurrentRow.Cells[3].Value.ToString();
            string dateTO = dgvCars.CurrentRow.Cells[4].Value.ToString();

            FormAddCar fac = new FormAddCar(db, id, brand, model, yearCreated, dateTO);
            fac.ShowDialog();
            dgvCars.Rows.Clear();
            db.LoadTables("cars", dgvCars);
        }

        private void toolStripTBSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btSearch_Click(this, new EventArgs());
            }
        }

        private void dgvCars_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvCars.CurrentCell = dgvCars.Rows[e.RowIndex].Cells[e.ColumnIndex];
        }
    }
}
