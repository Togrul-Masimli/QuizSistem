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
    public partial class StudentSettingsForm : Form
    {
        Student currentStudent;
        public StudentSettingsForm(Student student)
        {
            InitializeComponent();
            currentStudent = student;
        }

        private void StudentSettingsForm_Load(object sender, EventArgs e)
        {
            emailBox.Enabled = false;
            emailBox.Text = currentStudent.Email;
            usernameBox.Text = currentStudent.Name;
            passwordBox.Text = currentStudent.Password;

            if (checkBox1.Checked)
            {
                passwordBox.PasswordChar = '\0';
            }
            else
            {
                passwordBox.PasswordChar = '*';
            }
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

        private void clearBtn_Click(object sender, EventArgs e)
        {
            usernameBox.Clear();
            passwordBox.Clear();
        }

        private void exitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentForm studentForm = new StudentForm(currentStudent);
            studentForm.ShowDialog();
            this.Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            using (QuizSystemDbContext context = new QuizSystemDbContext())
            {
                currentStudent.Email = emailBox.Text;
                currentStudent.Name = usernameBox.Text;
                currentStudent.Password = passwordBox.Text;

                context.Students.Update(currentStudent);
                context.SaveChanges();

                MessageBox.Show("Updated Succesfully");
                this.Hide();
                SignInForm signIn = new SignInForm();
                signIn.ShowDialog();
                this.Close();
            }
        }
    }
}
