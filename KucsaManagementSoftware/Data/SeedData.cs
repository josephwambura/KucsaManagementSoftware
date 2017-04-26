using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KucsaManagementSoftware.Data
{
    public class SeedData
    {
        private byte[] bigPicture;
        public byte[] ThumbNP()
        {
            byte[] thumbNailPhoto = null;
            return thumbNailPhoto;
        }
        public byte[] BigPictureNP()
        {
            try {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    FileStream fsBLOBFile = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);

                    bigPicture = new Byte[fsBLOBFile.Length];

                    fsBLOBFile.Read(bigPicture, 0, bigPicture.Length);
                    fsBLOBFile.Close();

                    //MemoryStream stmBLOBData = new MemoryStream(bigPicture);
                    //PictureBox pb = new PictureBox();
                    //pb.Image = Image.FromStream(stmBLOBData);
                }
            }
            catch (Exception)
            {
                throw;
            }
            return bigPicture;
        }
        
        public void Initialize()
        {
            try
            {
                using (var context = new KucsaManagementDatabaseEntities())
                {
                    context.Database.CreateIfNotExists();

                    if (context.TblMembers.Any())
                        return;

                    var course = new TblCourse[]
                    {
                    new TblCourse{CourseName="Software Engineering",CourseFaculty="FIST"},
                    new TblCourse{CourseName="Computer Science",CourseFaculty="FIST"},
                    new TblCourse{CourseName="Applied Computer Science",CourseFaculty="FIST"},
                    };

                    foreach (TblCourse c in course)
                    {
                        context.TblCourses.Add(c);
                    }
                    context.SaveChanges();

                    var language = new TblLanguage[]
                    {
                    new TblLanguage{Language="CSharp",LanguageAuthor="Billy",LanguageTuitorial="github.com/Docs/Csharp",LanguageWebsite="www.microsoft.com",},
                    new TblLanguage{Language="Java",LanguageAuthor="Microsuns",LanguageTuitorial="www.javatuitorialspoint.com",LanguageWebsite="www.java.com",},
                    new TblLanguage{Language="Javascript",LanguageAuthor="Githithu",LanguageTuitorial="www.w3schools.com",LanguageWebsite="www.javascript.com",},
                    };

                    foreach (TblLanguage l in language)
                    {
                        context.TblLanguages.Add(l);
                    }
                    context.SaveChanges();

                    var module = new TblModule[]
                    {
                    new TblModule{Title="CSharp Applications",ModuleLeader="Githithu"},
                    new TblModule{Title="Android Applications",ModuleLeader="Benson"},
                    new TblModule{Title="Web Development",ModuleLeader="Gabriel"},
                    new TblModule{Title="Video Editting",ModuleLeader="Erick"},
                    };

                    foreach (TblModule m in module)
                    {
                        context.TblModules.Add(m);
                    }
                    context.SaveChanges();

                    var role = new TblRole[]
                    {
                    new TblRole{RoleName="Chairman"},
                    new TblRole{RoleName="Treasurer"},
                    new TblRole{RoleName="Vice-Chair"},
                    new TblRole{RoleName="Member"},
                    };

                    foreach (TblRole r in role)
                    {
                        context.TblRoles.Add(r);
                    }
                    context.SaveChanges();

                    var member = new TblMember[]
                    {
                    new TblMember{MemberName="Githithu",MemberRegistration="IN16/20143/13",MemberBigPicture=BigPictureNP(),CourseId=1,ModuleId=1,RoleId=2,},
                    new TblMember{MemberName="Okiora",MemberRegistration="INP16/20257/13",CourseId=1,ModuleId=2,RoleId=1,},
                    new TblMember{MemberName="Otenyo",MemberRegistration="IN16/20168/13",CourseId=1,ModuleId=3,RoleId=3,},
                    new TblMember{MemberName="Taka",MemberRegistration="IN14/20132/13",CourseId=3,ModuleId=1,RoleId=4,},
                    };

                    foreach (TblMember m in member)
                    {
                        context.TblMembers.Add(m);
                    }
                    context.SaveChanges();

                    var project = new TblProject[]
                    {
                    new TblProject{ProjectTitle="KUCSA Management Software",ProjectDesc="Desktop Application",ProjectLink="kedevelopers.com",LanguageId=1,MemberId=1},
                    new TblProject{ProjectTitle="ITax Returns",ProjectDesc="Android App",ProjectLink="kedevelopers.com",LanguageId=2,MemberId=2},
                    new TblProject{ProjectTitle="Love Quotes",ProjectDesc="Android App",ProjectLink="kedevelopers.com",LanguageId=2,MemberId=3},
                    };

                    foreach (TblProject p in project)
                    {
                        context.TblProjects.Add(p);
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        
    }
}
