using System;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Linq;

namespace DbExplorer
{
    public partial class Window : Form
    {
        /* Рядок з'єднання [driver={name from ODBC Manager};server=serverName;
        database=dbName;trusted_connection=yes(Windows Auth)] */
        readonly string ConnectionString = @"Driver={ODBC Driver 17 for SQL Server};Server=.\SQLEXPRESS;" +
                           "Database=Store;Trusted_Connection=yes;";
        readonly TextBox[] InBoxes; // посилання на поля вводу
        string LastTable = "";     // остання задіяна таблиця
        public DBApi Db { get; private set; } // інтерфейс роботи з БД

        public Window()
        {
            InitializeComponent();
            OperationBox.SelectedIndex = 0;
            Db = new DBApi(ConnectionString);
            InBoxes = new TextBox[]
            {
                SelectBox, FromBox, WhereBox, GroupBox, OrderBox
            };

            foreach (var name in Db.GetTableNames())
                FromTableMenu.Items.Add(name);
        }

        /// <summary> Перевірка TextBox на порожнє значення</summary>
        readonly Predicate<TextBox> BoxIsEmpty = sender => sender.Text == "";

        /// <summary> Перевірка чи string є цілим числом </summary>
        /// <remarks> Використовується при перевірці результату запиту</remarks>
        readonly Predicate<string> LogIsNumber = log => log.All(c => char.IsDigit(c));

        /// <summary> Заповнення DataGridView даними з вибірки </summary>
        /// <param name="data">вибірка з select-запиту і звіт</param>
        private string TableFill((DataTable table, string log) data)
        {
            TableGrid.DataSource = data.table;
            TableGrid.Tag = TableGrid.Rows.Count; // кількість рядків зараз
            var success = LogIsNumber(data.log) && data.table != null;
            StatusColorChange(success);
            return success ? $"Вибірка оновлена: {data.log} рядків" : data.log;
        }

        /// <summary> Виконання запиту </summary>
        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            if (OwnQueryCheck.Checked) // власний запит
            {
                var parseQuery = OwnQueryBox.Text.Split().Select(w => w.ToLower()).ToList();
                StatusBox.Text = parseQuery[0] == "select"
                        ? TableFill(Db.Select(OwnQueryBox.Text)) : Db.Action(OwnQueryBox.Text);
                if (parseQuery[0] == "select")
                    LastTable = parseQuery.ElementAtOrDefault(parseQuery.IndexOf("from") + 1);
                return;
            }

            SelectBox.Text = SelectBox.Text != "" ? SelectBox.Text : "*";
            (int i, string columns) = (OperationBox.SelectedIndex, SelectBox.Text);
            var query = i == 0 ? $"SELECT {columns} FROM {FromBox.Text}" :
                (i == 1 ? $"INSERT INTO {FromBox.Text} VALUES ({columns})" :
                (i == 2 ? $"UPDATE {FromBox.Text} SET {SelectBox.Text}" : $"DELETE FROM {FromBox.Text}"));

            if (i != 1 && !BoxIsEmpty(WhereBox))
                query += $" WHERE {WhereBox.Text}";
            if (i == 0 && !BoxIsEmpty(GroupBox))
                query += $" GROUP BY {GroupBox.Text}";
            if (i == 0 && !BoxIsEmpty(OrderBox))
                query += $" ORDER BY {OrderBox.Text}";

            if (i == 0)
            {
                StatusBox.Text = TableFill(Db.Select(query));
                LastTable = FromBox.Text;
            }
            else
            {
                var log = Db.Action(query);
                StatusBox.Text = LogIsNumber(log) ? $"Використано {log} рядків" : log;
                StatusColorChange(LogIsNumber(log));
                if (i == 2)
                    Db.CheckIdent(FromBox.Text); // перевірка правильної ідентифікації
            }
        }

        /// <summary> Кнопка очищення всіх полів </summary>
        private void AllClearButton_Click(object sender, EventArgs e)
        {
            foreach (var box in InBoxes)
                box.Text = box.Tag as string;
            OwnQueryBox.Clear();
        }

        /// <summary> Безпосереднє рагування таблиць БД у DataGridView </summary>
        private void EditButton_Click(object sender, EventArgs e)
        {
            (var exp, var log) = (LastTable != "" && TableGrid.DataSource != null, "");
            if (exp)
            {
                log = Db.Update(TableGrid.DataSource as DataTable); // оновлення з виводу
                StatusBox.Text = LogIsNumber(log) ? $"Використано {log} рядків" : log;
                _ = int.TryParse(TableGrid.Tag.ToString(), out int rows);
                if (TableGrid.Rows.Count < rows && LastTable != "") // відбулося видалення рядків
                    Db.CheckIdent(LastTable);
            }
            else
                StatusBox.Text = "Немає таблиці для оновлення";
            StatusColorChange(exp && LogIsNumber(log));
        }

        /// <summary> Кнопка очищення виводу </summary>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            (TableGrid.DataSource, LastTable) = (null, ""); // очищення виводу
            (StatusBox.ForeColor, StatusBox.Text) = (Color.Green, "Вивід очищено");
        }

        /// <summary> Зміна кольору поля статусу, !потребує System.Drawing </summary>
        /// <param name="success">true -> Green, false -> Red</param>
        private void StatusColorChange(bool success = true)
        {
            StatusBox.ForeColor = success ? Color.Green : Color.Red;
        }

        /// <summary> Динамічна заміна тексту міток і зміна їх стану </summary>
        private void OperationChanged_Event(object sender, EventArgs e) // !Event
        {
            // i: 0 – SELECT, 1 – INSERT, 2 – UPDATE, 3 - DELETE
            int i = (sender as ComboBox).SelectedIndex; // обраний елемент
            FromIntoLabel.Text = i == 1 ? "INTO" : (i == 2 ? "TABLE" : "FROM"); // INSERT: "INTO", UPDATE: "TABLE"

            // Зміна стану окремих полів вводу
            (SelectBox.Enabled, WhereBox.Enabled, GroupBox.Enabled, OrderBox.Enabled) = i == 0 ?
            (true, true, true, true) : (i == 1 ? (true, false, false, false) :
            (i == 2 ? (true, true, false, false) : (false, true, false, false)));
        }

        /// <summary> Оновлення списку стовпців у контекстному меню </summary>
        private void UpdateColumnsMenu_DoubleClick(object sender, EventArgs e)
        {
            ColumnsMenu.Items.Clear();
            foreach (var column in Db.GetColumns(FromBox.Text))
                ColumnsMenu.Items.Add(column);
        }

        /// <summary> Натискання на елемент меню таблиць </summary>
        private void FromMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            FromBox.Text = e.ClickedItem.Text;
            FromBox.SelectionLength = FromBox.Text.Length;
        }

        private void ColumnsMenu_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            SelectBox.Text += e.ClickedItem.Text;
            SelectBox.SelectionStart = SelectBox.Text.Length;
        }
    }
}