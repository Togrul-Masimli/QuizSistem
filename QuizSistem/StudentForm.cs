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
    public partial class StudentForm : Form
    {
        Student currentStudent;
        public StudentForm(Student student)
        {
            InitializeComponent();
            currentStudent = student;
        }

        private void quizBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectQuizForm selectQuiz = new SelectQuizForm(currentStudent);
            selectQuiz.ShowDialog();
            this.Close();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            studentLbl.Text = currentStudent.Name;
        }

        private void solvedQuizesBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentSolvedQuizes solvedQuizes = new StudentSolvedQuizes(currentStudent);
            solvedQuizes.ShowDialog();
            this.Close();
        }

         

        private void logoutBox_Click(object sender, EventArgs e)
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentSettingsForm studentSettings = new StudentSettingsForm(currentStudent);
            studentSettings.ShowDialog();
            this.Close();
        }
    }
}
