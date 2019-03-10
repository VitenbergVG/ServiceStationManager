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
        string surnameEmployee;
        string date;

        public FormAboutCurrentRepair(ClassDB db, string surnameEmployee, string date)
        {
            InitializeComponent();
            this.db = db;
            this.surnameEmployee = surnameEmployee;
            this.date = date;
            
            dgvInfoCurrentRepairs.ColumnCount = 11;
            dgvInfoCurrentRepairs.Columns[0].HeaderCell.Value = "ID работы";
            dgvInfoCurrentRepairs.Columns[1].HeaderCell.Value = "Ремонтная работа";
            dgvInfoCurrentRepairs.Columns[2].HeaderCell.Value = "Фамилия клиента";
            dgvInfoCurrentRepairs.Columns[3].HeaderCell.Value = "Марка автомобиля";
            dgvInfoCurrentRepairs.Columns[4].HeaderCell.Value = "Модель автомобиля";
            dgvInfoCurrentRepairs.Columns[5].HeaderCell.Value = "Фамилия сотрудника";
            dgvInfoCurrentRepairs.Columns[6].HeaderCell.Value = "Должность сотрудника";
            dgvInfoCurrentRepairs.Columns[7].HeaderCell.Value = "Дата";
            dgvInfoCurrentRepairs.Columns[8].HeaderCell.Value = "Время начала";
            dgvInfoCurrentRepairs.Columns[9].HeaderCell.Value = "Время окончания";
            dgvInfoCurrentRepairs.Columns[10].HeaderCell.Value = "Статус";
            db.ShowInfoCurrentRepair(surnameEmployee, date, dgvInfoCurrentRepairs);

            if (dgvInfoCurrentRepairs.Rows.Count == 0)
            {
                toolStripBtDeleteRepair.Enabled = false;
            }
        }

        private void toolStripBtDeleteRepair_Click(object sender, EventArgs e)
        {
            string id = dgvInfoCurrentRepairs.CurrentRow.Cells[0].Value.ToString();
            db.Delete("current_repairs", "id_current_repair", id);
            dgvInfoCurrentRepairs.Rows.Clear();
            db.ShowInfoCurrentRepair(surnameEmployee, date, dgvInfoCurrentRepairs);

            if (dgvInfoCurrentRepairs.Rows.Count == 0)
            {
                toolStripBtDeleteRepair.Enabled = false;
            }
        }
    }
}
