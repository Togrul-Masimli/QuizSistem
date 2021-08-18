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
    public partial class TeacherForm : Form
    {
        Teacher currentTeacher;
        public TeacherForm(Teacher teacher)
        {
            InitializeComponent();
            currentTeacher = teacher;
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            label1.Text = currentTeacher.Name;
        }

        private void addTestBtn_Click(object sender, EventArgs e)
        {
            using (QuizSystemDbContext context = new QuizSystemDbContext())
            {
                var quiz = new Quiz();
                context.Quizes.Add(quiz);
                context.SaveChanges();
                this.Hide();
                AddTestForm testForm = new AddTestForm(currentTeacher, quiz);
                testForm.ShowDialog();
                this.Close();
            };
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherSettingsForm settingsForm = new TeacherSettingsForm(currentTeacher);
            settingsForm.ShowDialog();
            this.Close();
        }

        private void testsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageTestsForm manageTests = new ManageTestsForm(currentTeacher);
            manageTests.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageQuizesForm manageQuizes = new ManageQuizesForm(currentTeacher);
            manageQuizes.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInForm signIn = new SignInForm();
            signIn.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
