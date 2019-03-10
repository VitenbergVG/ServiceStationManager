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
        bool edit = false;
        string idAction;

        public FormAddAction(ClassDB db)
        {
            InitializeComponent();
            this.db = db;
        }

        public FormAddAction(ClassDB db, string idAction, string name, string text)
        {
            InitializeComponent();
            this.db = db;
            edit = true;
            this.idAction = idAction;
            tbNameAction.Text = name;
            tbTextAction.Text = text;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbNameAction.Text != "")
            {
                string factQuery;

                if (!edit)
                {
                    factQuery = "(name, text) VALUES('" + tbNameAction.Text + "', '" + tbTextAction.Text + "');";
                    db.Add("actions", factQuery);
                }
                else
                {
                    factQuery = "name = '" + tbNameAction.Text + "', text = '"+ tbTextAction.Text + "'";
                    db.Edit("actions", "id_action", idAction, factQuery);
                }

                Hide();
            }
            else
            {
                MessageBox.Show("Заполните поле \"Название акции\"!", "Ошибка");
            }
        }
    }
}
