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
    public partial class FormAboutCar : Form
    {
        ClassDB db;
        public FormAboutCar(ClassDB db, string curRow)
        {
            InitializeComponent();

            this.db = db;

            dgvAboutCar.ColumnCount = 3;
            dgvAboutCar.Columns[0].HeaderCell.Value = "ID клиента";
            dgvAboutCar.Columns[1].HeaderCell.Value = "Модель";
            dgvAboutCar.Columns[2].HeaderCell.Value = "Марка";
            db.ShowInfoCar(dgvAboutCar, curRow);
        }
    }
}
