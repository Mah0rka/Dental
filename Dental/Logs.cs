using MySql.Data.MySqlClient;

namespace Dental
{
    public partial class Logs : Form
    {

        BD bD = new BD();
        public Logs()
        {
            InitializeComponent();
        }

        private void Logs_Load(object sender, EventArgs e)
        {
            bD.ShowTable(dataGridView1, "logs");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var MainMenuOpen = new MainMenu();
            MainMenuOpen.Show();
            this.Hide();
            MainMenuOpen.FormClosed += (s, arg) => this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var staff = new Staff();
            staff.Show();
        }

        public void AddLog(string action, DateTime timestamp, int staffId)
        {
            string query = @"
    INSERT INTO Logs (Action, Timestamp, StaffID)
    VALUES (@Action, @Timestamp, @StaffID);";

            try
            {
                bD.OpenConaction();

                MySqlCommand command = new MySqlCommand(query, bD.Connection);

                command.Parameters.AddWithValue("@Action", action);
                command.Parameters.AddWithValue("@Timestamp", timestamp);
                command.Parameters.AddWithValue("@StaffID", staffId);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Запис успішно додано до журналу!");
                }
                else
                {
                    Console.WriteLine("Сталася помилка під час додавання запису.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }

        public void DeleteLogById(int logId)
        {
            string query = "DELETE FROM Logs WHERE LogID = @LogID;";

            try
            {
                bD.OpenConaction();

                MySqlCommand command = new MySqlCommand(query, bD.Connection);
                command.Parameters.AddWithValue("@LogID", logId);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Запис успішно видалено з журналу!");
                }
                else
                {
                    Console.WriteLine("Запис з таким ID не знайдено.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }

        public void UpdateLogById(int logId, string action, DateTime timestamp, int staffId)
        {
            string query = @"
    UPDATE Logs
    SET Action = @Action, Timestamp = @Timestamp, StaffID = @StaffID
    WHERE LogID = @LogID;";

            try
            {
                bD.OpenConaction();

                MySqlCommand command = new MySqlCommand(query, bD.Connection);

                command.Parameters.AddWithValue("@LogID", logId);
                command.Parameters.AddWithValue("@Action", action);
                command.Parameters.AddWithValue("@Timestamp", timestamp);
                command.Parameters.AddWithValue("@StaffID", staffId);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Запис журналу успішно оновлено!");
                }
                else
                {
                    Console.WriteLine("Запис з таким ID не знайдено.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }

        public DateTime ProcessDateTime(string dateText)
        {
                DateTime dateTime = DateTime.Parse(dateText);

                return dateTime;
        }

        private void button_add_data_Click(object sender, EventArgs e)
        {
            AddLog(textBox_Action.Text, ProcessDateTime(textBox_Date_time.Text), int.Parse(textBox_StaffID.Text));
            bD.ShowTable(dataGridView1, "logs");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateLogById(int.Parse(textBox_IDD.Text),textBox_Action.Text, ProcessDateTime(textBox_Date_time.Text), int.Parse(textBox_StaffID.Text));
            bD.ShowTable(dataGridView1, "logs");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DeleteLogById(int.Parse(textBox1.Text));
            bD.ShowTable(dataGridView1, "logs");
        }
    }
}
