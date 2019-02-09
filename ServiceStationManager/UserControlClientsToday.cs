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

        public UserControlClientsToday(string loginDB, string passDB, string ipDB, string portDB)
        {
            InitializeComponent();

            this.loginDB = loginDB;
            this.passDB = passDB;
            this.ipDB = ipDB;
            this.portDB = portDB;

            db = new ClassDB(ipDB, portDB, loginDB, passDB);
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
    }

    //Статический класс для передачи данных из дочерней формы в основную
    public static class StaticData
    {
        //Статическая переменная, выступающая как буфер данных
        public static String DataBufferNameRepair = String.Empty;
        public static String DataBufferEmployee = String.Empty;
    }
}
