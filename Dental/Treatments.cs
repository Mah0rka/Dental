using MySql.Data.MySqlClient;

namespace Dental
{
    public partial class Treatments : Form
    {

        BD bD = new BD();

        public Treatments()
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

        private void Treatments_Load(object sender, EventArgs e)
        {
            bD.ShowTable(dataGridView1, "treatments");
        }

        public void AddTreatment(string name, string description, decimal price)
        {
            string query = @"
    INSERT INTO Treatments (Name, Description, Price)
    VALUES (@Name, @Description, @Price);";

            try
            {
                bD.OpenConaction();

                MySqlCommand command = new MySqlCommand(query, bD.Connection);

                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@Price", price);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Лікування успішно додано!");
                }
                else
                {
                    Console.WriteLine("Сталася помилка під час додавання лікування.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }

        public void DeleteTreatmentById(int treatmentId)
        {
            string query = "DELETE FROM Treatments WHERE TreatmentID = @TreatmentID;";

            try
            {
                bD.OpenConaction();

                MySqlCommand command = new MySqlCommand(query, bD.Connection);
                command.Parameters.AddWithValue("@TreatmentID", treatmentId);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Лікування успішно видалено!");
                }
                else
                {
                    Console.WriteLine("Лікування з таким ID не знайдено.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }

        public void UpdateTreatmentById(int treatmentId, string name, string description, decimal price)
        {
            string query = @"
    UPDATE Treatments 
    SET Name = @Name, Description = @Description, Price = @Price
    WHERE TreatmentID = @TreatmentID;";

            try
            {
                bD.OpenConaction();

                MySqlCommand command = new MySqlCommand(query, bD.Connection);

                command.Parameters.AddWithValue("@TreatmentID", treatmentId);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@Price", price);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    Console.WriteLine("Лікування успішно оновлено!");
                }
                else
                {
                    Console.WriteLine("Лікування з таким ID не знайдено.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }

        private void button_add_data_Click(object sender, EventArgs e)
        {
            AddTreatment(textBox_name.Text, textBox_Description.Text, decimal.Parse(textBox_Price.Text));
            bD.ShowTable(dataGridView1, "treatments");
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            DeleteTreatmentById(int.Parse(textBox_ID_DEL.Text));
            bD.ShowTable(dataGridView1, "treatments");
        }

        private void button_uppdate_Click(object sender, EventArgs e)
        {
            UpdateTreatmentById(int.Parse(textBox_IDD.Text),textBox_name.Text, textBox_Description.Text, decimal.Parse(textBox_Price.Text));
            bD.ShowTable(dataGridView1, "treatments");
        }
    }
}
