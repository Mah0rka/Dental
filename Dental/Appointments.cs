using MySql.Data.MySqlClient;

namespace Dental
{
    public partial class Appointments : Form
    {

        BD bD = new BD();

        public Appointments()
        {
            InitializeComponent();
        }

        private void Appointments_Load(object sender, EventArgs e)
        {
            bD.ShowTable(dataGridView1, "appointments");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var MainMenuOpen = new MainMenu();
            MainMenuOpen.Show();
            this.Hide();
            MainMenuOpen.FormClosed += (s, arg) => this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var patient = new Patients();
            patient.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var dentists = new Dentists();
            dentists.Show();
        }

        public void AddAppointment(int patientId, int dentistId, DateTime date, string time, string status)
        {
            string query = @"
             INSERT INTO Appointments (PatientID, DentistID, Date, Time, Status)
             VALUES (@PatientID, @DentistID, @Date, @Time, @Status);";

            try
            {
                bD.OpenConaction();

                MySqlCommand command = new MySqlCommand(query, bD.Connection);

                command.Parameters.AddWithValue("@PatientID", patientId);
                command.Parameters.AddWithValue("@DentistID", dentistId);
                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@Time", time);
                command.Parameters.AddWithValue("@Status", status);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Запис на прийом успішно доданий!");
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

        public void DeleteAppointmentById(int appointmentId)
        {
            string query = "DELETE FROM Appointments WHERE AppointmentID = @AppointmentID;";

            try
            {
                bD.OpenConaction();

                MySqlCommand command = new MySqlCommand(query, bD.Connection);
                command.Parameters.AddWithValue("@AppointmentID", appointmentId);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Запис на прийом успішно видалено!");
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

        public void UpdateAppointmentById(int appointmentId, int patientId, int dentistId, DateTime date, string time, string status)
        {
            string query = @"
             UPDATE Appointments 
             SET PatientID = @PatientID, DentistID = @DentistID, Date = @Date, Time = @Time, Status = @Status
             WHERE AppointmentID = @AppointmentID;";

            try
            {
                bD.OpenConaction();

                MySqlCommand command = new MySqlCommand(query, bD.Connection);

                command.Parameters.AddWithValue("@AppointmentID", appointmentId);
                command.Parameters.AddWithValue("@PatientID", patientId);
                command.Parameters.AddWithValue("@DentistID", dentistId);
                command.Parameters.AddWithValue("@Date", date);
                command.Parameters.AddWithValue("@Time", time);
                command.Parameters.AddWithValue("@Status", status);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Запис на прийом успішно оновлено!");
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

        private void button_add_data_Click(object sender, EventArgs e)
        {
            AddAppointment(int.Parse(textBox_PID.Text), int.Parse(textBox_DID.Text), dateTimePicker1.Value, textBox_Time.Text, listBox_status.SelectedItem?.ToString());
            bD.ShowTable(dataGridView1, "appointments");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateAppointmentById(int.Parse(textBox_IDD.Text), int.Parse(textBox_PID.Text), int.Parse(textBox_DID.Text), dateTimePicker1.Value, textBox_Time.Text, listBox_status.SelectedItem?.ToString());
            bD.ShowTable(dataGridView1, "appointments");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DeleteAppointmentById(int.Parse(textBox_IDD_del.Text));
            bD.ShowTable(dataGridView1, "appointments");
        }
    }
}
