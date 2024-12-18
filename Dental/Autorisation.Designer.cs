namespace Dental
{
    partial class autorisation
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(autorisation));
            label1 = new Label();
            label2 = new Label();
            UserLoggin = new TextBox();
            UserPass = new TextBox();
            button_autorisatoin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 27);
            label1.TabIndex = 0;
            label1.Text = "Логін";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Snap ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Cornsilk;
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(92, 27);
            label2.TabIndex = 1;
            label2.Text = "Пароль";
            // 
            // UserLoggin
            // 
            UserLoggin.BackColor = Color.White;
            UserLoggin.BorderStyle = BorderStyle.None;
            UserLoggin.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            UserLoggin.Location = new Point(12, 39);
            UserLoggin.Name = "UserLoggin";
            UserLoggin.Size = new Size(244, 26);
            UserLoggin.TabIndex = 2;
            // 
            // UserPass
            // 
            UserPass.BackColor = Color.White;
            UserPass.BorderStyle = BorderStyle.None;
            UserPass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            UserPass.Location = new Point(12, 114);
            UserPass.Name = "UserPass";
            UserPass.Size = new Size(244, 26);
            UserPass.TabIndex = 3;
            UserPass.UseSystemPasswordChar = true;
            UserPass.KeyPress += UserPass_KeyPress;
            // 
            // button_autorisatoin
            // 
            button_autorisatoin.BackColor = Color.CadetBlue;
            button_autorisatoin.Font = new Font("Snap ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_autorisatoin.ForeColor = Color.Cornsilk;
            button_autorisatoin.ImageAlign = ContentAlignment.BottomCenter;
            button_autorisatoin.Location = new Point(12, 162);
            button_autorisatoin.Name = "button_autorisatoin";
            button_autorisatoin.Size = new Size(244, 58);
            button_autorisatoin.TabIndex = 4;
            button_autorisatoin.Text = "Вхід";
            button_autorisatoin.UseVisualStyleBackColor = false;
            button_autorisatoin.Click += button_autorisatoin_Click;
            // 
            // autorisation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(268, 232);
            Controls.Add(button_autorisatoin);
            Controls.Add(UserPass);
            Controls.Add(UserLoggin);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "autorisation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизація";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox UserLoggin;
        private TextBox UserPass;
        private Button button_autorisatoin;
    }
}
