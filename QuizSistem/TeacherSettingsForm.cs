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
    public partial class TeacherSettingsForm : Form
    {
        Teacher currentTeacher;
        public TeacherSettingsForm(Teacher teacher)
        {
            InitializeComponent();
            currentTeacher = teacher;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            using (QuizSystemDbContext context = new QuizSystemDbContext())
            {
                currentTeacher.Name = usernameBox.Text;
                currentTeacher.Email = emailBox.Text;
                currentTeacher.Password = passwordBox.Text;

                context.Teachers.Update(currentTeacher);
                context.SaveChanges();
            }

            MessageBox.Show("Updated Succesfully");
            this.Hide();
            SignInForm signIn = new SignInForm();
            signIn.ShowDialog();
            this.Close();
        }

        private void TeacherSettingsForm_Load(object sender, EventArgs e)
        {
            emailBox.Enabled = false;
            usernameBox.Text = currentTeacher.Name;
            emailBox.Text = currentTeacher.Email;
            passwordBox.Text = currentTeacher.Password;

            if (checkBox1.Checked)
            {
                passwordBox.PasswordChar = '\0';
            }
            else
            {
                passwordBox.PasswordChar = '*';
            }
        }

        private void exitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherForm teacherForm = new TeacherForm(currentTeacher);
            teacherForm.ShowDialog();
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            usernameBox.Clear();
            passwordBox.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordBox.PasswordChar = '\0';
            }
            else
            {
                passwordBox.PasswordChar = '*';
            }
        }
    }
}
