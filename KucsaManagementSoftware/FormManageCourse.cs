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
    public delegate void RefreshCourseDelegate();
    public partial class FormManageCourse : MetroForm
    {
        public RefreshCourseDelegate refreshCourseList;
        public FormManageCourse()
        {
            InitializeComponent();
        }

        private void InitializeCourseList()
        {
            using (var context = new KucsaManagementDatabaseEntities())
            {
                var courses = from cos in context.TblCourses
                              select new
                              {
                                  cos.CourseId,
                                  cos.CourseName,
                                  cos.CourseFaculty
                              };

                MetroGridCourses.DataSource = courses.ToList();
            }
        }

        private void MetroButtonSaveCourse_Click(object sender, EventArgs e)
        {
            int cosId = Convert.ToInt32(metroLabelCourseId.Text);
            string courseName = metroTextBoxCourseName.Text;
            string facultyName = metroTextBoxFaculty.Text;

            //validate not to duplicate modules
            if (!IsValidCourse(courseName))
            {
                MetroMessageBox.Show(this, "Course with the name " + metroTextBoxCourseName.Text + " already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (courseName != "")
            {
                using (var context = new KucsaManagementDatabaseEntities())
                {
                    if (cosId == 0)
                    {
                        TblCourse course = new TblCourse
                        {
                            CourseName = courseName,
                            CourseFaculty = facultyName
                        };
                        context.TblCourses.Add(course);

                        try
                        {
                            context.SaveChanges();
                        }
                        catch (Exception es)
                        {
                            MetroMessageBox.Show(this, es.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        MetroMessageBox.Show(this, courseName + " Course Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        var courseToUpdate = context.TblCourses.SingleOrDefault(course => course.CourseId == cosId);
                        if (courseToUpdate != null)
                        {
                            courseToUpdate.CourseName = courseName;
                            courseToUpdate.CourseFaculty = facultyName;
                        }
                        try
                        {
                            context.SaveChanges();
                        }
                        catch (Exception es)
                        {
                            MetroMessageBox.Show(this, es.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        MetroMessageBox.Show(this, courseName + " Updated Successfully!", "Successful Update", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                InitializeCourseList();
            }
        }

        private void FormManageCourse_Load(object sender, EventArgs e)
        {
            InitializeCourseList();
        }

        private bool IsValidCourse(string title)
        {
            using (var context = new KucsaManagementDatabaseEntities())
            {
                if (context.TblCourses.Any(course => course.CourseName == title))
                    return false;
            }
            return true;
        }

        private void FormManageCourse_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (refreshCourseList != null)
            {
                refreshCourseList();
            }
        }

        private void MetroButtonClearCourses_Click(object sender, EventArgs e)
        {
            metroLabelCourseId.Text = "0";
            metroTextBoxCourseName.Text = string.Empty;
            metroTextBoxFaculty.Text = string.Empty;

            MetroButtonSaveCourse.Text = "Save";
        }

        private void MetroGridCourses_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = null;
            MetroGridCourses.MultiSelect = false;

            if (MetroGridCourses.SelectedRows.Count > 0)
            {
                selectedRow = MetroGridCourses.SelectedRows[0];
            }

            if (selectedRow == null)
                return;

            metroLabelCourseId.Text = selectedRow.Cells["CourseId"].Value.ToString();
            metroTextBoxCourseName.Text = selectedRow.Cells["CourseName"].Value.ToString();
            metroTextBoxFaculty.Text = selectedRow.Cells["CourseFaculty"].Value.ToString();

            MetroButtonSaveCourse.Text = "Update";
        }

        private void MetroButtonDelete_Click(object sender, EventArgs e)
        {
            int deleteID = Convert.ToInt32(metroLabelCourseId.Text);
            if (metroLabelCourseId.Text != "0" && metroLabelCourseId.Text != null && isValidDelete(deleteID))
            {
                using (var context = new KucsaManagementDatabaseEntities())
                {
                    var delCourse = new TblCourse { CourseId = deleteID };
                    context.TblCourses.Attach(delCourse);
                    context.TblCourses.Remove(delCourse);
                    context.SaveChanges();
                    MetroMessageBox.Show(this, delCourse.CourseName + " Removed Successfully from the system!", "Successful Removal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    InitializeCourseList();
                }
            }
        }

        private bool isValidDelete(int deleteID)
        {
            //Method to check if an entry is used as a foreign key, it should return false
            using (var context = new KucsaManagementDatabaseEntities())
            {
                var courseToDelete = context.TblMembers.SingleOrDefault(course => course.CourseId == deleteID);
                if (courseToDelete != null) { return false; }
            }

            return true;
        }
    }
}
