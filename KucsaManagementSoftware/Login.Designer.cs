namespace KucsaManagementSoftware
{
    partial class Login
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.MetroButtonClear = new MetroFramework.Controls.MetroButton();
            this.MetroButtonLogin = new MetroFramework.Controls.MetroButton();
            this.MetroComboBoxUser = new MetroFramework.Controls.MetroComboBox();
            this.MetroTextBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.MetroButtonClear);
            this.metroPanel1.Controls.Add(this.MetroButtonLogin);
            this.metroPanel1.Controls.Add(this.MetroComboBoxUser);
            this.metroPanel1.Controls.Add(this.MetroTextBoxPassword);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(360, 320);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(42, 144);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Password:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(42, 77);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "User name:";
            // 
            // MetroButtonClear
            // 
            this.MetroButtonClear.Location = new System.Drawing.Point(214, 248);
            this.MetroButtonClear.Name = "MetroButtonClear";
            this.MetroButtonClear.Size = new System.Drawing.Size(75, 23);
            this.MetroButtonClear.TabIndex = 5;
            this.MetroButtonClear.Text = "Clear";
            this.MetroButtonClear.UseSelectable = true;
            this.MetroButtonClear.Click += new System.EventHandler(this.MetroButtonClear_Click);
            // 
            // MetroButtonLogin
            // 
            this.MetroButtonLogin.Location = new System.Drawing.Point(68, 248);
            this.MetroButtonLogin.Name = "MetroButtonLogin";
            this.MetroButtonLogin.Size = new System.Drawing.Size(75, 23);
            this.MetroButtonLogin.TabIndex = 4;
            this.MetroButtonLogin.Text = "Login";
            this.MetroButtonLogin.UseSelectable = true;
            this.MetroButtonLogin.Click += new System.EventHandler(this.MetroButtonLogin_Click);
            // 
            // MetroComboBoxUser
            // 
            this.MetroComboBoxUser.FormattingEnabled = true;
            this.MetroComboBoxUser.ItemHeight = 23;
            this.MetroComboBoxUser.Location = new System.Drawing.Point(131, 77);
            this.MetroComboBoxUser.Name = "MetroComboBoxUser";
            this.MetroComboBoxUser.Size = new System.Drawing.Size(121, 29);
            this.MetroComboBoxUser.TabIndex = 3;
            this.MetroComboBoxUser.UseSelectable = true;
            // 
            // MetroTextBoxPassword
            // 
            // 
            // 
            // 
            this.MetroTextBoxPassword.CustomButton.Image = null;
            this.MetroTextBoxPassword.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.MetroTextBoxPassword.CustomButton.Name = "";
            this.MetroTextBoxPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MetroTextBoxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MetroTextBoxPassword.CustomButton.TabIndex = 1;
            this.MetroTextBoxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MetroTextBoxPassword.CustomButton.UseSelectable = true;
            this.MetroTextBoxPassword.CustomButton.Visible = false;
            this.MetroTextBoxPassword.Lines = new string[0];
            this.MetroTextBoxPassword.Location = new System.Drawing.Point(131, 144);
            this.MetroTextBoxPassword.MaxLength = 32767;
            this.MetroTextBoxPassword.Name = "MetroTextBoxPassword";
            this.MetroTextBoxPassword.PasswordChar = '*';
            this.MetroTextBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MetroTextBoxPassword.SelectedText = "";
            this.MetroTextBoxPassword.SelectionLength = 0;
            this.MetroTextBoxPassword.SelectionStart = 0;
            this.MetroTextBoxPassword.ShortcutsEnabled = true;
            this.MetroTextBoxPassword.Size = new System.Drawing.Size(121, 23);
            this.MetroTextBoxPassword.TabIndex = 2;
            this.MetroTextBoxPassword.UseSelectable = true;
            this.MetroTextBoxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MetroTextBoxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(172, 32);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox MetroTextBoxPassword;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton MetroButtonClear;
        private MetroFramework.Controls.MetroButton MetroButtonLogin;
        private MetroFramework.Controls.MetroComboBox MetroComboBoxUser;
    }
}