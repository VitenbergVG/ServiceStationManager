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
    public partial class FormAddAction : Form
    {
        ClassDB db;

        public FormAddAction(string loginDB, string passDB, string ipDB, string portDB)
        {
            InitializeComponent();
            db = new ClassDB(ipDB, portDB, loginDB, passDB);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbNameAction.Text != "")
            {
                string factQuery;
                factQuery = "(name, text) VALUES('" + tbNameAction.Text + "', '" + tbTextAction.Text + "');";
                db.Add("actions", factQuery);
                Hide();
            }
            else
            {
                MessageBox.Show("Заполните поле \"Название акции\"!", "Ошибка");
            }
        }
    }
}
