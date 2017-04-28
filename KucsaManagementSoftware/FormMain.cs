using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.IO;

namespace KucsaManagementSoftware
{
    public partial class FormMain : MetroForm
    {
        private byte[] bigPicture;
        private byte gridPicture;

        int memId;
        string memberName;
        string memberReg;
        string memberPass;

        public FormMain()
        {
            

            InitializeComponent();

            InitializeRoleList();
            InitializeCourseList();
            InitializeModuleList();

            
        }

        public void LoadMembers()
        {
            using (var context = new KucsaManagementDatabaseEntities())
            {
                var members = from mem in context.TblMembers select new
                              {
                                  mem.MemberId,
                                  mem.MemberName,
                                  mem.MemberRegistration,
                                  mem.Password,
                                  //mem.MemberThumbnail,
                                  //mem.MemberBigPicture,
                                  TblCourse = mem.TblCourse.CourseName,
                                  TblModule = mem.TblModule.Title,
                                  TblRole = mem.TblRole.RoleName,
                                  //mem.TimeJoined
                              };
                try
                {
                    MetroGridMembers.DataSource = members.ToList();
                }
                catch (Exception es)
                {
                    MetroMessageBox.Show(this, es.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void InitializeRoleList()
        {
            using (var context = new KucsaManagementDatabaseEntities())
            {
                MetroComboBoxRole.DataSource = context.TblRoles.ToList();
                MetroComboBoxRole.DisplayMember = "RoleName";
                MetroComboBoxRole.ValueMember = "RoleId";
            }
        }

        private void InitializeCourseList()
        {
            using (var context = new KucsaManagementDatabaseEntities())
            {
                MetroComboBoxMemberCourse.DataSource = context.TblCourses.ToList();
                MetroComboBoxMemberCourse.DisplayMember = "CourseName";
                MetroComboBoxMemberCourse.ValueMember = "CourseId";
            }
        }

        private void InitializeModuleList()
        {
            using (var context = new KucsaManagementDatabaseEntities())
            {
                MetroComboBoxMemberModule.DataSource = context.TblModules.ToList();
                MetroComboBoxMemberModule.DisplayMember = "Title";
                MetroComboBoxMemberModule.ValueMember = "ModuleId";
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadMembers();
        }
        
        public byte[] BigPictureNP()
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    FileStream fsBLOBFile = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);

                    bigPicture = new Byte[fsBLOBFile.Length];

                    fsBLOBFile.Read(bigPicture, 0, bigPicture.Length);
                    fsBLOBFile.Close();

                    MemoryStream stmBLOBData = new MemoryStream(bigPicture);
                    pictureBoxMemberPicture.Image = Image.FromStream(stmBLOBData);
                }
            }
            catch (Exception) { throw; }
            return bigPicture;
        }
        
        private void MetroButtonManageRoles_Click(object sender, EventArgs e)
        {
            FormManageRole fmm = new FormManageRole()
            {
                refreshRoleList = InitializeRoleList
            };
            fmm.Show(this);
        }

        private bool isValidRegistrationNo(string RegNo)
        {
            try
            {
                using(var context = new KucsaManagementDatabaseEntities())
                {
                    var regExists = context.TblMembers.SingleOrDefault(member => member.MemberRegistration == RegNo);
                    if (regExists != null)
                        return false;
                }
            }
            catch (Exception)
            {
                
            }
            return true;
        }

        private bool ValidateEmptyFields()
        {
            if (memberName == "" && memberReg == "")
            {
                MetroMessageBox.Show(this, "Empty Fields", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (memberName == "" || memberReg == "")
            {
                MetroMessageBox.Show(this, "One of the fields is Empty", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (memberName.Length < 5 && memberReg.Length < 10)
            {
                MetroMessageBox.Show(this, "* Name should be more than 5, \n* Registration should be more than 10", "Invalid Name and Registration Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (memberName.Length < 5)
            {
                MetroMessageBox.Show(this, "Your name though! \n* Name should be more than 5!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (memberReg.Length < 10)
            {
                MetroMessageBox.Show(this, "Your registration though! \n* Registration should be more than 10!", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void MetroButtonSave_Click(object sender, EventArgs e)
        {
            memId = Convert.ToInt32(metroLabelMemberId.Text);
            memberName = MetroTextBoxMemberName.Text;
            memberReg = MetroTextBoxMemberReg.Text;
            memberPass = MetroTextBoxPassword.Text;

            if (!ValidateEmptyFields())
                return;

            if (memId == 0)
            {
                AddNewMember();
            }
            else
            {
                UpdateMember();
            }

            LoadMembers();
        }

        private void AddNewMember()
        {
            using(var context = new KucsaManagementDatabaseEntities())
            {
                TblMember member = new TblMember
                {
                    MemberName = memberName,
                    MemberRegistration = memberReg,
                    Password = memberPass,
                    MemberThumbnail = bigPicture,
                    MemberBigPicture = bigPicture,
                    RoleId = Convert.ToInt32(MetroComboBoxRole.SelectedValue),
                    CourseId = Convert.ToInt32(MetroComboBoxMemberCourse.SelectedValue),
                    ModuleId = Convert.ToInt32(MetroComboBoxMemberModule.SelectedValue)
                };

                if (!isValidRegistrationNo(memberReg))
                {
                    MetroMessageBox.Show(this, "The registration number entered already exists!", "Unsuccessful Operation!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    context.TblMembers.Add(member);

                    try
                    {
                        context.SaveChanges();
                        MetroMessageBox.Show(this, memberName + " Added Successfully as a member!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    catch (Exception)
                    {
                        MetroMessageBox.Show(this, "Could not save a new user", "Unsuccessful Operation!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
        }

        private void UpdateMember()
        {
            using (var context = new KucsaManagementDatabaseEntities())
            {
                var memberToUpdate = context.TblMembers.SingleOrDefault(member => member.MemberId == memId);
                if (memberToUpdate != null)
                {
                    memberToUpdate.MemberName = memberName;

                    //did not want to make it possible to change the registration number
                    memberToUpdate.MemberRegistration = memberToUpdate.MemberRegistration;
                    memberToUpdate.Password = memberPass;
                    memberToUpdate.MemberThumbnail = bigPicture;
                    memberToUpdate.MemberBigPicture = bigPicture;
                    memberToUpdate.RoleId = Convert.ToInt32(MetroComboBoxRole.SelectedValue);
                    memberToUpdate.CourseId = Convert.ToInt32(MetroComboBoxMemberCourse.SelectedValue);
                    memberToUpdate.ModuleId = Convert.ToInt32(MetroComboBoxMemberModule.SelectedValue);
                }
                try
                {
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    MetroMessageBox.Show(this, "Could not update the user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MetroMessageBox.Show(this, memberName + " Updated Successfully but registration number remained!", "Successful Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void MetroButtonClear_Click(object sender, EventArgs e)
        {
            metroLabelMemberId.Text = "0";
            MetroTextBoxMemberName.Text = string.Empty;
            MetroTextBoxMemberReg.Text = string.Empty;
            MetroTextBoxPassword.Text = string.Empty;

            MetroButtonSave.Text = "Save";
            try
            {
                MetroComboBoxMemberCourse.SelectedIndex = 0;
                MetroComboBoxMemberModule.SelectedIndex = 0;
                MetroComboBoxRole.SelectedIndex = 0;
                pictureBoxMemberPicture.Image = Properties.Resources.profile;
            }
            catch (Exception)
            {

            }
        }

        private void MetroButtonPicture_Click(object sender, EventArgs e)
        {
            BigPictureNP();
        }

        private void MetroButtonManageCourse_Click(object sender, EventArgs e)
        {
            FormManageCourse fmm = new FormManageCourse()
            {
                refreshCourseList = InitializeCourseList
            };
            fmm.Show(this);
        }

        private void MetroButtonManageModule_Click(object sender, EventArgs e)
        {
            FormManageModule fmm = new FormManageModule()
            {
                refreshModuleList = InitializeModuleList
            };
            fmm.Show(this);
        }

        private void MetroGridMembers_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRows = null;
            //MetroGridMembers.MultiSelect = false;

            if (MetroGridMembers.SelectedRows.Count > 0)
            {
                selectedRows = MetroGridMembers.SelectedRows[0];
            }

            if (selectedRows == null)
                return;

            //populate other fields when gridview is selected
            metroLabelMemberId.Text = selectedRows.Cells["MemberId"].Value.ToString();
            MetroTextBoxMemberName.Text = selectedRows.Cells["MemberName"].Value.ToString();
            MetroTextBoxMemberReg.Text = selectedRows.Cells["MemberRegistration"].Value.ToString();
            MetroTextBoxPassword.Text = selectedRows.Cells["Password"].Value.ToString();
            MetroComboBoxRole.SelectedIndex = MetroComboBoxRole.FindStringExact(selectedRows.Cells["TblRole"].Value.ToString());
            MetroComboBoxMemberCourse.SelectedIndex = MetroComboBoxMemberCourse.FindStringExact(selectedRows.Cells["TblCourse"].Value.ToString());
            MetroComboBoxMemberModule.SelectedIndex = MetroComboBoxMemberModule.FindStringExact(selectedRows.Cells["TblModule"].Value.ToString());

            MetroButtonSave.Text = "Update";

            try
            {
                metroLabelMemberJoinTime.Text = selectedRows.Cells["TimeJoined"].Value.ToString();

                gridPicture = Convert.ToByte(selectedRows.Cells["MemberThumbnail"].Value);
                MemoryStream stmBLOBData = new MemoryStream(gridPicture);
                pictureBoxMemberPicture.Image = Image.FromStream(stmBLOBData);
            }
            catch (Exception)
            {

            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Login login = new Login();
            //login.Show();
            //this.Dispose();
            
            //put this to close the hidden login window, hidden during the login step
            Application.Exit();
        }

        private void MetroButtonDelete_Click(object sender, EventArgs e)
        {
            int deleteID = Convert.ToInt32(metroLabelMemberId.Text);
            if (metroLabelMemberId.Text != "0" && metroLabelMemberId.Text != null && isValidDelete(deleteID))
            {
                using (var context = new KucsaManagementDatabaseEntities())
                {
                    var delUser = new TblMember { MemberId = deleteID };
                    context.TblMembers.Attach(delUser);
                    context.TblMembers.Remove(delUser);
                    context.SaveChanges();
                    MetroMessageBox.Show(this, delUser.MemberName + " Removed Successfully from the system!", "Successful Removal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LoadMembers();
                }
            }
        }

        private bool isValidDelete(int deleteID)
        {
            //Method to check if an entry is used as a foreign key, it should return false
            using (var context = new KucsaManagementDatabaseEntities())
            {
                var memberToDelete = context.TblProjects.SingleOrDefault(member => member.MemberId == deleteID);
                if (memberToDelete != null) { return false; }
                else { return true; }
            }

            //return true;
        }
    }
}
