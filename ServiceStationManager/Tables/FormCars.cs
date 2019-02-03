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

        private string loginDB;
        private string passDB;
        private string ipDB;
        private string portDB;

        public FormCars(string loginDB, string passDB, string ipDB, string portDB)
        {
            InitializeComponent();

            this.loginDB = loginDB;
            this.passDB = passDB;
            this.ipDB = ipDB;
            this.portDB = portDB;

            dgvCars.ColumnCount = 5;
            dgvCars.Columns[0].HeaderCell.Value = "СТС";
            dgvCars.Columns[1].HeaderCell.Value = "Марка";
            dgvCars.Columns[2].HeaderCell.Value = "Модель";
            dgvCars.Columns[3].HeaderCell.Value = "Год выпуска";
            dgvCars.Columns[4].HeaderCell.Value = "Дата последнего ТО";

            //dgvCars.Columns[4].DefaultCellStyle.Format = "yyyy-MM-dd";

            db = new ClassDB(ipDB, portDB, loginDB, passDB);
            db.LoadTables("cars", dgvCars);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (db.Delete("cars", "number_sts", dgvCars) == 0)
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
            FormAddCar fAdd = new FormAddCar(loginDB, passDB, ipDB, portDB);
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
