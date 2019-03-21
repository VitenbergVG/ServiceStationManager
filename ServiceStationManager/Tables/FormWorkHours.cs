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
    public partial class FormWorkHours : Form
    {
        ClassDB db;

        List<int> allYears;//Все года 
        List<int> allMonth;//Все месяца 
        List<int> allDays;//Все дни
        List<DateTime> dates;
        List<int> idEmployees;
        List<string> surnameEmployees;

        public FormWorkHours(ClassDB db)
        {
            InitializeComponent();

            this.db = db;

            dates = new List<DateTime>();//Список дат
            idEmployees = new List<int>();//Список id сотрудников
            surnameEmployees = new List<string>();//Список фамилий сотрудников

            RefreshTable();
        }

        private void RefreshTable()
        {
            treeViewDates.Nodes.Clear();
            allYears = db.GetYearsOfWorkHours();

            for (int i = 0; i < allYears.Count(); i++)
            {
                treeViewDates.Nodes.Add(allYears[i].ToString());
                allMonth = db.GetMonthsOfWorkHours(allYears[i]);

                for (int j = 0; j < allMonth.Count(); j++)
                {
                    treeViewDates.Nodes[i].Nodes.Add(DateTimeFormatInfo.CurrentInfo.MonthNames[allMonth[j] - 1].ToString());

                    allDays = db.GetDaysOfWorkHours(allYears[i], allMonth[j]);

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
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            FormAddWorkHours fawh = new FormAddWorkHours(db);
            fawh.ShowDialog();
            dgvWorkHours.Rows.Clear();
            RefreshTable();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int indexRow = dgvWorkHours.CurrentCell.RowIndex;
            int indexCol = dgvWorkHours.CurrentCell.ColumnIndex;

            db.DeleteFromWorkHours(idEmployees[indexRow], dates[indexCol].ToString("yyyy-MM-dd"));
            RefreshTable();
        }

        private void treeViewDates_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            dgvWorkHours.Rows.Clear();
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
                dgvWorkHours.ColumnCount = dates.Count;
                for (int i = 0; i < dgvWorkHours.Columns.Count; i++)
                {
                    dgvWorkHours.Columns[i].HeaderText = dates[i].ToShortDateString();
                }

                db.WorkHoursNameEmployees(dgvWorkHours, idEmployees, surnameEmployees, dates);
            }
        }
    }
}
