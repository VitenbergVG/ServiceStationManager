using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceStationManager
{
    class ClassDB
    {
        public MySqlConnection conn;

        public ClassDB(string ipDB, string portDB, string loginDB, string passDB)
        {
            conn = GetDBConnection(ipDB, Convert.ToInt32(portDB), "sto_db", loginDB, passDB);
        }

        //Подключение к БД
        public static MySqlConnection GetDBConnection(string host, int port, string database, string username, string password)
        {
            String connString = "Server=" + host + ";Database=" + database
                 + ";port=" + port + ";User Id=" + username + ";password=" + password + ";CharSet=utf8";//;SslMode=none

            MySqlConnection connect = new MySqlConnection(connString);
            return connect;
        }

        //Заполнение таблицы datagridview данными
        public List<string[]> LoadTables(string table, DataGridView dataSource)
        {
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM " + table, conn);
            List<string[]> data = new List<string[]>();
            MySqlDataReader reader = command.ExecuteReader();

            int count = dataSource.ColumnCount;
            while (reader.Read())
            {
                data.Add(new string[count]);
                for (int i = 0; i < count; i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
            }
            reader.Close();
            conn.Close();
            foreach (string[] s in data)
            {
                dataSource.Rows.Add(s);
            }
            return data;
        }

        //Удаление элементов
        public int Delete(string table, string columnID, DataGridView dataSource)//Вернет 0 в случае ошибки и 1 в случае если все норм
        {
            conn.Open();
            MySqlCommand command = new MySqlCommand("DELETE FROM " + table + " WHERE " + columnID + " = '"
                + dataSource.CurrentRow.Cells[0].Value.ToString() + "';", conn);
            try
            {
                MySqlDataReader reader = command.ExecuteReader();
                reader.Close();
                conn.Close();
            }
            catch
            {
                conn.Close();
                return 0;
            }

            return 1;
        }

        //Добавление элементов
        public void Add(string table, string query)
        {
            conn.Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO " + table + query, conn);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Close();
            conn.Close();
        }

        //Поиск по таблице машин
        public List<string[]> SearchInCars(string str, DataGridView dataSource)
        {
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM cars WHERE number_sts LIKE '%" + str +
                "%' OR brand LIKE '%" + str +
                "%' OR model LIKE '%" + str +
                "%' OR year_created LIKE '%" + str +
                "%' OR date_to LIKE '%" + str +
                "%';", conn);
            List<string[]> data = new List<string[]>();
            MySqlDataReader reader = command.ExecuteReader();

            int count = dataSource.ColumnCount;
            while (reader.Read())
            {
                data.Add(new string[count]);
                for (int i = 0; i < count; i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
            }
            reader.Close();
            conn.Close();
            foreach (string[] s in data)
            {
                dataSource.Rows.Add(s);
            }
            return data;
        }

        //Поиск данных по клиенту
        public List<string[]> SearchInClients(string str, DataGridView dataSource)
        {
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT * FROM clients WHERE id_client LIKE '%" + str +
                "%' OR surname LIKE '%" + str +
                "%' OR name LIKE '%" + str +
                "%' OR patronimyc LIKE '%" + str +
                "%' OR cars_number_sts LIKE '%" + str +
                "%';", conn);
            List<string[]> data = new List<string[]>();
            MySqlDataReader reader = command.ExecuteReader();

            int count = dataSource.ColumnCount;
            while (reader.Read())
            {
                data.Add(new string[count]);
                for (int i = 0; i < count; i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
            }
            reader.Close();
            conn.Close();
            foreach (string[] s in data)
            {
                dataSource.Rows.Add(s);
            }
            return data;
        }

        //Прсомотр информации о машине клиента
        public List<string[]> ShowInfoCar(DataGridView dataSource, string curRow)
        {
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT clients.id_client, cars.model, cars.brand FROM clients" +
                " JOIN cars ON clients.cars_number_sts = cars.number_sts WHERE clients.id_client = '" + curRow + "'", conn);
            List<string[]> data = new List<string[]>();
            MySqlDataReader reader = command.ExecuteReader();

            int count = dataSource.ColumnCount;
            while (reader.Read())
            {
                data.Add(new string[count]);
                for (int i = 0; i < count; i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
            }
            reader.Close();
            conn.Close();
            foreach (string[] s in data)
            {
                dataSource.Rows.Add(s);
            }
            return data;
        }

        //Поиск номеров СТС машин
        public void SearchSTSCars(ComboBox dataSource)
        {
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT number_sts FROM cars", conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                dataSource.Items.Add(reader[0].ToString());
            }
            reader.Close();
            conn.Close();
        }

        //Поиск должностей в таблице должностей
        public void SearchPosition(ComboBox dataSource)
        {
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT position FROM position", conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                dataSource.Items.Add(reader[0].ToString());
            }
            reader.Close();
            conn.Close();
        }

        //Категории ремонтных работ
        public void SearchCategoriesRepairs(ComboBox dataSource)
        {
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT name_categories_repairs FROM categories_repairs", conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                dataSource.Items.Add(reader[0].ToString());
            }
            reader.Close();
            conn.Close();
        }

        //Смена названий заголовков строк в таблице на неповторяющиеся фамилии сотрудников
        public void WorkHoursNameEmployees(DataGridView dataSource, List<int> idEmployees, List<string> surnameEmployees, List<DateTime> dates)
        {
            dataSource.Rows.Clear();
            WorkHoursSettingDays(dates);//Заполнение таблицы дат в БД
            conn.Open();

            MySqlCommand command = new MySqlCommand("SELECT distinct surname, id_employee FROM employees", conn);//получение всех неповторяющихся сотрудников(их фамилий и id)

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int indexRow = dataSource.Rows.Add();
                dataSource.Rows[indexRow].HeaderCell.Value = reader[0].ToString();
                dataSource.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;

                surnameEmployees.Add(reader[0].ToString());
                idEmployees.Add(Convert.ToInt32(reader[1].ToString()));
            }

            conn.Close();//Закрываем соединение для того чтобы метод Works открыл новое соединение и мог стабильно работать

            for (int i = 0; i < dataSource.RowCount; i++)
            {
                for (int j = 0; j < dataSource.ColumnCount; j++)
                {
                    dataSource.Rows[i].Cells[j].Value = Works(idEmployees[i], dates[j].ToString("yyyy-MM-dd"));
                }
            }

            reader.Close();
        }

        //Добавление дат на месяц и удаление ненужных дат, смен и работ в эти даты
        public void WorkHoursSettingDays(List<DateTime> dates)
        {
            conn.Open();
            string values = "";

            for (int i = 0; i < dates.Count() - 1; i++)
            {
                values += "('" + dates[i].ToString("yyyy-MM-dd") + "'), ";
            }

            values += "('" + dates[dates.Count() - 1].ToString("yyyy-MM-dd") + "')";


            string valuesDelete = "";

            for (int i = 0; i < dates.Count() - 1; i++)
            {
                valuesDelete += "dates_of_month != '" + dates[i].ToString("yyyy-MM-dd") + "' and ";
            }

            valuesDelete += "dates_of_month != '" + dates[dates.Count() - 1].ToString("yyyy-MM-dd") + "'";

            MySqlCommand command = new MySqlCommand("delete t1 "
                + "from current_repairs t1 "
                + "join work_hours on work_hours.id_work_hours = t1.work_hours_id_work_hours and work_hours." + valuesDelete + "; "
                + "delete from work_hours where " + valuesDelete + ";"
                + "delete from dates_of_month where " + valuesDelete + ";"
                + "INSERT IGNORE INTO `sto_db`.dates_of_month (`dates_of_month`) VALUES " + values + ";", conn);//Добавить несколько дат из списка
            MySqlDataReader reader = command.ExecuteReader();
            reader.Close();
            conn.Close();
        }

        //Поиск среди всех дат и сотрудников рабочих смен
        public string Works(int id, string date)
        {
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT id_work_hours FROM sto_db.work_hours where employees_id_employee = '" + id
                + "' and dates_of_month = '" + date + "';", conn);
            MySqlDataReader reader = command.ExecuteReader();

            string result = "";

            while (reader.Read())
            {
                result = reader[0].ToString();
                result = "Работает";
            }

            reader.Close();
            conn.Close();

            return result;
        }

        //Смена названий заголовков строк в таблице на неповторяющиеся фамилии сотрудников для расписания работ
        public void WorkHoursRepairsNameEmployees(DataGridView dataSource, List<int> idEmployees, List<string> surnameEmployees, List<DateTime> dates)
        {
            dataSource.Rows.Clear();
            WorkHoursSettingDays(dates);//Заполнение таблицы дат в БД
            conn.Open();

            MySqlCommand command = new MySqlCommand("SELECT distinct surname, id_employee FROM employees", conn);//получение всех неповторяющихся сотрудников(их фамилий и id)

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int indexRow = dataSource.Rows.Add();
                dataSource.Rows[indexRow].HeaderCell.Value = reader[0].ToString();
                dataSource.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;

                surnameEmployees.Add(reader[0].ToString());
                idEmployees.Add(Convert.ToInt32(reader[1].ToString()));
            }

            reader.Close();
            conn.Close();

            int idWorkHours;

            for (int i = 0; i < dataSource.RowCount; i++)
            {
                for (int j = 0; j < dataSource.ColumnCount; j++)
                {
                    idWorkHours = SearchIdWorkHours(idEmployees[i], dates[j].ToString("yyyy-MM-dd"));
                    dataSource.Rows[i].Cells[j].Value = CurrentRepairs(idWorkHours);
                }
            }
        }

        //Конкретная ремонтная работа
        public string CurrentRepairs(int idWorkHours)
        {
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT clients.surname, repairs.name FROM current_repairs " +
                "JOIN clients ON current_repairs.clients_id_client = clients.id_client " +
                "JOIN repairs ON current_repairs.repairs_id_repair = repairs.id_repair " +
                "where work_hours_id_work_hours = '" + idWorkHours + "';", conn);
            MySqlDataReader reader = command.ExecuteReader();

            string result = "";

            while (reader.Read())
            {
                result += reader[0].ToString() + " - " + reader[1].ToString() + "\n";
            }

            reader.Close();
            conn.Close();

            return result;
        }

        //Поиск ID рабочих смен в таблице work_hours(рабочих смен)
        public int SearchIdWorkHours(int idEmployee, string date)
        {
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT id_work_hours FROM work_hours WHERE employees_id_employee = '" + idEmployee + "'" +
                " and dates_of_month = '" + date + "';", conn);
            MySqlDataReader reader = command.ExecuteReader();

            int resId = 0;

            while (reader.Read())
            {
                resId = Convert.ToInt32(reader[0].ToString());
            }
            reader.Close();
            conn.Close();
            return resId;
        }

        //Удаление в таблице work_hours(рабочих смен)
        public int DeleteFromWorkHours(int idEmployee, string date)
        {
            conn.Open();

            MySqlCommand command = new MySqlCommand("SET SQL_SAFE_UPDATES = 0; " +
                "DELETE FROM current_repairs WHERE work_hours_id_work_hours IN" +
                "(SELECT id_work_hours FROM work_hours WHERE employees_id_employee = '" + idEmployee + "' and dates_of_month = '" + date + "'); " +
                "DELETE FROM work_hours WHERE employees_id_employee = '" + idEmployee + "' and dates_of_month = '" + date + "'; ", conn);
            MySqlDataReader reader = command.ExecuteReader();

            int resId = 0;

            while (reader.Read())
            {
                resId = Convert.ToInt32(reader[0].ToString());
            }
            reader.Close();
            conn.Close();
            return resId;
        }

        //ID ремонтной работы по ее названию
        public int SearchIdRepairs(string name)
        {
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT id_repair FROM `sto_db`.repairs WHERE name = '" + name + "'", conn);
            MySqlDataReader reader = command.ExecuteReader();

            int resId = 0;

            while (reader.Read())
            {
                resId = Convert.ToInt32(reader[0].ToString());
            }

            reader.Close();
            conn.Close();

            return resId;
        }

        //Все ремонтные работы в категории
        public void SearchNameRepairs(string category, ComboBox dataSource)
        {
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT name FROM " +
                "repairs WHERE category = '" + category + "'", conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                dataSource.Items.Add(reader[0].ToString());
            }
            reader.Close();
            conn.Close();
        }

        //Прсомотр информации о конкретной работе
        public List<string[]> ShowInfoCurrentRepair(string surnameEmployee, string date, DataGridView dataSource)
        {
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT repairs.name , clients.surname, cars.brand, cars.model, employees.surname, " +
                "employees.position_position, work_hours.dates_of_month, time_start, time_finish FROM current_repairs " +
                "join work_hours on current_repairs.work_hours_id_work_hours = work_hours.id_work_hours " +
                "join repairs on current_repairs.repairs_id_repair = repairs.id_repair " +
                "join clients on current_repairs.clients_id_client = clients.id_client " +
                "join cars on clients.cars_number_sts = cars.number_sts " +
                "join employees on work_hours.employees_id_employee = employees.id_employee " +
                "where work_hours.dates_of_month = '" + date + "' and employees.surname = '" + surnameEmployee + "';", conn);
            List<string[]> data = new List<string[]>();
            MySqlDataReader reader = command.ExecuteReader();

            int count = dataSource.ColumnCount;
            while (reader.Read())
            {
                data.Add(new string[count]);
                for (int i = 0; i < count; i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
            }
            reader.Close();
            conn.Close();
            foreach (string[] s in data)
            {
                dataSource.Rows.Add(s);
            }
            return data;
        }

        //Поиск данных по рабочим сменам
        public List<string[]> SearchInWorkHours(string str, DataGridView dataSource)
        {
            conn.Open();

            MySqlCommand command = new MySqlCommand("SELECT id_work_hours, dates_of_month, employees.surname, employees.position_position " +
                "FROM work_hours " +
                "JOIN employees ON work_hours.employees_id_employee = employees.id_employee " +
                "WHERE id_work_hours LIKE '%" + str +
                "%' OR dates_of_month LIKE '%" + str +
                "%' OR surname LIKE '%" + str +
                "%' OR position_position LIKE '%" + str +
                "%';", conn);

            List<string[]> data = new List<string[]>();
            MySqlDataReader reader = command.ExecuteReader();

            int count = dataSource.ColumnCount;
            while (reader.Read())
            {
                data.Add(new string[count]);
                for (int i = 0; i < count; i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
            }
            reader.Close();
            conn.Close();
            foreach (string[] s in data)
            {
                dataSource.Rows.Add(s);
            }
            return data;
        }

        //Поиск данных по рабочим сменам для их дальнейшего выбора, с доп. информацией по работающему сотруднику
        public List<string[]> SearchWorkHoursForPic(DataGridView dataSource)
        {
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT id_work_hours, dates_of_month, employees.surname, employees.position_position FROM work_hours " +
                "JOIN employees ON work_hours.employees_id_employee = employees.id_employee; ", conn);
            List<string[]> data = new List<string[]>();
            MySqlDataReader reader = command.ExecuteReader();

            int count = dataSource.ColumnCount;
            while (reader.Read())
            {
                data.Add(new string[count]);
                for (int i = 0; i < count; i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
            }
            reader.Close();
            conn.Close();
            foreach (string[] s in data)
            {
                dataSource.Rows.Add(s);
            }
            return data;
        }

        //максимальное ID среди всех ремонтных работ в таблице repairs
        public int LastRepair()
        {
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT MAX(id_repair) FROM repairs", conn);
            MySqlDataReader reader = command.ExecuteReader();

            int resId = 0;

            while (reader.Read())
            {
                resId = Convert.ToInt32(reader[0].ToString());
            }

            reader.Close();
            conn.Close();

            return resId;
        }

        //Поиск сотрудников которые могут выполнять определенную работу и работают в данный момент
        public void SearchSurnameEmployeesForRepair(ComboBox dataSource, string nameRepair)
        {
            conn.Open();

            DateTime today = DateTime.Today;

            MySqlCommand command = new MySqlCommand("SELECT employees.surname, employees.id_employee FROM repairs " +
                "JOIN employees ON repairs.position_position = employees.position_position " +
                "JOIN work_hours ON employees.id_employee = work_hours.employees_id_employee " +
                "WHERE repairs.name = '" + nameRepair + "' and work_hours.dates_of_month = '" + today.ToString("yyyy-MM-dd") + "'; ", conn);

            //MySqlCommand command = new MySqlCommand("SELECT employees.surname FROM repairs " +
            //    "JOIN employees ON repairs.position_position = employees.position_position " +
            //    "WHERE repairs.name = '" + nameRepair + "'; ", conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                dataSource.Items.Add(reader[0].ToString() + "/id: " + reader[1].ToString());
            }
            reader.Close();
            conn.Close();
        }

        //Цена выбранной ремонтной работы
        public void SearchCostRepairs(string name, ListBox dataSource)
        {
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT cost FROM `sto_db`.repairs WHERE name = '" + name + "'", conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                dataSource.Items.Add(reader[0].ToString());
            }
            reader.Close();
            conn.Close();
        }

        //Информация по выбранному клиенту
        public void ShowPickedClient(string curRow, string atribute, TextBox tbSource)
        {
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT " + atribute + " FROM sto_db.clients WHERE id_client = '" + curRow + "'", conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                tbSource.Text = reader[0].ToString();
            }
            reader.Close();
            conn.Close();
        }

        //Информация по выбранной машине
        public void ShowPickedCar(string curRow, string atribute, TextBox tbSource)
        {
            conn.Open();
            MySqlCommand command = new MySqlCommand("SELECT cars." + atribute + " FROM clients " +
                "JOIN cars ON clients.cars_number_sts = cars.number_sts WHERE clients.id_client = '" + curRow + "'", conn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                tbSource.Text = reader[0].ToString();
            }
            reader.Close();
            conn.Close();
        }

        //Добавить или редактировать информацию о клиеенте и его автомобиле
        public void UpdateOrInsertClient(string idClient, string surname, string name, string patronimyc,
            string phoneNumber, string brand, string model, string yearCreated, string numSTS)
        {
            conn.Open();
            MySqlCommand command = new MySqlCommand("INSERT INTO cars SET number_sts = '" + numSTS + "', " +
                "brand = '" + brand + "', model = '" + model + "', year_created = '" + yearCreated + "' " +
                "ON DUPLICATE KEY UPDATE number_sts = '" + numSTS + "', " +
                "brand = '" + brand + "', model = '" + model + "', year_created = '" + yearCreated + "';" +
                "INSERT INTO clients SET id_client = '" + idClient + "', surname = '" + surname + "', " +
                "name = '" + name + "', patronimyc = '" + patronimyc + "', phone_number = '" + phoneNumber + 
                "', cars_number_sts = '" + numSTS + "' " +
                "ON DUPLICATE KEY UPDATE surname = '" + surname + "', " +
                "name = '" + name + "', patronimyc = '" + patronimyc + "', phone_number = '" + phoneNumber + 
                "', cars_number_sts = '" + numSTS + "';", conn);
            MySqlDataReader reader = command.ExecuteReader();
            reader.Close();
            conn.Close();
        }
    }
}
