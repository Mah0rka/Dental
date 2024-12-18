namespace Dental
{
    partial class Patients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients));
            label2 = new Label();
            panel3 = new Panel();
            textBox1 = new TextBox();
            button1 = new Button();
            button_add_data = new Button();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            email = new TextBox();
            mobile = new TextBox();
            textBox_surname = new TextBox();
            textBox_name = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button_delate = new Button();
            textBox_mobile_del = new TextBox();
            textBox_ID = new TextBox();
            textBox_sur_del = new TextBox();
            textBox_name_del = new TextBox();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.CadetBlue;
            label2.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Cornsilk;
            label2.Location = new Point(0, -3);
            label2.Name = "label2";
            label2.Size = new Size(350, 54);
            label2.TabIndex = 1;
            label2.Text = "Додати пацієнта ";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Snow;
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button_add_data);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(email);
            panel3.Controls.Add(mobile);
            panel3.Controls.Add(textBox_surname);
            panel3.Controls.Add(textBox_name);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 377);
            panel3.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.AccessibleName = "";
            textBox1.BackColor = SystemColors.Menu;
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(21, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(313, 33);
            textBox1.TabIndex = 14;
            textBox1.Text = "ID";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(21, 332);
            button1.Name = "button1";
            button1.Size = new Size(313, 34);
            button1.TabIndex = 13;
            button1.Text = "Оновити данні";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button_add_data
            // 
            button_add_data.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button_add_data.Location = new Point(21, 293);
            button_add_data.Name = "button_add_data";
            button_add_data.Size = new Size(313, 33);
            button_add_data.TabIndex = 12;
            button_add_data.Text = "Додати";
            button_add_data.UseVisualStyleBackColor = true;
            button_add_data.Click += button_add_data_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(191, 184);
            label3.Name = "label3";
            label3.Size = new Size(138, 21);
            label3.TabIndex = 9;
            label3.Text = "Дата народження";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(21, 180);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(164, 25);
            dateTimePicker1.TabIndex = 8;
            // 
            // email
            // 
            email.BackColor = SystemColors.Menu;
            email.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(21, 250);
            email.Name = "email";
            email.Size = new Size(313, 33);
            email.TabIndex = 7;
            email.Text = "Електронна пошта";
            // 
            // mobile
            // 
            mobile.BackColor = SystemColors.Menu;
            mobile.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            mobile.Location = new Point(21, 211);
            mobile.Name = "mobile";
            mobile.Size = new Size(313, 33);
            mobile.TabIndex = 6;
            mobile.Text = "Телефон";
            // 
            // textBox_surname
            // 
            textBox_surname.BackColor = SystemColors.Menu;
            textBox_surname.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_surname.Location = new Point(21, 141);
            textBox_surname.Name = "textBox_surname";
            textBox_surname.Size = new Size(313, 33);
            textBox_surname.TabIndex = 4;
            textBox_surname.Text = "Прізвище";
            // 
            // textBox_name
            // 
            textBox_name.BackColor = SystemColors.Menu;
            textBox_name.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_name.Location = new Point(21, 102);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(313, 33);
            textBox_name.TabIndex = 3;
            textBox_name.Text = "Ім'я";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.CadetBlue;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(350, 54);
            label1.TabIndex = 0;
            label1.Text = "Видалити пацієнта ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Snow;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button_delate);
            panel1.Controls.Add(textBox_mobile_del);
            panel1.Controls.Add(textBox_ID);
            panel1.Controls.Add(textBox_sur_del);
            panel1.Controls.Add(textBox_name_del);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 375);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 321);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(16, 269);
            button2.Name = "button2";
            button2.Size = new Size(313, 37);
            button2.TabIndex = 14;
            button2.Text = "Перейти у меню";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button_delate
            // 
            button_delate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button_delate.Location = new Point(16, 226);
            button_delate.Name = "button_delate";
            button_delate.Size = new Size(313, 37);
            button_delate.TabIndex = 13;
            button_delate.Text = "Видалити";
            button_delate.UseVisualStyleBackColor = true;
            button_delate.Click += button_delate_Click;
            // 
            // textBox_mobile_del
            // 
            textBox_mobile_del.BackColor = SystemColors.Menu;
            textBox_mobile_del.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_mobile_del.Location = new Point(16, 187);
            textBox_mobile_del.Name = "textBox_mobile_del";
            textBox_mobile_del.Size = new Size(313, 33);
            textBox_mobile_del.TabIndex = 13;
            textBox_mobile_del.Text = "Телефон";
            // 
            // textBox_ID
            // 
            textBox_ID.AccessibleName = "";
            textBox_ID.BackColor = SystemColors.Menu;
            textBox_ID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_ID.Location = new Point(16, 70);
            textBox_ID.Name = "textBox_ID";
            textBox_ID.Size = new Size(313, 33);
            textBox_ID.TabIndex = 7;
            textBox_ID.Text = "ID";
            // 
            // textBox_sur_del
            // 
            textBox_sur_del.BackColor = SystemColors.Menu;
            textBox_sur_del.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_sur_del.Location = new Point(16, 148);
            textBox_sur_del.Name = "textBox_sur_del";
            textBox_sur_del.Size = new Size(313, 33);
            textBox_sur_del.TabIndex = 6;
            textBox_sur_del.Text = "Прізвище";
            // 
            // textBox_name_del
            // 
            textBox_name_del.BackColor = SystemColors.Menu;
            textBox_name_del.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_name_del.Location = new Point(16, 109);
            textBox_name_del.Name = "textBox_name_del";
            textBox_name_del.Size = new Size(313, 33);
            textBox_name_del.TabIndex = 5;
            textBox_name_del.Text = "Ім'я";
            // 
            // panel4
            // 
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(panel3);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(560, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(350, 696);
            panel4.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ControlLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(558, 696);
            dataGridView1.TabIndex = 0;
            // 
            // Patients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 696);
            Controls.Add(dataGridView1);
            Controls.Add(panel4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Patients";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Пацієнти";
            Load += Patients_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Panel panel3;
        private Label label1;
        private Panel panel1;
        private Panel panel4;
        private DataGridView dataGridView1;
        private TextBox email;
        private TextBox mobile;
        private TextBox textBox_surname;
        private TextBox textBox_name;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private Button button_add_data;
        private Button button_delate;
        private TextBox textBox_mobile_del;
        private TextBox textBox_ID;
        private TextBox textBox_sur_del;
        private TextBox textBox_name_del;
        private Button button1;
        private TextBox textBox1;
        private Button button2;
    }
}