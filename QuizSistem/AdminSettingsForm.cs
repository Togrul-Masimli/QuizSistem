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
    public partial class AdminSettingsForm : Form
    {
        public AdminSettingsForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            passwordBox.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            HidePassword();
        }
        private void HidePassword()
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

        private void AdminSettingsForm_Load(object sender, EventArgs e)
        {
            using (QuizSystemDbContext context = new QuizSystemDbContext())
            {
                int id = 1;
                var admin = context.Admin.FirstOrDefault(a => a.Id == id);
                emailBox.Text = admin.Email;
                passwordBox.Text = admin.Password;
            }
            emailBox.Enabled = false;
            HidePassword();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            using (QuizSystemDbContext context = new QuizSystemDbContext())
            {
                int id = 1;
                var admin = context.Admin.FirstOrDefault(a => a.Id == id);
                admin.Password = passwordBox.Text;
                context.Admin.Update(admin);
                context.SaveChanges();
                this.Hide();
                SignInForm signInForm = new SignInForm();
                signInForm.ShowDialog();
                this.Close();
            }
        }
    }
}
