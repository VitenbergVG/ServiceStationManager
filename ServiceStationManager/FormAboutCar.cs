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
        public FormAboutCar(string curRow, string loginDB, string passDB, string ipDB, string portDB)
        {
            InitializeComponent();

            db = new ClassDB(ipDB, portDB, loginDB, passDB);

            dgvAboutCar.ColumnCount = 3;
            dgvAboutCar.Columns[0].HeaderCell.Value = "id";
            dgvAboutCar.Columns[1].HeaderCell.Value = "Модель";
            dgvAboutCar.Columns[2].HeaderCell.Value = "Марка";
            db.ShowInfoCar(dgvAboutCar, curRow);
        }
    }
}
