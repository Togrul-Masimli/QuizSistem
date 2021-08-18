using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizSistem
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInForm signIn = new SignInForm();
            signIn.ShowDialog();
            this.Close();
        }

        private void adminSettingBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettingsForm adminSettings = new AdminSettingsForm();
            adminSettings.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void studentsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminManageStudentsForm adminManageStudents = new AdminManageStudentsForm();
            adminManageStudents.ShowDialog();
            this.Close();
        }

        private void teacherBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminManageTeachersForm adminManageTeachers = new AdminManageTeachersForm();
            adminManageTeachers.ShowDialog();
            this.Close();
        }

        private void quizBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminManageQuizesForm adminManageQuizes = new AdminManageQuizesForm();
            adminManageQuizes.ShowDialog();
            this.Close();
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminManageTestsForm adminManageTests = new AdminManageTestsForm();
            adminManageTests.ShowDialog();
            this.Close();
        }
    }
}
