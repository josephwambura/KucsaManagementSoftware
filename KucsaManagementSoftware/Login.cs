using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KucsaManagementSoftware
{
    public delegate void LoadUserSessionDelegate();

    public partial class Login : MetroForm
    {
        public LoadUserSessionDelegate loadUserSession;

        public Login()
        {
            InitializeComponent();
            MetroButtonLogin.Enabled = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //Cursor.Current = Cursors.WaitCursor;
            
            try
            {
                Application.UseWaitCursor = true;
                using(var context = new KucsaManagementDatabaseEntities())
                {
                    MetroComboBoxUser.DataSource = context.TblMembers.ToList();
                    MetroComboBoxUser.DisplayMember = "MemberName";
                    MetroComboBoxUser.ValueMember = "MemberId";
                }
                MetroButtonLogin.Enabled = true;
                //Data.SeedData dsd = new Data.SeedData();
                //dsd.Initialize();
            }
            catch (Exception)
            {
                Application.UseWaitCursor = false;
                MetroMessageBox.Show(this, "Either the database has been moved, we cannot find it.", "Database Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MetroButtonLogin.Enabled = false;
            }
            finally
            {
                Application.UseWaitCursor = false;
                //Cursor.Current = Cursors.WaitCursor;
            }
        }
        

        private void MetroButtonLogin_Click(object sender, EventArgs e)
        {
            //nothing much has been done here, login implementation deserves more than this

            int userName = Convert.ToInt32(MetroComboBoxUser.SelectedValue);
            string password = MetroTextBoxPassword.Text;
            try
            {
                this.Enabled = false;//optional, better target a panel or specific controls
                this.UseWaitCursor = true;//from the Form/Window instance
                using (var context = new KucsaManagementDatabaseEntities())
                {
                    var user = context.TblMembers.SingleOrDefault(member => member.MemberId == userName);
                    if (user != null)
                    {
                        string useLoggedIn = user.MemberName;
                        MetroMessageBox.Show(this, useLoggedIn, "User's name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormMain fm = new FormMain()
                        {

                        };
                        fm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Not logged in", "User's name", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                }
            }
            catch (Exception es)
            {
                MetroMessageBox.Show(this, es.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Enabled = true;//optional
                this.UseWaitCursor = false;
            }
        }

        private void MetroButtonClear_Click(object sender, EventArgs e)
        {
            MetroTextBoxPassword.Text = string.Empty;
        }
    }
}
