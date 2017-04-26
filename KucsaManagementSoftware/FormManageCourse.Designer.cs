namespace KucsaManagementSoftware
{
    partial class FormManageCourse
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
            this.metroTextBoxFaculty = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelCourseId = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxCourseName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.MetroButtonClearCourses = new MetroFramework.Controls.MetroButton();
            this.MetroButtonSaveCourse = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.MetroGridCourses = new MetroFramework.Controls.MetroGrid();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetroGridCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroTextBoxFaculty);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabelCourseId);
            this.metroPanel1.Controls.Add(this.metroTextBoxCourseName);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.MetroButtonClearCourses);
            this.metroPanel1.Controls.Add(this.MetroButtonSaveCourse);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(17, 56);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(416, 194);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroTextBoxFaculty
            // 
            // 
            // 
            // 
            this.metroTextBoxFaculty.CustomButton.Image = null;
            this.metroTextBoxFaculty.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.metroTextBoxFaculty.CustomButton.Name = "";
            this.metroTextBoxFaculty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxFaculty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxFaculty.CustomButton.TabIndex = 1;
            this.metroTextBoxFaculty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxFaculty.CustomButton.UseSelectable = true;
            this.metroTextBoxFaculty.CustomButton.Visible = false;
            this.metroTextBoxFaculty.Lines = new string[0];
            this.metroTextBoxFaculty.Location = new System.Drawing.Point(123, 106);
            this.metroTextBoxFaculty.MaxLength = 32767;
            this.metroTextBoxFaculty.Name = "metroTextBoxFaculty";
            this.metroTextBoxFaculty.PasswordChar = '\0';
            this.metroTextBoxFaculty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFaculty.SelectedText = "";
            this.metroTextBoxFaculty.SelectionLength = 0;
            this.metroTextBoxFaculty.SelectionStart = 0;
            this.metroTextBoxFaculty.ShortcutsEnabled = true;
            this.metroTextBoxFaculty.Size = new System.Drawing.Size(173, 23);
            this.metroTextBoxFaculty.TabIndex = 9;
            this.metroTextBoxFaculty.UseSelectable = true;
            this.metroTextBoxFaculty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxFaculty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(19, 110);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(51, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Faculty:";
            // 
            // metroLabelCourseId
            // 
            this.metroLabelCourseId.AutoSize = true;
            this.metroLabelCourseId.Location = new System.Drawing.Point(123, 35);
            this.metroLabelCourseId.Name = "metroLabelCourseId";
            this.metroLabelCourseId.Size = new System.Drawing.Size(16, 19);
            this.metroLabelCourseId.TabIndex = 7;
            this.metroLabelCourseId.Text = "0";
            // 
            // metroTextBoxCourseName
            // 
            // 
            // 
            // 
            this.metroTextBoxCourseName.CustomButton.Image = null;
            this.metroTextBoxCourseName.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.metroTextBoxCourseName.CustomButton.Name = "";
            this.metroTextBoxCourseName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxCourseName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxCourseName.CustomButton.TabIndex = 1;
            this.metroTextBoxCourseName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxCourseName.CustomButton.UseSelectable = true;
            this.metroTextBoxCourseName.CustomButton.Visible = false;
            this.metroTextBoxCourseName.Lines = new string[0];
            this.metroTextBoxCourseName.Location = new System.Drawing.Point(123, 69);
            this.metroTextBoxCourseName.MaxLength = 32767;
            this.metroTextBoxCourseName.Name = "metroTextBoxCourseName";
            this.metroTextBoxCourseName.PasswordChar = '\0';
            this.metroTextBoxCourseName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxCourseName.SelectedText = "";
            this.metroTextBoxCourseName.SelectionLength = 0;
            this.metroTextBoxCourseName.SelectionStart = 0;
            this.metroTextBoxCourseName.ShortcutsEnabled = true;
            this.metroTextBoxCourseName.Size = new System.Drawing.Size(173, 23);
            this.metroTextBoxCourseName.TabIndex = 6;
            this.metroTextBoxCourseName.UseSelectable = true;
            this.metroTextBoxCourseName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxCourseName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(19, 73);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(93, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Course Name:";
            // 
            // MetroButtonClearCourses
            // 
            this.MetroButtonClearCourses.Location = new System.Drawing.Point(221, 147);
            this.MetroButtonClearCourses.Name = "MetroButtonClearCourses";
            this.MetroButtonClearCourses.Size = new System.Drawing.Size(75, 23);
            this.MetroButtonClearCourses.TabIndex = 4;
            this.MetroButtonClearCourses.Text = "Clear";
            this.MetroButtonClearCourses.UseSelectable = true;
            this.MetroButtonClearCourses.Click += new System.EventHandler(this.MetroButtonClearCourses_Click);
            // 
            // MetroButtonSaveCourse
            // 
            this.MetroButtonSaveCourse.Location = new System.Drawing.Point(123, 147);
            this.MetroButtonSaveCourse.Name = "MetroButtonSaveCourse";
            this.MetroButtonSaveCourse.Size = new System.Drawing.Size(75, 23);
            this.MetroButtonSaveCourse.TabIndex = 3;
            this.MetroButtonSaveCourse.Text = "Save";
            this.MetroButtonSaveCourse.UseSelectable = true;
            this.MetroButtonSaveCourse.Click += new System.EventHandler(this.MetroButtonSaveCourse_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(19, 35);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Course Id:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 262);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "All Courses";
            // 
            // MetroGridCourses
            // 
            this.MetroGridCourses.AllowUserToResizeRows = false;
            this.MetroGridCourses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MetroGridCourses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MetroGridCourses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.MetroGridCourses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MetroGridCourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MetroGridCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MetroGridCourses.DefaultCellStyle = dataGridViewCellStyle2;
            this.MetroGridCourses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MetroGridCourses.EnableHeadersVisualStyles = false;
            this.MetroGridCourses.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MetroGridCourses.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MetroGridCourses.Location = new System.Drawing.Point(20, 291);
            this.MetroGridCourses.Name = "MetroGridCourses";
            this.MetroGridCourses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MetroGridCourses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.MetroGridCourses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.MetroGridCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MetroGridCourses.Size = new System.Drawing.Size(410, 239);
            this.MetroGridCourses.TabIndex = 4;
            this.MetroGridCourses.SelectionChanged += new System.EventHandler(this.MetroGridCourses_SelectionChanged);
            // 
            // FormManageCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 550);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.MetroGridCourses);
            this.Name = "FormManageCourse";
            this.Text = "Manage Course";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormManageCourse_FormClosed);
            this.Load += new System.EventHandler(this.FormManageCourse_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetroGridCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabelCourseId;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCourseName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton MetroButtonClearCourses;
        private MetroFramework.Controls.MetroButton MetroButtonSaveCourse;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid MetroGridCourses;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFaculty;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}