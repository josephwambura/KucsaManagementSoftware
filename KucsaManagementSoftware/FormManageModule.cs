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

namespace KucsaManagementSoftware
{
    public delegate void RefreshModuleDelegate();
    public partial class FormManageModule : MetroForm
    {
        public RefreshModuleDelegate refreshModuleList;
        public FormManageModule()
        {
            InitializeComponent();
        }

        private void InitializeModuleList()
        {
            using (var context = new KucsaManagementDatabaseEntities())
            {
                var modules = from mod in context.TblModules
                              select new
                              {
                                  mod.ModuleId,
                                  mod.Title,
                                  mod.ModuleLeader
                              };

                metroGridModules.DataSource = modules.ToList();
            }
        }

        private void FormManageModule_Load(object sender, EventArgs e)
        {
            InitializeModuleList();
        }

        private void MetroButtonSaveModule_Click(object sender, EventArgs e)
        {
            int modId = Convert.ToInt32(metroLabelModuleId.Text);
            string moduleName = metroTextBoxModuleTitle.Text;
            string moduleLeader = metroTextBoxModuleLeader.Text;

            //validate not to duplicate modules
            if (!IsValidModule(moduleName))
            {
                MetroMessageBox.Show(this, "Module with the name " + moduleName + " already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (moduleName != "")
            {
                using (var context = new KucsaManagementDatabaseEntities())
                {
                    if (modId == 0)
                    {
                        TblModule module = new TblModule
                        {
                            Title = moduleName,
                            ModuleLeader = moduleLeader
                        };
                        context.TblModules.Add(module);

                        try
                        {
                            context.SaveChanges();
                        }
                        catch (Exception es)
                        {
                            MetroMessageBox.Show(this, es.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        MetroMessageBox.Show(this, moduleName + " Module Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        var moduleToUpdate = context.TblModules.SingleOrDefault(module => module.ModuleId == modId);
                        if (moduleToUpdate != null)
                        {
                            moduleToUpdate.Title = moduleName;
                            moduleToUpdate.ModuleLeader = moduleLeader;
                        }
                        try
                        {
                            context.SaveChanges();
                        }
                        catch (Exception es)
                        {
                            MetroMessageBox.Show(this, es.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        MetroMessageBox.Show(this, moduleName + " Updated Successfully!", "Successful Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                InitializeModuleList();
            }
        }

        private void metroButtonClearModules_Click(object sender, EventArgs e)
        {
            metroLabelModuleId.Text = "0";
            metroTextBoxModuleTitle.Text = string.Empty;
            metroTextBoxModuleLeader.Text = string.Empty;

            MetroButtonSaveModule.Text = "Save";
        }

        private void metroGridModules_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;
            metroGridModules.MultiSelect = false;


            if (metroGridModules.SelectedRows.Count > 0)
            {
                selectedRow = metroGridModules.SelectedRows[0];
            }

            if (selectedRow == null)
                return;

            metroLabelModuleId.Text = selectedRow.Cells["ModuleId"].Value.ToString();
            metroTextBoxModuleTitle.Text = selectedRow.Cells["Title"].Value.ToString();
            metroTextBoxModuleLeader.Text = selectedRow.Cells["ModuleLeader"].Value.ToString();
            
            MetroButtonSaveModule.Text = "Update";
        }

        private bool IsValidModule(string title)
        {
            using (var context = new KucsaManagementDatabaseEntities())
            {
                if (context.TblModules.Any(module => module.Title == title))
                    return false;
            }
            return true;
        }

        private void FormManageModule_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (refreshModuleList != null)
            {
                refreshModuleList();
            }
        }
    }
}
