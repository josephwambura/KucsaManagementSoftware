namespace KucsaManagementSoftware
{
    partial class FormManageRole
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabelRoleId = new MetroFramework.Controls.MetroLabel();
            this.MetroTextBoxRoleName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.MetroButtonClearRoles = new MetroFramework.Controls.MetroButton();
            this.MetroButtonSaveRole = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.MetroGridRoles = new MetroFramework.Controls.MetroGrid();
            this.MetroButtonDelete = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetroGridRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.MetroButtonDelete);
            this.metroPanel1.Controls.Add(this.metroLabelRoleId);
            this.metroPanel1.Controls.Add(this.MetroTextBoxRoleName);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.MetroButtonClearRoles);
            this.metroPanel1.Controls.Add(this.MetroButtonSaveRole);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(17, 55);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(416, 194);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabelRoleId
            // 
            this.metroLabelRoleId.AutoSize = true;
            this.metroLabelRoleId.Location = new System.Drawing.Point(123, 40);
            this.metroLabelRoleId.Name = "metroLabelRoleId";
            this.metroLabelRoleId.Size = new System.Drawing.Size(16, 19);
            this.metroLabelRoleId.TabIndex = 7;
            this.metroLabelRoleId.Text = "0";
            // 
            // MetroTextBoxRoleName
            // 
            // 
            // 
            // 
            this.MetroTextBoxRoleName.CustomButton.Image = null;
            this.MetroTextBoxRoleName.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.MetroTextBoxRoleName.CustomButton.Name = "";
            this.MetroTextBoxRoleName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MetroTextBoxRoleName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MetroTextBoxRoleName.CustomButton.TabIndex = 1;
            this.MetroTextBoxRoleName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MetroTextBoxRoleName.CustomButton.UseSelectable = true;
            this.MetroTextBoxRoleName.CustomButton.Visible = false;
            this.MetroTextBoxRoleName.Lines = new string[0];
            this.MetroTextBoxRoleName.Location = new System.Drawing.Point(123, 83);
            this.MetroTextBoxRoleName.MaxLength = 32767;
            this.MetroTextBoxRoleName.Name = "MetroTextBoxRoleName";
            this.MetroTextBoxRoleName.PasswordChar = '\0';
            this.MetroTextBoxRoleName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MetroTextBoxRoleName.SelectedText = "";
            this.MetroTextBoxRoleName.SelectionLength = 0;
            this.MetroTextBoxRoleName.SelectionStart = 0;
            this.MetroTextBoxRoleName.ShortcutsEnabled = true;
            this.MetroTextBoxRoleName.Size = new System.Drawing.Size(173, 23);
            this.MetroTextBoxRoleName.TabIndex = 6;
            this.MetroTextBoxRoleName.UseSelectable = true;
            this.MetroTextBoxRoleName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MetroTextBoxRoleName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(19, 87);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Title:";
            // 
            // MetroButtonClearRoles
            // 
            this.MetroButtonClearRoles.Location = new System.Drawing.Point(177, 147);
            this.MetroButtonClearRoles.Name = "MetroButtonClearRoles";
            this.MetroButtonClearRoles.Size = new System.Drawing.Size(75, 23);
            this.MetroButtonClearRoles.TabIndex = 4;
            this.MetroButtonClearRoles.Text = "Clear";
            this.MetroButtonClearRoles.UseSelectable = true;
            this.MetroButtonClearRoles.Click += new System.EventHandler(this.MetroButtonClearRoles_Click);
            // 
            // MetroButtonSaveRole
            // 
            this.MetroButtonSaveRole.Location = new System.Drawing.Point(71, 147);
            this.MetroButtonSaveRole.Name = "MetroButtonSaveRole";
            this.MetroButtonSaveRole.Size = new System.Drawing.Size(75, 23);
            this.MetroButtonSaveRole.TabIndex = 3;
            this.MetroButtonSaveRole.Text = "Save";
            this.MetroButtonSaveRole.UseSelectable = true;
            this.MetroButtonSaveRole.Click += new System.EventHandler(this.MetroButtonSaveRole_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(19, 40);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Role Id:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 261);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(59, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "All Roles";
            // 
            // MetroGridRoles
            // 
            this.MetroGridRoles.AllowUserToResizeRows = false;
            this.MetroGridRoles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MetroGridRoles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MetroGridRoles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MetroGridRoles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MetroGridRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MetroGridRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MetroGridRoles.DefaultCellStyle = dataGridViewCellStyle2;
            this.MetroGridRoles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MetroGridRoles.EnableHeadersVisualStyles = false;
            this.MetroGridRoles.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MetroGridRoles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MetroGridRoles.Location = new System.Drawing.Point(20, 291);
            this.MetroGridRoles.Name = "MetroGridRoles";
            this.MetroGridRoles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MetroGridRoles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MetroGridRoles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MetroGridRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MetroGridRoles.Size = new System.Drawing.Size(410, 239);
            this.MetroGridRoles.TabIndex = 4;
            this.MetroGridRoles.SelectionChanged += new System.EventHandler(this.MetroGridRoles_SelectionChanged);
            // 
            // MetroButtonDelete
            // 
            this.MetroButtonDelete.Location = new System.Drawing.Point(277, 147);
            this.MetroButtonDelete.Name = "MetroButtonDelete";
            this.MetroButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.MetroButtonDelete.TabIndex = 8;
            this.MetroButtonDelete.Text = "Delete";
            this.MetroButtonDelete.UseSelectable = true;
            this.MetroButtonDelete.Click += new System.EventHandler(this.MetroButtonDelete_Click);
            // 
            // FormManageRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 550);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.MetroGridRoles);
            this.Name = "FormManageRole";
            this.Text = "Manage Roles";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormManageRole_FormClosed);
            this.Load += new System.EventHandler(this.FormManageRole_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetroGridRoles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabelRoleId;
        private MetroFramework.Controls.MetroTextBox MetroTextBoxRoleName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton MetroButtonClearRoles;
        private MetroFramework.Controls.MetroButton MetroButtonSaveRole;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid MetroGridRoles;
        private MetroFramework.Controls.MetroButton MetroButtonDelete;
    }
}