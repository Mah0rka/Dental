using MySql.Data.MySqlClient;

namespace Dental
{
    public partial class Staff : Form
    {

        BD bD = new BD();

        public Staff()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var MainMenuOpen = new MainMenu();
            MainMenuOpen.Show();
            this.Hide();
            MainMenuOpen.FormClosed += (s, arg) => this.Close();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            bD.ShowTable(dataGridView1, "staff");
        }

        public void AddStaff(string firstName, string lastName, string role, string phone)
        {
            // Перевірка допустимих значень для ролі
            if (role != "Administrator" && role != "Assistant" && role != "Other")
            {
                Console.WriteLine("Невірне значення для ролі. Використовуйте 'Administrator', 'Assistant' або 'Other'.");
                return;
            }

            string query = @"
    INSERT INTO Staff (FirstName, LastName, Role, Phone)
    VALUES (@FirstName, @LastName, @Role, @Phone);";

            try
            {
                bD.OpenConaction();

                MySqlCommand command = new MySqlCommand(query, bD.Connection);

                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Role", role);
                command.Parameters.AddWithValue("@Phone", phone);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Працівник успішно доданий!");
                }
                else
                {
                    Console.WriteLine("Сталася помилка під час додавання працівника.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }

        public void DeleteStaffById(int staffId)
        {
            string query = "DELETE FROM Staff WHERE StaffID = @StaffID;";

            try
            {
                bD.OpenConaction();

                MySqlCommand command = new MySqlCommand(query, bD.Connection);
                command.Parameters.AddWithValue("@StaffID", staffId);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Працівник успішно видалений!");
                }
                else
                {
                    Console.WriteLine("Працівника з таким ID не знайдено.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }

        public void UpdateStaffById(int staffId, string firstName, string lastName, string role, string phone)
        {
            // Перевірка допустимих значень для ролі
            if (role != "Administrator" && role != "Assistant" && role != "Other")
            {
                Console.WriteLine("Невірне значення для ролі. Використовуйте 'Administrator', 'Assistant' або 'Other'.");
                return;
            }

            string query = @"
    UPDATE Staff 
    SET FirstName = @FirstName, LastName = @LastName, Role = @Role, Phone = @Phone
    WHERE StaffID = @StaffID;";

            try
            {
                bD.OpenConaction();

                MySqlCommand command = new MySqlCommand(query, bD.Connection);

                command.Parameters.AddWithValue("@StaffID", staffId);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Role", role);
                command.Parameters.AddWithValue("@Phone", phone);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Дані працівника успішно оновлені!");
                }
                else
                {
                    Console.WriteLine("Працівника з таким ID не знайдено.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }


        private void button_add_data_Click(object sender, EventArgs e)
        {
            AddStaff(textBox_FirstName.Text, textBox_LastName.Text, listBox_Role.SelectedItem?.ToString(), textBox_Phone.Text);
            bD.ShowTable(dataGridView1, "staff");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateStaffById(int.Parse(textBox_IDD.Text), textBox_FirstName.Text, textBox_LastName.Text, listBox_Role.SelectedItem?.ToString(), textBox_Phone.Text);
            bD.ShowTable(dataGridView1, "staff");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DeleteStaffById(int.Parse(textBox1.Text));
            bD.ShowTable(dataGridView1, "staff");
        }
    }
}
