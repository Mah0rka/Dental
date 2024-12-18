using MySql.Data.MySqlClient;

namespace Dental
{
    public partial class Dentists : Form
    {

        BD bD = new BD();

        public Dentists()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var MainMenuOpen = new MainMenu();
            MainMenuOpen.Show();
            this.Hide();
            MainMenuOpen.FormClosed += (s, arg) => this.Close();
        }

        private void Dentists_Load(object sender, EventArgs e)
        {
            bD.ShowTable(dataGridView1, "dentists");
        }

        public void AddDentist(string firstName, string lastName, string specialization, string phone)
        {
            string query = @"
                INSERT INTO dentists (FirstName, LastName, Specialization, Phone)
                VALUES (@FirstName, @LastName, @Specialization, @Phone);";

            try
            {
                bD.OpenConaction();

                using (MySqlCommand command = new MySqlCommand(query, bD.Connection))
                {
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Specialization", specialization);
                    command.Parameters.AddWithValue("@Phone", phone);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Стоматолога успішно додано!");
                    }
                    else
                    {
                        MessageBox.Show("Не вдалося додати стоматолога.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
            finally
            {
                bD.CloseConaction();
            }
        }

        public void DeleteDentist(int? id = null, string firstName = null, string lastName = null, string phone = null)
        {
            string query = "DELETE FROM dentists WHERE 1=1";

            if (id.HasValue) query += " AND DentistID = @DentistID";
            if (!string.IsNullOrEmpty(firstName)) query += " AND FirstName = @FirstName";
            if (!string.IsNullOrEmpty(lastName)) query += " AND LastName = @LastName";
            if (!string.IsNullOrEmpty(phone)) query += " AND Phone = @Phone";

            try
            {
                bD.OpenConaction();

                using (MySqlCommand command = new MySqlCommand(query, bD.Connection))
                {
                    if (id.HasValue) command.Parameters.AddWithValue("@DentistID", id.Value);
                    if (!string.IsNullOrEmpty(firstName)) command.Parameters.AddWithValue("@FirstName", firstName);
                    if (!string.IsNullOrEmpty(lastName)) command.Parameters.AddWithValue("@LastName", lastName);
                    if (!string.IsNullOrEmpty(phone)) command.Parameters.AddWithValue("@Phone", phone);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Стоматолога успішно видалено! Видалено записів: {rowsAffected}");
                    }
                    else
                    {
                        MessageBox.Show("Не знайдено записів для видалення.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
            finally
            {
                bD.CloseConaction();
            }
        }

        public void UpdateDentist(int id, string firstName = null, string lastName = null, string specialization = null, string phone = null)
        {
            string query = "UPDATE dentists SET ";
            List<string> updates = new List<string>();

            if (!string.IsNullOrEmpty(firstName)) updates.Add("FirstName = @FirstName");
            if (!string.IsNullOrEmpty(lastName)) updates.Add("LastName = @LastName");
            if (!string.IsNullOrEmpty(specialization)) updates.Add("Specialization = @Specialization");
            if (!string.IsNullOrEmpty(phone)) updates.Add("Phone = @Phone");

            if (updates.Count == 0)
            {
                MessageBox.Show("Не вказано жодного поля для оновлення.");
                return;
            }

            query += string.Join(", ", updates) + " WHERE DentistID = @DentistID";

            try
            {
                bD.OpenConaction();

                using (MySqlCommand command = new MySqlCommand(query, bD.Connection))
                {
                    if (!string.IsNullOrEmpty(firstName)) command.Parameters.AddWithValue("@FirstName", firstName);
                    if (!string.IsNullOrEmpty(lastName)) command.Parameters.AddWithValue("@LastName", lastName);
                    if (!string.IsNullOrEmpty(specialization)) command.Parameters.AddWithValue("@Specialization", specialization);
                    if (!string.IsNullOrEmpty(phone)) command.Parameters.AddWithValue("@Phone", phone);
                    command.Parameters.AddWithValue("@DentistID", id);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Дані стоматолога успішно оновлені!");
                    }
                    else
                    {
                        MessageBox.Show("Стоматолога з таким ID не знайдено.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
            finally
            {
                bD.CloseConaction();
            }
        }

        private void button_add_data_Click(object sender, EventArgs e)
        {
            AddDentist(textBox_name.Text, textBox_surname.Text, textBox_specialization.Text, textBox_phone.Text);
            bD.ShowTable(dataGridView1, "Dentists");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int? id = string.IsNullOrEmpty(textBox3.Text) ? (int?)null : int.Parse(textBox3.Text);
            DeleteDentist(id: id);
            bD.ShowTable(dataGridView1, "Dentists");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            UpdateDentist(id, textBox_name.Text, textBox_surname.Text, textBox_specialization.Text, textBox_phone.Text);
            bD.ShowTable(dataGridView1, "Dentists");
        }
    }
}
