using MySql.Data.MySqlClient;
using System.Data;

namespace Dental
{
    public partial class autorisation : Form
    {
        public autorisation()
        {
            InitializeComponent();
        }

        private void Autorisation()
        {
            string StringUserLoggin = UserLoggin.Text;
            string StringUserPas = UserPass.Text;

            using (BD bD = new BD())
            {
                try
                {
                    bD.OpenConaction();

                    MySqlCommand comand = new MySqlCommand(
                        "SELECT * FROM `users` WHERE `user_loggin` = @lg AND `user_pass` = @ps",
                        bD.Connection
                    );

                    comand.Parameters.Add("@lg", MySqlDbType.VarChar).Value = StringUserLoggin;
                    comand.Parameters.Add("@ps", MySqlDbType.VarChar).Value = StringUserPas;

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(comand);
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        var MainMenuOpen = new MainMenu();
                        MainMenuOpen.Show();
                        this.Hide();
                        MainMenuOpen.FormClosed += (s, arg) => this.Close();
                    }
                    else
                        MessageBox.Show("Невірний логін або пароль.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка під час авторизації: {ex.Message}");
                }
            }
        }

        private void button_autorisatoin_Click(object sender, EventArgs e)
        {
            Autorisation();
        }

        private void UserPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                Autorisation();
        }
    }
}
