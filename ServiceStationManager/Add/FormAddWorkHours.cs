using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceStationManager.Add
{
    public partial class FormAddWorkHours : Form
    {
        ClassDB db;

        List<string> surnameEmployees;

        string currentDate;
        int currentIdEmployee;

        List<int> globalidEmployees = new List<int>();
        List<DateTime> globalDates;

        public FormAddWorkHours(ClassDB db)
        {
            InitializeComponent();
            this.db = db;

            surnameEmployees = db.GetEmployees(globalidEmployees);

            for (int i = 0; i < surnameEmployees.Count; i++)
            {
                cbSurnameEmployee.Items.Add(surnameEmployees[i]);
                cbSurnameEmployeeRegularity.Items.Add(surnameEmployees[i]);
                clbEmployees.Items.Add(surnameEmployees[i]);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (cbSurnameEmployee.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "Ошибка");
            }
            else
            {
                db.AddWorkHour(currentIdEmployee, dtpDate.Value.ToString("yyyy-MM-dd"));
                Hide();
            }
        }

        private void btAddRegularity_Click(object sender, EventArgs e)
        {
            if (cbSurnameEmployeeRegularity.Text == "" || cbRegularity.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "Ошибка");
            }
            else
            {
                string factQuery;

                List<DateTime> datesRegularity = new List<DateTime>();
                int checkRegularity = 1;

                string values = "";

                switch (cbRegularity.SelectedItem)
                {
                    //Добавить дату конца и смотреть от даты начала до даты конца, предлагать месяц
                    case "2 через 2":
                        for (int i = Convert.ToInt32(dtpDateStart.Value); i < globalDates.Count; i++)
                        {
                            if (checkRegularity < 3)
                            {
                                datesRegularity.Add(globalDates[i]);
                                checkRegularity++;
                            }
                            else { checkRegularity = 1; i++; }
                        }

                        for (int i = 0; i < datesRegularity.Count() - 1; i++)
                        {
                            values += "('" + currentIdEmployee + "' , '" + datesRegularity[i].ToString("yyyy-MM-dd") + "'), ";
                        }

                        values += "('" + currentIdEmployee + "' , '" + datesRegularity[datesRegularity.Count() - 1].ToString("yyyy-MM-dd") + "')";
                        break;

                    case "2 через 1":
                        for (int i = cbDateStart.SelectedIndex; i < globalDates.Count; i++)
                        {
                            if (checkRegularity < 3)
                            {
                                datesRegularity.Add(globalDates[i]);
                                checkRegularity++;
                            }
                            else { checkRegularity = 1; }
                        }

                        for (int i = 0; i < datesRegularity.Count() - 1; i++)
                        {
                            values += "('" + currentIdEmployee + "' , '" + datesRegularity[i].ToString("yyyy-MM-dd") + "'), ";
                        }

                        values += "('" + currentIdEmployee + "' , '" + datesRegularity[datesRegularity.Count() - 1].ToString("yyyy-MM-dd") + "')";
                        break;

                    case "3 через 3":
                        for (int i = cbDateStart.SelectedIndex; i < globalDates.Count; i++)
                        {
                            if (checkRegularity < 4)
                            {
                                datesRegularity.Add(globalDates[i]);
                                checkRegularity++;
                            }
                            else { checkRegularity = 1; i = i + 2; }
                        }

                        for (int i = 0; i < datesRegularity.Count() - 1; i++)
                        {
                            values += "('" + currentIdEmployee + "' , '" + datesRegularity[i].ToString("yyyy-MM-dd") + "'), ";
                        }

                        values += "('" + currentIdEmployee + "' , '" + datesRegularity[datesRegularity.Count() - 1].ToString("yyyy-MM-dd") + "')";
                        break;
                }
                factQuery = "(`employees_id_employee`, `dates_of_month`) VALUES" + values + ";";
                db.Add("work_hours", factQuery);
                Hide();
            }
        }

        private void cbSurnameEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentIdEmployee = globalidEmployees[cbSurnameEmployee.SelectedIndex];
        }
        
        private void cbSurnameEmployeeRegularity_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentIdEmployee = globalidEmployees[cbSurnameEmployeeRegularity.SelectedIndex];
        }
        
        private void btAddMoreEmployees_Click(object sender, EventArgs e)
        {
            if (clbEmployees.CheckedItems.Count == 0)
            {
                MessageBox.Show("Добавьте смену хотя-бы одному сотрунику", "Ошибка");
            }
            else
            {
                for (int i = 0; i < clbEmployees.Items.Count; i++)
                {
                    if (clbEmployees.GetItemChecked(i))
                        db.AddWorkHour(globalidEmployees[i], dtpDateMoreEmployees.Value.ToString("yyyy-MM-dd"));
                }

                Hide();
            }
        }
    }
}
