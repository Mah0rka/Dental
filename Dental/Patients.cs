using MySql.Data.MySqlClient;

namespace Dental
{
    public partial class Patients : Form
    {
        BD bD = new BD();

        public Patients()
        {
            InitializeComponent();
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            bD.ShowTable(dataGridView1, "patients");
        }

        public void AddPatient(string firstName, string lastName, string phone, DateTime birthDate, string email)
        {

            string query = @"
            INSERT INTO patients (FirstName, LastName, Phone, DateOfBirth, Email)
            VALUES (@FirstName, @LastName, @Phone, @BirthDate, @Email);";

            try
            {
                bD.OpenConaction();

                MySqlCommand command = new MySqlCommand(query, bD.Connection);

                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@Phone", phone);
                command.Parameters.AddWithValue("@BirthDate", birthDate);
                command.Parameters.AddWithValue("@Email", email);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Пацієнт успішно доданий!");
                }
                else
                {
                    Console.WriteLine("Сталася помилка під час додавання пацієнта.");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }

        public void DeletePatient(int? id = null, string firstName = null, string lastName = null, string phone = null)
        {

            string query = "DELETE FROM patients WHERE 1=1";

            if (id.HasValue) query += " AND PatientID = @Id";
            if (!string.IsNullOrEmpty(firstName)) query += " AND FirstName = @FirstName";
            if (!string.IsNullOrEmpty(lastName)) query += " AND LastName = @LastName";
            if (!string.IsNullOrEmpty(phone)) query += " AND Phone = @Phone";

            try
            {
                bD.OpenConaction();

                using (MySqlCommand command = new MySqlCommand(query, bD.Connection))
                {

                    if (id.HasValue) command.Parameters.AddWithValue("@Id", id.Value);
                    if (!string.IsNullOrEmpty(firstName)) command.Parameters.AddWithValue("@FirstName", firstName);
                    if (!string.IsNullOrEmpty(lastName)) command.Parameters.AddWithValue("@LastName", lastName);
                    if (!string.IsNullOrEmpty(phone)) command.Parameters.AddWithValue("@Phone", phone);

                    // Виконуємо запит
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Успішно видалено {rowsAffected} запис(ів)!");
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

        public void UpdatePatient(int id, string firstName = null, string lastName = null, string phone = null, DateTime? dateOfBirth = null, string email = null)
        {

            string query = "UPDATE patients SET ";
            List<string> updates = new List<string>();

            if (!string.IsNullOrEmpty(firstName)) updates.Add("FirstName = @FirstName");
            if (!string.IsNullOrEmpty(lastName)) updates.Add("LastName = @LastName");
            if (!string.IsNullOrEmpty(phone)) updates.Add("Phone = @Phone");
            if (dateOfBirth.HasValue) updates.Add("DateOfBirth = @DateOfBirth");
            if (!string.IsNullOrEmpty(email)) updates.Add("Email = @Email");

            if (updates.Count == 0)
            {
                MessageBox.Show("Не вказано жодного поля для оновлення.");
                return;
            }

            query += string.Join(", ", updates) + " WHERE PatientID = @Id";

            try
            {
                bD.OpenConaction();

                using (MySqlCommand command = new MySqlCommand(query, bD.Connection))
                {

                    if (!string.IsNullOrEmpty(firstName)) command.Parameters.AddWithValue("@FirstName", firstName);
                    if (!string.IsNullOrEmpty(lastName)) command.Parameters.AddWithValue("@LastName", lastName);
                    if (!string.IsNullOrEmpty(phone)) command.Parameters.AddWithValue("@Phone", phone);
                    if (dateOfBirth.HasValue) command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth.Value.ToString("yyyy-MM-dd"));
                    if (!string.IsNullOrEmpty(email)) command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Id", id);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Дані пацієнта (ID: {id}) успішно оновлені!");
                    }
                    else
                    {
                        MessageBox.Show($"Пацієнта з ID: {id} не знайдено.");
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
            AddPatient(textBox_name.Text, textBox_surname.Text, mobile.Text, dateTimePicker1.Value, email.Text);
            bD.ShowTable(dataGridView1, "Patients");
        }

        private void button_delate_Click(object sender, EventArgs e)
        {
            try
            {
                int? id = string.IsNullOrEmpty(textBox_ID.Text) ? (int?)null : int.Parse(textBox_ID.Text);
                string firstName = string.IsNullOrEmpty(textBox_name_del.Text) ? null : textBox_name_del.Text;
                string lastName = string.IsNullOrEmpty(textBox_sur_del.Text) ? null : textBox_sur_del.Text;
                string phone = string.IsNullOrEmpty(textBox_mobile_del.Text) ? null : textBox_mobile_del.Text;

                DeletePatient(id, firstName, lastName, phone);

                bD.ShowTable(dataGridView1, "Patients");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox1.Text);
                string firstName = string.IsNullOrEmpty(textBox_name.Text) ? null : textBox_name.Text;
                string lastName = string.IsNullOrEmpty(textBox_surname.Text) ? null : textBox_surname.Text;
                string phone = string.IsNullOrEmpty(mobile.Text) ? null : mobile.Text;
                DateTime? dateOfBirth = dateTimePicker1.Value;
                string Іemail = string.IsNullOrEmpty(email.Text) ? null : email.Text;

                UpdatePatient(id, firstName, lastName, phone, dateOfBirth, Іemail);

                bD.ShowTable(dataGridView1, "Patients");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var MainMenuOpen = new MainMenu();
            MainMenuOpen.Show();
            this.Hide();
            MainMenuOpen.FormClosed += (s, arg) => this.Close();
        }
    }
}
