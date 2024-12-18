using MySql.Data.MySqlClient;
using System.Data;

namespace Dental
{
    public class BD : IDisposable
    {
        private MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=1234;database=dentalcompany;");

        public MySqlConnection Connection => connection;

        public void OpenConaction()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConaction()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        // IDisposable
        public void Dispose()
        {
            CloseConaction();
            if (connection != null)
            {
                connection.Dispose();
                connection = null;
            }
        }

        public void ShowTable(DataGridView dataGrid, string table)
        {

            BD bD = new BD();

            string query = $"SELECT * FROM `{table}`";
            try
            {
                bD.OpenConaction();

                // Створюємо DataAdapter для заповнення даних
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, bD.Connection);

                // Створюємо DataTable, щоб зберегти дані
                DataTable dataTable = new DataTable();

                // Заповнюємо DataTable даними з бази
                dataAdapter.Fill(dataTable);

                // Встановлюємо DataSource для DataGridView
                dataGrid.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }
    }
}
