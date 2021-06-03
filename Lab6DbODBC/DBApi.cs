using System;
using System.Data;
using System.Collections.Generic;
using System.Data.Odbc;

namespace DbExplorer
{
    /// <summary> Методи доступу до бази даних </summary>
    public class DBApi
    {
        protected OdbcConnection Connection; // з'єднання з базою
        protected OdbcCommand Command;      // команда для заповнення
        protected OdbcDataAdapter Adapter; // адаптер для з'єднання БД і джерела даних
        protected DataTable DataSource;   // програмна таблиця для заповнення з БД

        /// <param name="connectionString">Рядок з'єднання</param>
        public DBApi(string connectionString)
        {
            Connection = new OdbcConnection(connectionString);
            Command = Connection.CreateCommand();
        }

        /// <summary> Вибірка </summary>
        /// <param name="query">Запит</param>
        /// <returns>Кортеж з отриманою таблицею та результатом</returns>
        public (DataTable dataSource, string log) Select(string query)
        {
            (DataSource, Adapter) = (new DataTable(), new OdbcDataAdapter(query, Connection));
            try
            {
                Connection.Open(); // !
                Adapter.Fill(DataSource);
            }
            catch (OdbcException e)
            {
                return (null, e.ToString());
            }
            finally
            {
                Connection.Close();
            }

            return (DataSource, DataSource.Rows.Count.ToString());
        }

        /// <summary> Операції, що не повертають вибірку </summary>
        /// <returns>Кількість задіяних рядків</returns>
        public string Action(string query)
        {
            Command.CommandText = query;
            int rows;
            try
            {
                Connection.Open(); // !
                rows = Command.ExecuteNonQuery();
            }
            catch (OdbcException e)
            {
                return e.ToString();
            }
            finally
            {
                Connection.Close();
            }

            return rows.ToString();
        }

        /// <summary> Оновлення таблиці </summary>
        /// <param name="edited">Змінена таблиця</param>
        public string Update(DataTable edited)
        {
            try
            {
                Adapter.UpdateCommand = new OdbcCommandBuilder(Adapter).GetUpdateCommand();
                return Adapter.Update(edited).ToString();
            }
            catch (System.InvalidOperationException e)
            {
                return e.ToString();
            }
        }

        /// <summary> Перевірка ідентифікації (повертає до 0) </summary>
        /// <param name="table">таблиця</param>
        public void CheckIdent(string table)
        {
            Command.CommandText = "SELECT max(id) FROM " + table;
            Connection.Open();
            int.TryParse(Command.ExecuteScalar().ToString(), out int maxId);

            Command.CommandText = $"DBCC CHECKIDENT ('{table}', RESEED, {maxId})";
            Command.ExecuteNonQuery();

            Connection.Close();
        }

        /// <summary> Отримати прочитаний список із запиту</summary>
        /// <param name="query">SELECT-запит</param>
        /// <param name="index">індекс елементу в читачі</param>
        List<string> GetReaderList(string query, int index = 0)
        {
            Command.CommandText = query;
            Connection.Open();
            (var values, var reader) = (new List<string>(), Command.ExecuteReader());
            while (reader.Read())
                values.Add(reader[index].ToString());
            Connection.Close();
            return values;
        }

        /// <summary> Отримати список таблиць бази даних </summary>
        public List<string> GetTableNames()
        {
            // альтернативно можна використати GetSchema("Tables")
            return GetReaderList("SELECT * FROM information_schema.tables", 2);
        }

        /// <summary> Отримати список стовбців таблиці</summary>
        public List<string> GetColumns(string tableName)
        {
            return GetReaderList("SELECT * FROM information_schema.columns " +
                $"WHERE table_name = N'{tableName}'", 3);
        }
    }
}
