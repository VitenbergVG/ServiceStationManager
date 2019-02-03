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
    public partial class FormAboutCurrentRepair : Form
    {
        ClassDB db;

        public FormAboutCurrentRepair(string loginDB, string passDB, string ipDB, string portDB, string surnameEmployee, string date)
        {
            InitializeComponent();
            db = new ClassDB(ipDB, portDB, loginDB, passDB);
            dgvInfoCurrentRepairs.ColumnCount = 9;
            dgvInfoCurrentRepairs.Columns[0].HeaderCell.Value = "Ремонтная работа";
            dgvInfoCurrentRepairs.Columns[1].HeaderCell.Value = "Фамилия клиента";
            dgvInfoCurrentRepairs.Columns[2].HeaderCell.Value = "Марка автомобиля";
            dgvInfoCurrentRepairs.Columns[3].HeaderCell.Value = "Модель автомобиля";
            dgvInfoCurrentRepairs.Columns[4].HeaderCell.Value = "Фамилия сотрудника";
            dgvInfoCurrentRepairs.Columns[5].HeaderCell.Value = "Должность сотрудника";
            dgvInfoCurrentRepairs.Columns[6].HeaderCell.Value = "Дата";
            dgvInfoCurrentRepairs.Columns[7].HeaderCell.Value = "Время начала";
            dgvInfoCurrentRepairs.Columns[8].HeaderCell.Value = "Время окончания";
            db.ShowInfoCurrentRepair(surnameEmployee, date, dgvInfoCurrentRepairs);
        }
    }
}
