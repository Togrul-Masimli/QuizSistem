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
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
            using (var context = new QuizSystemDbContext())
            {
                if (!context.Admin.Any(x => x.Id == 1))
                {
                    var admin = new Admin
                    {
                        Name = "Admin",
                        Email = "admin@admin.com",
                        Password = "123456"
                    };
                    context.Admin.Add(admin);
                    context.SaveChanges();
                }
            }
            PasswordHide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            StudentSignUp stdSign = new StudentSignUp();
            stdSign.ShowDialog();
            this.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            TeacherSignUp tchSign = new TeacherSignUp();
            tchSign.ShowDialog();
            this.Close();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            using (QuizSystemDbContext context = new QuizSystemDbContext())
            {
                var student = context.Students.Where(x => x.Email == emailBox.Text && x.Password == passwordBox.Text).FirstOrDefault();
                var teacher = context.Teachers.Where(x => x.Email == emailBox.Text && x.Password == passwordBox.Text).FirstOrDefault();
                var admin = context.Admin.Where(x => x.Email == emailBox.Text && x.Password == passwordBox.Text).FirstOrDefault();

                if (student != null)
                {
                    this.Hide();
                    StudentForm stdForm = new StudentForm(student);
                    stdForm.ShowDialog();
                    this.Close();
                }
                else if (teacher != null)
                {
                    this.Hide();
                    TeacherForm tchForm = new TeacherForm(teacher);
                    tchForm.ShowDialog();
                    this.Close();
                }
                else if (admin != null)
                {
                    this.Hide();
                    AdminForm adminForm = new AdminForm();
                    adminForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Email or password is wrong");
                }

            }
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            PasswordHide();
        }

        private void PasswordHide()
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
            emailBox.Clear();
            passwordBox.Clear();
        }
    }
}
