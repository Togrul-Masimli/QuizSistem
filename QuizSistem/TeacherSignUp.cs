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
    public partial class TeacherSignUp : Form
    {
        public TeacherSignUp()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignInForm signInForm = new SignInForm();
            signInForm.ShowDialog();
            this.Close();
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string password = PasswordGenerator.GeneratePassword();

            using (QuizSystemDbContext context = new QuizSystemDbContext())
            {
                 
                if (context.Teachers.Any(t=>t.Email == emailBox.Text))
                {
                    MessageBox.Show("This email has been used.");
                }
                else
                {
                    if (IsValidEmail(emailBox.Text))
                    {
                        var teacher = new Teacher
                        {
                            Name = usernameBox.Text,
                            Email = emailBox.Text,
                            Password = password
                        };
                        context.Teachers.Add(teacher);
                        context.SaveChanges();

                        GmailSender.SendGmail(teacher.Email, teacher.Name, teacher.Password);

                        this.Hide();
                        SignInForm signInForm = new SignInForm();
                        signInForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("This is not email.");
                    }
                     
                }     
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            usernameBox.Clear();
            emailBox.Clear();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignInForm signInForm = new SignInForm();
            signInForm.ShowDialog();
            this.Close();
        }

        private void TeacherSignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
