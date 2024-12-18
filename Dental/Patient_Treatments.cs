using MySql.Data.MySqlClient;

namespace Dental
{
    public partial class Patient_Treatments : Form
    {
        BD bD = new BD();
        public Patient_Treatments()
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

        private void Patient_Treatments_Load(object sender, EventArgs e)
        {
            bD.ShowTable(dataGridView1, "Patient_Treatments");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var patient = new Patients();
            patient.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var treatments = new Treatments();
            treatments.Show();
        }

        public void AddPatientTreatment(int patientId, int treatmentId, DateTime date)
        {
            string query = @"
    INSERT INTO Patient_Treatments (PatientID, TreatmentID, Date)
    VALUES (@PatientID, @TreatmentID, @Date);";

            try
            {
                bD.OpenConaction();

                MySqlCommand command = new MySqlCommand(query, bD.Connection);

                command.Parameters.AddWithValue("@PatientID", patientId);
                command.Parameters.AddWithValue("@TreatmentID", treatmentId);
                command.Parameters.AddWithValue("@Date", date);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Лікування пацієнта успішно додано!");
                }
                else
                {
                    Console.WriteLine("Сталася помилка під час додавання лікування пацієнта.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }

        public void DeletePatientTreatmentById(int patientTreatmentId)
        {
            string query = "DELETE FROM Patient_Treatments WHERE PatientTreatmentID = @PatientTreatmentID;";

            try
            {
                bD.OpenConaction();

                MySqlCommand command = new MySqlCommand(query, bD.Connection);
                command.Parameters.AddWithValue("@PatientTreatmentID", patientTreatmentId);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Лікування пацієнта успішно видалено!");
                }
                else
                {
                    Console.WriteLine("Лікування пацієнта з таким ID не знайдено.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }

        public void UpdatePatientTreatmentById(int patientTreatmentId, int patientId, int treatmentId, DateTime date)
        {
            string query = @"
    UPDATE Patient_Treatments 
    SET PatientID = @PatientID, TreatmentID = @TreatmentID, Date = @Date
    WHERE PatientTreatmentID = @PatientTreatmentID;";

            try
            {
                bD.OpenConaction();

                MySqlCommand command = new MySqlCommand(query, bD.Connection);

                command.Parameters.AddWithValue("@PatientTreatmentID", patientTreatmentId);
                command.Parameters.AddWithValue("@PatientID", patientId);
                command.Parameters.AddWithValue("@TreatmentID", treatmentId);
                command.Parameters.AddWithValue("@Date", date);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Лікування пацієнта успішно оновлено!");
                }
                else
                {
                    Console.WriteLine("Лікування пацієнта з таким ID не знайдено.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }

        private void button_add_data_Click(object sender, EventArgs e)
        {
            AddPatientTreatment(int.Parse(textBox_PID.Text), int.Parse(textBox_TID.Text), dateTimePicker1.Value);
            bD.ShowTable(dataGridView1, "Patient_Treatments");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdatePatientTreatmentById(int.Parse(textBox_IDD.Text), int.Parse(textBox_PID.Text), int.Parse(textBox_TID.Text), dateTimePicker1.Value);
            bD.ShowTable(dataGridView1, "Patient_Treatments");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DeletePatientTreatmentById(int.Parse(textBox1.Text));
            bD.ShowTable(dataGridView1, "Patient_Treatments");
        }
    }
}
