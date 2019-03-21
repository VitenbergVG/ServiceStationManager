using ServiceStationManager.Add;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceStationManager
{
    public partial class FormWorkHoursRepairs : Form
    {
        ClassDB db;

        List<int> allYears;//Все года 
        List<int> allMonth;//Все месяца 
        List<int> allDays;//Все дни
        List<DateTime> dates;

        List<int> idEmployees;
        List<string> surnameEmployees;

        public FormWorkHoursRepairs(ClassDB db)
        {
            InitializeComponent();

            this.db = db;

            dates = new List<DateTime>();//Список дат
            idEmployees = new List<int>();//Список id сотрудников
            surnameEmployees = new List<string>();//Список фамилий сотрудников

            RefreshTable();
        }

        //или переделать или удалить этот метод
        private void RefreshTable()
        {
            treeViewDates.Nodes.Clear();
            allYears = db.GetYearsOfRepairs();

            for (int i = 0; i < allYears.Count(); i++)
            {
                treeViewDates.Nodes.Add(allYears[i].ToString());
                allMonth = db.GetMonthsOfRepairs(allYears[i]);

                for (int j = 0; j < allMonth.Count(); j++)
                {
                    treeViewDates.Nodes[i].Nodes.Add(DateTimeFormatInfo.CurrentInfo.MonthNames[allMonth[j] - 1].ToString());

                    allDays = db.GetDaysOfRepairs(allYears[i], allMonth[j]);

                    for (int k = 0; k < allDays.Count(); k++)
                    {
                        treeViewDates.Nodes[i].Nodes[j].Nodes.Add(allDays[k].ToString());

                        string picDate = treeViewDates.Nodes[i].Nodes[j].Nodes[k].Text + "." +
                            treeViewDates.Nodes[i].Nodes[j].Text + "." +
                            treeViewDates.Nodes[i].Text;

                        treeViewDates.Nodes[i].Nodes[j].Nodes[k].Text += " - " +
                            Convert.ToDateTime(picDate).ToString("ddd", CultureInfo.GetCultureInfo("ru-ru"));
                    }
                }
            }
            treeViewDates.ExpandAll();

            //dgvWorkHoursRepairs.FirstDisplayedCell = dgvWorkHoursRepairs.Rows[0].Cells[7];
            //dgvWorkHoursRepairs.CurrentCell = dgvWorkHoursRepairs.Rows[0].Cells[7];
            //dgvWorkHoursRepairs.Columns[7].DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormAddWorkHoursRepair fawh = new FormAddWorkHoursRepair(db);
            fawh.ShowDialog();
            RefreshTable();
        }

        private void dgvWorkHoursRepairs_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string surnameEmployee = dgvWorkHoursRepairs.Rows[dgvWorkHoursRepairs.CurrentCell.RowIndex].HeaderCell.Value.ToString();
            DateTime date = Convert.ToDateTime(dgvWorkHoursRepairs.Columns[dgvWorkHoursRepairs.CurrentCell.ColumnIndex].HeaderText.ToString());
            string strDate = date.ToString("yyyy-MM-dd");

            FormAboutCurrentRepair facr = new FormAboutCurrentRepair(db, surnameEmployee, strDate);
            facr.ShowDialog();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить всю рабочую смену " +
                "выбранного сотрудника и все ремонтные работы, выполненные им в эту смену?", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int indexRow = dgvWorkHoursRepairs.CurrentCell.RowIndex;
                int indexCol = dgvWorkHoursRepairs.CurrentCell.ColumnIndex;

                db.DeleteFromWorkHours(idEmployees[indexRow], dates[indexCol].ToString("yyyy-MM-dd"));

                RefreshTable();
            }


        }

        private void treeViewDates_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            dgvWorkHoursRepairs.Rows.Clear();
            dates.Clear();

            switch (e.Node.Level)
            {
                //Если выбран конкретный месяц
                case 1:
                    {
                        DateTime firstDate = Convert.ToDateTime(e.Node.Parent.Text + "." + e.Node.Text + "." + 22);

                        int countDaysInMonth = DateTime.DaysInMonth(Convert.ToInt32(e.Node.Parent.Text), firstDate.Month);

                        for (int i = 1; i <= countDaysInMonth; i++)
                        {
                            string picDates = e.Node.Parent.Text + "." + e.Node.Text + "." + i;
                            dates.Add(Convert.ToDateTime(picDates));
                        }
                    }
                    break;

                //Если выбран конкретный день
                case 2:
                    {
                        string[] day = e.Node.Text.Split(new char[] { ' ' });
                        string picDate = e.Node.Parent.Parent.Text + "." + e.Node.Parent.Text + "." + day[0];
                        dates.Add(Convert.ToDateTime(picDate));
                    }
                    break;
            }

            if (e.Node.Level != 0)
            {
                dgvWorkHoursRepairs.ColumnCount = dates.Count;
                for (int i = 0; i < dgvWorkHoursRepairs.Columns.Count; i++)
                {
                    dgvWorkHoursRepairs.Columns[i].HeaderText = dates[i].ToShortDateString();
                }

                db.WorkHoursRepairsNameEmployees(dgvWorkHoursRepairs, idEmployees, surnameEmployees, dates);
            }

        }
    }
}
