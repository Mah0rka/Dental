using MySql.Data.MySqlClient;

namespace Dental
{
    public partial class Invoices : Form
    {

        BD bD = new BD();

        public Invoices()
        {
            InitializeComponent();
        }

        private void Invoices_Load(object sender, EventArgs e)
        {
            bD.ShowTable(dataGridView1, "Invoices");
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
            var patients = new Patients();
            patients.Show();
            this.Hide();
            patients.FormClosed += (s, arg) => this.Close();
        }

        public void AddInvoice(int patientId, decimal totalAmount, DateTime dateIssued, string status)
        {
            // Перевірка допустимих значень для статусу
            if (status != "Paid" && status != "Unpaid")
            {
                Console.WriteLine("Невірне значення для статусу. Використовуйте 'Paid' або 'Unpaid'.");
                return;
            }

            string query = @"
    INSERT INTO Invoices (PatientID, TotalAmount, DateIssued, Status)
    VALUES (@PatientID, @TotalAmount, @DateIssued, @Status);";

            try
            {
                bD.OpenConaction();

                MySqlCommand command = new MySqlCommand(query, bD.Connection);

                command.Parameters.AddWithValue("@PatientID", patientId);
                command.Parameters.AddWithValue("@TotalAmount", totalAmount);
                command.Parameters.AddWithValue("@DateIssued", dateIssued);
                command.Parameters.AddWithValue("@Status", status);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Рахунок успішно додано!");
                }
                else
                {
                    Console.WriteLine("Сталася помилка під час додавання рахунку.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }

        public void DeleteInvoiceById(int invoiceId)
        {
            string query = "DELETE FROM Invoices WHERE InvoiceID = @InvoiceID;";

            try
            {
                bD.OpenConaction();

                MySqlCommand command = new MySqlCommand(query, bD.Connection);
                command.Parameters.AddWithValue("@InvoiceID", invoiceId);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Рахунок успішно видалено!");
                }
                else
                {
                    Console.WriteLine("Рахунок з таким ID не знайдено.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }

        public void UpdateInvoiceById(int invoiceId, int patientId, decimal totalAmount, DateTime dateIssued, string status)
        {
            // Перевірка допустимих значень для статусу
            if (status != "Paid" && status != "Unpaid")
            {
                Console.WriteLine("Невірне значення для статусу. Використовуйте 'Paid' або 'Unpaid'.");
                return;
            }

            string query = @"
    UPDATE Invoices 
    SET PatientID = @PatientID, TotalAmount = @TotalAmount, DateIssued = @DateIssued, Status = @Status
    WHERE InvoiceID = @InvoiceID;";

            try
            {
                bD.OpenConaction();

                MySqlCommand command = new MySqlCommand(query, bD.Connection);

                command.Parameters.AddWithValue("@InvoiceID", invoiceId);
                command.Parameters.AddWithValue("@PatientID", patientId);
                command.Parameters.AddWithValue("@TotalAmount", totalAmount);
                command.Parameters.AddWithValue("@DateIssued", dateIssued);
                command.Parameters.AddWithValue("@Status", status);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Рахунок успішно оновлено!");
                }
                else
                {
                    Console.WriteLine("Рахунок з таким ID не знайдено.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }

        private void button_add_data_Click(object sender, EventArgs e)
        {
            AddInvoice(int.Parse(textBox_PID.Text), decimal.Parse(textBox_TotalAmount.Text), dateTimePicker1.Value, listBox_status.SelectedItem?.ToString());
            bD.ShowTable(dataGridView1, "Invoices");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateInvoiceById(int.Parse(textBox_IDD.Text), int.Parse(textBox_PID.Text), decimal.Parse(textBox_TotalAmount.Text), dateTimePicker1.Value, listBox_status.SelectedItem?.ToString());
            bD.ShowTable(dataGridView1, "Invoices");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DeleteInvoiceById(int.Parse(textBox1.Text));
            bD.ShowTable(dataGridView1, "Invoices");
        }
    }
}
