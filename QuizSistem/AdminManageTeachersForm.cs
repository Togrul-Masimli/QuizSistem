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
    public partial class AdminManageTeachersForm : Form
    {
        public AdminManageTeachersForm()
        {
            InitializeComponent();
        }

        private void AdminManageTeachersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizSystemDBDataSet3.Teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.quizSystemDBDataSet3.Teachers);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nameTxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            emailTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            passwordTxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            using (QuizSystemDbContext context = new QuizSystemDbContext())
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                var teacher = context.Teachers.FirstOrDefault(s => s.Id == id);
                context.Teachers.Remove(teacher);
                context.SaveChanges();
                this.teachersTableAdapter.Fill(this.quizSystemDBDataSet3.Teachers);

            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            using (QuizSystemDbContext context = new QuizSystemDbContext())
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                var teacher = context.Teachers.FirstOrDefault(s => s.Id == id);
                teacher.Name = nameTxt.Text;
                teacher.Email = emailTxt.Text;
                teacher.Password = passwordTxt.Text;
                context.Teachers.Update(teacher);
                context.SaveChanges();
                this.teachersTableAdapter.Fill(this.quizSystemDBDataSet3.Teachers);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
