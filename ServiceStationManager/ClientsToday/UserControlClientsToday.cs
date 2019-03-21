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
        TabPage tabPage;

        ClassDB db;

        string timeStartRepair = "";

        public int idClient = -1;
        public int quantityDays = 1;//количество дней, пока машина в работе

        List<int> idCurrentRepairs = new List<int>();

        public UserControlClientsToday(ClassDB db, TabPage tabPage)
        {
            InitializeComponent();

            this.db = db;

            this.tabPage = tabPage;

            timeStartRepair = DateTime.Now.ToString("HH:mm:ss");

            toolStripBtFinishRepair.Enabled = false;
            toolStripBtDeleteRepair.Enabled = false;

            for (int i = DateTime.Now.Year; i >= 1970; i--)
            {
                cbYearCreated.Items.Add(i);
            }
        }

        //Для отложенных клиентов
        public UserControlClientsToday(ClassDB db, TabPage tabPage, List<int> idExtentionRepairs, int quantityDaysForExtensionWorks)
        {
            InitializeComponent();

            this.db = db;
            this.tabPage = tabPage;

            timeStartRepair = DateTime.Now.ToString("HH:mm:ss");

            toolStripBtFinishRepair.Enabled = false;
            toolStripBtDeleteRepair.Enabled = false;

            for (int i = 0; i < idExtentionRepairs.Count; i++)
            {
                db.InfoExtensionRepairs(idExtentionRepairs[i], idCurrentRepairs, clbRepairs,
                lbEmployeesRepairs, lbRepairsCosts);
            }


            int totalCost = 0;

            for (int i = 0; i < lbRepairsCosts.Items.Count; i++)
            {
                totalCost += Convert.ToInt32(lbRepairsCosts.Items[i].ToString());
            }

            lbRepairsTotalCost.Text = "Итоговая\nстоимость:\n" + totalCost + " рублей";

            for (int i = DateTime.Now.Year; i >= 1970; i--)
            {
                cbYearCreated.Items.Add(i);
            }

            toolStripProgressBarStatusRepairs.Maximum = clbRepairs.Items.Count;
            toolStripProgressBarStatusRepairs.Value = clbRepairs.CheckedItems.Count;
            toolStripStatusLabelInfoClient.Text = "Всего дней работы: " + quantityDaysForExtensionWorks;
        }

        private void toolStripBtAddRepair_Click(object sender, EventArgs e)
        {
            if (tbSurnameDriver.Text == "" || tbNameDriver.Text == "" || tbPatronimycDriver.Text == ""
                || tbBrandCar.Text == "" || tbModelCar.Text == "" || cbYearCreated.Text == ""
                || tbNumberSTSCar.Text == "")
            {
                MessageBox.Show("Сначала заполните/сохраните информацию о клиенте", "Ошибка");
                return;
            }

            FormAddRepairForCurrentClient farfcc = new FormAddRepairForCurrentClient(db);
            farfcc.ShowDialog();

            if (StaticData.DataBufferNameRepair != null && StaticData.DataBufferEmployee != null && StaticData.DataBufferQuantityDays != 0)
            {
                if (clbRepairs.Items.Contains(StaticData.DataBufferNameRepair))
                {
                    DialogResult dialogResult = MessageBox.Show("Вы уверены что хотите добавить уже запланированную ремонтную работу ещё раз?", "Подтверждение", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }

                //Обновление списка работ после закрытия дочерней формы
                clbRepairs.Items.Add(StaticData.DataBufferNameRepair);
                lbEmployeesRepairs.Items.Add(StaticData.DataBufferEmployee);
                toolStripStatusLabelInfoClient.Text = "Всего дней работы: " + StaticData.DataBufferQuantityDays;

                db.SearchCostRepairs(StaticData.DataBufferNameRepair, lbRepairsCosts);

                int totalCost = 0;

                for (int i = 0; i < lbRepairsCosts.Items.Count; i++)
                {
                    totalCost += Convert.ToInt32(lbRepairsCosts.Items[i].ToString());
                }

                lbRepairsTotalCost.Text = "Итоговая\nстоимость:\n" + totalCost + " рублей";

                string[] strEmployee = lbEmployeesRepairs.Items[lbEmployeesRepairs.Items.Count - 1].ToString().Split(new char[] { ' ' });
                int idEmployee = Convert.ToInt32(strEmployee[strEmployee.Length - 1]);

                string factQuery;
                factQuery = "(`work_hours_id_work_hours`, `repairs_id_repair`, `clients_id_client`, `time_start`, `quantity_days`, `status_repair`) VALUES('" +
                           db.SearchIdWorkHours(idEmployee, DateTime.Today.ToString("yyyy-MM-dd")) + "', '" +
                           db.SearchIdRepairs(clbRepairs.Items[clbRepairs.Items.Count - 1].ToString()) +
                           "', '" + idClient + "', '" + timeStartRepair + "', '" + StaticData.DataBufferQuantityDays + "', 'Не выполнено');";
                db.Add("current_repairs", factQuery);

                idCurrentRepairs.Add(db.LastIDCurrentRepairs());//Добавляем ID работы в список Id работ по клиенту

                toolStripProgressBarStatusRepairs.Maximum = clbRepairs.Items.Count;
                toolStripProgressBarStatusRepairs.Value = clbRepairs.CheckedItems.Count;
            }
        }

        private void toolStripBtPrint_Click(object sender, EventArgs e)
        {
            if (clbRepairs.Items.Count == 0)
            {
                MessageBox.Show("Внесите хотя бы одну работу для составления счёта");
                return;
            }

            if (tbNameDriver.Text == "")
            {
                MessageBox.Show("Заполните поле \"Имя клиента\"");
                return;
            }

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
            if (tbSurnameDriver.Text == "" || tbNameDriver.Text == "" || tbPatronimycDriver.Text == ""
                || tbBrandCar.Text == "" || tbModelCar.Text == "" || cbYearCreated.Text == ""
                || tbNumberSTSCar.Text == "")
            {
                MessageBox.Show("Сначала заполните/сохраните информацию о клиенте", "Ошибка");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Работа завершена?", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string[] strEmployee = lbEmployeesRepairs.SelectedItem.ToString().Split(new char[] { ' ' });
                int idEmployee = Convert.ToInt32(strEmployee[strEmployee.Length - 1]);
                int idWorkHours = db.SearchIdWorkHours(idEmployee, DateTime.Today.ToString("yyyy-MM-dd"));
                int idRepair = db.SearchIdRepairs(clbRepairs.SelectedItem.ToString());

                string timeFinishRepair = DateTime.Now.ToString("HH:mm:ss");

                db.UpdateOrInsertCurrentRepairs(idCurrentRepairs[clbRepairs.SelectedIndex], idWorkHours,
                    idRepair, idClient, timeStartRepair, timeFinishRepair, "Выполнено");

                toolStripBtFinishRepair.Enabled = false;
                toolStripBtDeleteRepair.Enabled = false;

                SetCheckState(clbRepairs.SelectedIndex, CheckState.Checked);

                toolStripProgressBarStatusRepairs.Maximum = clbRepairs.Items.Count;
                toolStripProgressBarStatusRepairs.Value = clbRepairs.CheckedItems.Count;

                string factQuery;

                factQuery = "(clients_id_client, cars_number_sts_car, repairs_id_repair, " +
                    "employees_id_employee, date, time) " +
                    "VALUES('" + idClient + "', '" + tbNumberSTSCar.Text + "', '" + idRepair + "', '" +
                    idEmployee + "', '" + DateTime.Today.ToString("yyyy-MM-dd") + "', '" + timeFinishRepair + "');";

                db.Add("performed_repairs", factQuery);
            }
        }

        private void toolStripBtDeleteRepair_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Удалить ремонтную работу?", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int index = clbRepairs.SelectedIndex;
                db.Delete("current_repairs", "id_current_repair", idCurrentRepairs[index].ToString());
                idCurrentRepairs.RemoveAt(index);
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
                toolStripBtFinishRepair.Enabled = false;

                toolStripProgressBarStatusRepairs.Maximum = clbRepairs.Items.Count;
                toolStripProgressBarStatusRepairs.Value = clbRepairs.CheckedItems.Count;
            }
        }

        private void toolStripBtSave_Click(object sender, EventArgs e)
        {
            if (tbSurnameDriver.Text == "" || tbNameDriver.Text == "" || tbPatronimycDriver.Text == ""
                || tbBrandCar.Text == "" || tbModelCar.Text == "" || cbYearCreated.Text == ""
                || tbNumberSTSCar.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка");
                return;
            }

            db.UpdateOrInsertClient(idClient, tbSurnameDriver.Text, tbNameDriver.Text, tbPatronimycDriver.Text,
                tbPhoneNumber.Text, tbBrandCar.Text, tbModelCar.Text, cbYearCreated.Text,
                tbNumberSTSCar.Text);
            tabPage.Text = tbNameDriver.Text + "/" + tbModelCar.Text;
            MessageBox.Show("Изменения сохранены");
        }

        private void tbNumberSTSCar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }

        private void toolStripBtExtension_Click(object sender, EventArgs e)
        {
            if (tbSurnameDriver.Text == "" || tbNameDriver.Text == "" || tbPatronimycDriver.Text == ""
                || tbBrandCar.Text == "" || tbModelCar.Text == "" || cbYearCreated.Text == ""
                || tbNumberSTSCar.Text == "")
            {
                MessageBox.Show("Сначала заполните/сохраните информацию о клиенте", "Ошибка");
                return;
            }

            if (clbRepairs.Items.Count == 0)
            {
                MessageBox.Show("Добавьте хотя-бы одну ремонтную работу", "Ошибка");
                return;
            }

            List<int> idCurrentRepairs = db.SearchIdCurrentRepairs(idClient);
            List<int> idEmployees = new List<int>();
            List<string[]> strEmployees = new List<string[]>();
            List<int> idWorkHours = new List<int>();
            List<int> idRepairs = new List<int>();

            for (int i = 0; i < lbEmployeesRepairs.Items.Count; i++)
            {
                strEmployees.Add(lbEmployeesRepairs.Items[i].ToString().Split(new char[] { ' ' }));
                idEmployees.Add(Convert.ToInt32(strEmployees[i][strEmployees[i].Length - 1]));

                idWorkHours.Add(db.SearchIdWorkHours(idEmployees[i], DateTime.Today.ToString("yyyy-MM-dd")));
                idRepairs.Add(db.SearchIdRepairs(clbRepairs.Items[i].ToString()));
            }

            string timeFinish = "";

            int oldIdExtentionRepair = db.SearchIdExtensionRepair(idCurrentRepairs[0], quantityDays);

            if (toolStripComboBoxQuantityDays.Text != "Количество дней" && Convert.ToInt32(toolStripComboBoxQuantityDays.Text) <= 15)
            {
                quantityDays += Convert.ToInt32(toolStripComboBoxQuantityDays.Text);
            }
            else
            {
                quantityDays++;
            }

            for (int i = 0; i < idCurrentRepairs.Count; i++)
            {
                db.AddExtentionRepairs(oldIdExtentionRepair, idCurrentRepairs[i], quantityDays);
                db.UpdateOrInsertCurrentRepairs(idCurrentRepairs[i], idWorkHours[i], idRepairs[i],
                    idClient, timeStartRepair, timeFinish, "Продлено");
            }

            toolStripStatusLabelInfoClient.Text = "Всего дней работы: " + quantityDays;
        }

        private void toolStripComboBoxQuantityDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back && (e.KeyChar != (char)Keys.Delete)))
            {
                e.Handled = true;
            }
        }

        private void tbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Delete))
            {
                e.Handled = true;
            }
        }
    }

    //Статический класс для передачи данных из дочерней формы в основную
    public static class StaticData
    {
        //Статическая переменная, выступающая как буфер данных
        public static String DataBufferNameRepair = String.Empty;
        public static String DataBufferEmployee = String.Empty;
        public static int DataBufferQuantityDays = 0;
    }
}
