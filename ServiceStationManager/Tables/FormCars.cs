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
            int id = Convert.ToInt32(dgvCars.CurrentRow.Cells[0].Value);

            if (db.Delete("cars", "number_sts", id) == 0)
            {
                MessageBox.Show("Невозможно удалить автомобиль, так как информация о его владельце ещё числится в БД", "Ошибка");
            }
            else
            {
                dgvCars.Rows.Clear();
                db.LoadTables("cars", dgvCars);
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
            db.SearchInCars(tbSearch.Text, dgvCars);
        }
    }
}
