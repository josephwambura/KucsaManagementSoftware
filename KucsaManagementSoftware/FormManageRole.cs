using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KucsaManagementSoftware
{
    public delegate void RefreshRoleDelegate();
    public partial class FormManageRole : MetroForm
    {
        public RefreshRoleDelegate refreshRoleList;
        public FormManageRole()
        {
            InitializeComponent();
        }

        private void InitializeRoleList()
        {
            using (var context = new KucsaManagementDatabaseEntities())
            {
                var roles = from rol in context.TblRoles
                              select new
                              {
                                  rol.RoleId,
                                  rol.RoleName,
                              };

                MetroGridRoles.DataSource = roles.ToList();
            }
        }

        private void FormManageRole_Load(object sender, EventArgs e)
        {
            InitializeRoleList();
        }

        private bool IsValidRole(string title)
        {
            using (var context = new KucsaManagementDatabaseEntities())
            {
                if (context.TblRoles.Any(role => role.RoleName == title))
                    return false;
            }
            return true;
        }

        private void FormManageRole_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (refreshRoleList != null)
            //{
            //    refreshRoleList();
            //}

            //replacing the above with 
            refreshRoleList?.Invoke();
        }

        private void MetroButtonSaveRole_Click(object sender, EventArgs e)
        {
            int rolId = Convert.ToInt32(metroLabelRoleId.Text);
            string roleName = MetroTextBoxRoleName.Text;

            //validate not to duplicate Roles
            if (!IsValidRole(roleName))
            {
                MetroMessageBox.Show(this, "Role with the name " + roleName + " already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (roleName != "")
            {
                using (var context = new KucsaManagementDatabaseEntities())
                {
                    if (rolId == 0)
                    {
                        TblRole role = new TblRole
                        {
                            RoleName = roleName
                        };
                        context.TblRoles.Add(role);

                        try
                        {
                            context.SaveChanges();
                        }
                        catch (Exception es)
                        {
                            MetroMessageBox.Show(this, es.ToString(), "Entity Framework Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        MetroMessageBox.Show(this, roleName + " Role Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        var roleToUpdate = context.TblRoles.SingleOrDefault(role => role.RoleId == rolId);
                        if (roleToUpdate != null)
                        {
                            roleToUpdate.RoleName = roleName;
                        }
                        try
                        {
                            context.SaveChanges();
                        }
                        catch (Exception es)
                        {
                            MetroMessageBox.Show(this, es.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        MetroMessageBox.Show(this, roleName + " Updated Successfully!", "Successful Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                InitializeRoleList();
            }
        }

        private void MetroButtonClearRoles_Click(object sender, EventArgs e)
        {
            metroLabelRoleId.Text = "0";
            MetroTextBoxRoleName.Text = string.Empty;

            MetroButtonSaveRole.Text = "Save";
        }

        private void MetroGridRoles_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;
            MetroGridRoles.MultiSelect = false;

            if (MetroGridRoles.SelectedRows.Count > 0)
            {
                selectedRow = MetroGridRoles.SelectedRows[0];
            }

            if (selectedRow == null)
                return;

            metroLabelRoleId.Text = selectedRow.Cells["RoleId"].Value.ToString();
            MetroTextBoxRoleName.Text = selectedRow.Cells["RoleName"].Value.ToString();

            MetroButtonSaveRole.Text = "Update";
        }

        private void MetroButtonDelete_Click(object sender, EventArgs e)
        {
            int deleteID = Convert.ToInt32(metroLabelRoleId.Text);
            if (metroLabelRoleId.Text != "0" && metroLabelRoleId.Text != null && isValidDelete(deleteID))
            {
                using (var context = new KucsaManagementDatabaseEntities())
                {
                    var delRole = new TblRole { RoleId = deleteID };
                    context.TblRoles.Attach(delRole);
                    context.TblRoles.Remove(delRole);
                    context.SaveChanges();
                    MetroMessageBox.Show(this, delRole.RoleName + " Removed Successfully from the system!", "Successful Removal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    InitializeRoleList();
                }
            }
        }

        private bool isValidDelete(int deleteID)
        {
            //Method to check if an entry is used as a foreign key, it should return false
            using(var context = new KucsaManagementDatabaseEntities())
            {
                var roleToDelete = context.TblMembers.SingleOrDefault(role => role.RoleId == deleteID);
                if (roleToDelete != null) { return false; }
            }

            return true;
        }
    }
}
