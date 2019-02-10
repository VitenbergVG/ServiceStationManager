using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceStationManager.ClientsToday;

namespace ServiceStationManager
{
    public partial class UserControlClientsToday : UserControl
    {
        private string loginDB;
        private string passDB;
        private string portDB;
        private string ipDB;

        ClassDB db;

        string timeStartRepair;

        public int idClient = -1;

        public UserControlClientsToday(string loginDB, string passDB, string ipDB, string portDB)
        {
            InitializeComponent();

            this.loginDB = loginDB;
            this.passDB = passDB;
            this.ipDB = ipDB;
            this.portDB = portDB;

            db = new ClassDB(ipDB, portDB, loginDB, passDB);
            timeStartRepair = DateTime.Now.ToString("HH:mm:ss");

            toolStripBtFinishRepair.Enabled = false;
            toolStripBtDeleteRepair.Enabled = false;
        }

        private void toolStripBtAddRepair_Click(object sender, EventArgs e)
        {
            FormAddRepairForCurrentClient farfcc = new FormAddRepairForCurrentClient(loginDB, passDB, ipDB, portDB);
            farfcc.ShowDialog();

            //Обновление списка работ после закрытия дочерней формы
            clbRepairs.Items.Add(StaticData.DataBufferNameRepair);
            lbEmployeesRepairs.Items.Add(StaticData.DataBufferEmployee);

            db.SearchCostRepairs(StaticData.DataBufferNameRepair, lbRepairsCosts);

            int totalCost = 0;

            for (int i = 0; i < lbRepairsCosts.Items.Count; i++)
            {
                totalCost += Convert.ToInt32(lbRepairsCosts.Items[i].ToString());
            }

            lbRepairsTotalCost.Text = "Итоговая\nстоимость:\n" + totalCost + " рублей";
        }

        private void toolStripBtPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            String repairs = "";
            for (int i = 0; i < clbRepairs.Items.Count; i++)
            {
                repairs += i + 1 + ". " + clbRepairs.Items[i].ToString() + "\n";
            }

            String result =
            tbNameDriver.Text + ", спасибо, что выбрали именно нас!" + "\n\n" +
            "\t" + "Счёт на оказание услуг авторемонта:" + "\n\n" +
            repairs + "\n" +
            "Итоговая стоимость: " +
            "\n\n*Гарантийный срок на оказанные услуги  устанавливается\n с даты приёмки Заказчиком выполненных работ\n" +
            "\t- на слесарные работы - не менее 3 месяцев или 30000км пробега\n" +
            "\t- на ремонт агргатов - не менее 6 месяцев или 30000км пробега\n" +
            "\t- на малярно-кузовные работы - не менее 6 месяцев или 50000км пробега\n" +
            "\t- на техническое обслуживание - до следующего ТО\n" +
            "\t- текущий ремонт - не менее 20 календарных дней или не менее 2000км пробега\n" +
            "\t- на запасные части (за исключением расходных) - не менее 6 месяцев\n";

            int totalCost = 0;
            String costs = "";
            for (int i = 0; i < lbRepairsCosts.Items.Count; i++)
            {
                costs += lbRepairsCosts.Items[i].ToString() + " рублей" + "\n";
                totalCost += Convert.ToInt32(lbRepairsCosts.Items[i].ToString());
            }

            String resultCost = costs + "\n" + totalCost + " рублей";

            e.Graphics.DrawString(result, new Font("Arial", 12), Brushes.Black, 100, 100);
            e.Graphics.DrawString(resultCost, new Font("Arial", 12), Brushes.Black, 600, 180);
        }

        private void clbRepairs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbRepairs.Items.Count != 0 && clbRepairs.SelectedIndex != -1)
            {
                if (!clbRepairs.GetItemChecked(clbRepairs.SelectedIndex))
                {
                    toolStripBtFinishRepair.Enabled = true;
                    toolStripBtDeleteRepair.Enabled = true;
                }
                else
                {
                    toolStripBtFinishRepair.Enabled = false;
                    toolStripBtDeleteRepair.Enabled = false;
                }

                lbEmployeesRepairs.SelectedIndex = clbRepairs.SelectedIndex;
                lbRepairsCosts.SelectedIndex = clbRepairs.SelectedIndex;
            }
        }

        private void lbRepairsCosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbRepairs.Items.Count != 0)
            {
                lbEmployeesRepairs.SelectedIndex = lbRepairsCosts.SelectedIndex;
                clbRepairs.SelectedIndex = lbRepairsCosts.SelectedIndex;
            }
        }

        private void lbEmployeesRepairs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clbRepairs.Items.Count != 0)
            {
                clbRepairs.SelectedIndex = lbEmployeesRepairs.SelectedIndex;
                lbRepairsCosts.SelectedIndex = lbEmployeesRepairs.SelectedIndex;
            }
        }

        private void clbRepairs_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            e.NewValue = e.CurrentValue;
        }

        public void SetCheckState(int itemIndex, CheckState newState)
        {
            clbRepairs.ItemCheck -= clbRepairs_ItemCheck; // отключаем обработчик
            clbRepairs.SetItemCheckState(itemIndex, newState); // меняем состояние
            clbRepairs.ItemCheck += clbRepairs_ItemCheck; // подключаем обработчик
        }

        private void toolStripBtFinishRepair_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Работа завершена?", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string[] strEmployee = lbEmployeesRepairs.SelectedItem.ToString().Split(new char[] { ' ' });
                int idEmployee = Convert.ToInt32(strEmployee[strEmployee.Length - 1]);

                string factQuery;
                factQuery = "(`work_hours_id_work_hours`, `repairs_id_repair`, `clients_id_client`, `time_start`, `time_finish`) VALUES('" +
                           db.SearchIdWorkHours(idEmployee, DateTime.Today.ToString("yyyy-MM-dd")) + "', '" +
                           db.SearchIdRepairs(clbRepairs.SelectedItem.ToString()) +
                           "', '" + idClient + "', '" + timeStartRepair + "', '" + DateTime.Now.ToString("HH:mm:ss") + "');";
                db.Add("current_repairs", factQuery);

                toolStripBtFinishRepair.Enabled = false;
                toolStripBtDeleteRepair.Enabled = false;

                SetCheckState(clbRepairs.SelectedIndex, CheckState.Checked);
            }
        }

        private void toolStripBtDeleteRepair_Click(object sender, EventArgs e)
        {
            int index = clbRepairs.SelectedIndex;
            clbRepairs.Items.RemoveAt(index);
            lbEmployeesRepairs.Items.RemoveAt(index);
            lbRepairsCosts.Items.RemoveAt(index);

            int totalCost = 0;

            for (int i = 0; i < lbRepairsCosts.Items.Count; i++)
            {
                totalCost += Convert.ToInt32(lbRepairsCosts.Items[i].ToString());
            }

            lbRepairsTotalCost.Text = "Итоговая\nстоимость:\n" + totalCost + " рублей";

            toolStripBtDeleteRepair.Enabled = false;
        }
    }

    //Статический класс для передачи данных из дочерней формы в основную
    public static class StaticData
    {
        //Статическая переменная, выступающая как буфер данных
        public static String DataBufferNameRepair = String.Empty;
        public static String DataBufferEmployee = String.Empty;
    }
}
