namespace Dental
{
    partial class Dentists
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dentists));
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            textBox1 = new TextBox();
            button1 = new Button();
            button_add_data = new Button();
            textBox_specialization = new TextBox();
            textBox_phone = new TextBox();
            textBox_surname = new TextBox();
            textBox_name = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            panel2 = new Panel();
            button3 = new Button();
            button4 = new Button();
            textBox3 = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button_delate = new Button();
            textBox_mobile_del = new TextBox();
            textBox_ID = new TextBox();
            textBox_sur_del = new TextBox();
            textBox_name_del = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            dataGridView1.Location = new Point(-1, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(522, 696);
            dataGridView1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.Snow;
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(button_add_data);
            panel3.Controls.Add(textBox_specialization);
            panel3.Controls.Add(textBox_phone);
            panel3.Controls.Add(textBox_surname);
            panel3.Controls.Add(textBox_name);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(3, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 344);
            panel3.TabIndex = 4;
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
            button1.Location = new Point(21, 297);
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
            button_add_data.Location = new Point(21, 258);
            button_add_data.Name = "button_add_data";
            button_add_data.Size = new Size(313, 33);
            button_add_data.TabIndex = 12;
            button_add_data.Text = "Додати";
            button_add_data.UseVisualStyleBackColor = true;
            button_add_data.Click += button_add_data_Click;
            // 
            // textBox_specialization
            // 
            textBox_specialization.BackColor = SystemColors.Menu;
            textBox_specialization.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_specialization.Location = new Point(21, 219);
            textBox_specialization.Name = "textBox_specialization";
            textBox_specialization.Size = new Size(313, 33);
            textBox_specialization.TabIndex = 7;
            textBox_specialization.Text = "Посада";
            // 
            // textBox_phone
            // 
            textBox_phone.BackColor = SystemColors.Menu;
            textBox_phone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_phone.Location = new Point(21, 180);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(313, 33);
            textBox_phone.TabIndex = 6;
            textBox_phone.Text = "Телефон";
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
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.CadetBlue;
            label2.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Cornsilk;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(347, 54);
            label2.TabIndex = 1;
            label2.Text = "Додати";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(panel1);
            panel4.Controls.Add(panel3);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(524, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(350, 695);
            panel4.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.Snow;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(0, 345);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 350);
            panel2.TabIndex = 5;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(16, 152);
            button3.Name = "button3";
            button3.Size = new Size(313, 37);
            button3.TabIndex = 14;
            button3.Text = "Перейти у меню";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(16, 109);
            button4.Name = "button4";
            button4.Size = new Size(313, 37);
            button4.TabIndex = 13;
            button4.Text = "Видалити";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox3
            // 
            textBox3.AccessibleName = "";
            textBox3.BackColor = SystemColors.Menu;
            textBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(16, 70);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(313, 33);
            textBox3.TabIndex = 7;
            textBox3.Text = "ID";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = Color.CadetBlue;
            label4.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Cornsilk;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(350, 54);
            label4.TabIndex = 0;
            label4.Text = "Видалити";
            label4.TextAlign = ContentAlignment.MiddleCenter;
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
            panel1.Location = new Point(0, 970);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 321);
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
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.CadetBlue;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(650, 54);
            label1.TabIndex = 0;
            label1.Text = "Видалити пацієнта ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Dentists
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 695);
            Controls.Add(panel4);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Dentists";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Стоматологи";
            Load += Dentists_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel3;
        private TextBox textBox1;
        private Button button1;
        private Button button_add_data;
        private TextBox textBox_phone;
        private TextBox textBox_surname;
        private TextBox textBox_name;
        private Label label2;
        private Panel panel4;
        private Panel panel1;
        private Button button2;
        private Button button_delate;
        private TextBox textBox_mobile_del;
        private TextBox textBox_ID;
        private TextBox textBox_sur_del;
        private TextBox textBox_name_del;
        private Label label1;
        private Panel panel2;
        private Button button3;
        private Button button4;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox_specialization;
    }
}