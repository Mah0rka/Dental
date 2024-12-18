namespace Dental
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var patients = new Patients();
            patients.Show();
            this.Hide();
            patients.FormClosed += (s, arg) => this.Close();
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var dentist = new Dentists();
            dentist.Show();
            this.Hide();
            dentist.FormClosed += (s, arg) => this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var appointments = new Appointments();
            appointments.Show();
            this.Hide();
            appointments.FormClosed += (s, arg) => this.Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var treatment = new Treatments();
            treatment.Show();
            this.Hide();
            treatment.FormClosed += (s, arg) => this.Close();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var patient_treatment = new Patient_Treatments();
            patient_treatment.Show();
            this.Hide();
            patient_treatment.FormClosed += (s, arg) => this.Close();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var invoice = new Invoices();
            invoice.Show();
            this.Hide();
            invoice.FormClosed += (s, arg) => this.Close();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var staff = new Staff();
            staff.Show();
            this.Hide();
            staff.FormClosed += (s, arg) => this.Close();

        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var logs = new Logs();
            logs.Show();
            this.Hide();
            logs.FormClosed += (s, arg) => this.Close();
        }
    }
}
