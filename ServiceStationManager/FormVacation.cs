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
    public partial class FormVacation : Form
    {
        ClassDB db;
        List<int> idEmployees = new List<int>();

        public FormVacation(ClassDB db)
        {
            InitializeComponent();
            this.db = db;

            cbSurnameEmployee.Items.Add(db.GetEmployees(idEmployees));
            dtpFinishVacation.Value = dtpStartVacation.Value.AddDays(14);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string factQuery = "(employees_id_employee, date_start, date_finish) VALUES('" +
                                          idEmployees[cbSurnameEmployee.SelectedIndex] + "', '" + dtpStartVacation.Value.ToString("yyyy-MM-dd") + "', '" +
                                          dtpFinishVacation.Value.ToString("yyyy-MM-dd") + "');";
            db.Add("vacation", factQuery);

            if (DateTime.Today >= dtpStartVacation.Value && DateTime.Today <= dtpFinishVacation.Value)
            {
                factQuery = "status = 'В отпуске'";
                db.Edit("employees", "id_employee", idEmployees[cbSurnameEmployee.SelectedIndex].ToString(), factQuery);
            }

            Hide();
        }
    }
}
