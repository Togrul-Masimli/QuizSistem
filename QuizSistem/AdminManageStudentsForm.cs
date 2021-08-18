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
    public partial class AdminManageStudentsForm : Form
    {
        public AdminManageStudentsForm()
        {
            InitializeComponent();
        }

        private void AdminManageStudentsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizSystemDBDataSet2.Students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.quizSystemDBDataSet2.Students);

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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            using (QuizSystemDbContext context = new QuizSystemDbContext())
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                var student = context.Students.FirstOrDefault(s => s.Id == id);
                student.Name = nameTxt.Text;
                student.Email = emailTxt.Text;
                student.Password = passwordTxt.Text;
                context.Students.Update(student);
                context.SaveChanges();
                this.studentsTableAdapter.Fill(this.quizSystemDBDataSet2.Students);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            using (QuizSystemDbContext context = new QuizSystemDbContext())
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                var student = context.Students.FirstOrDefault(s => s.Id == id);
                context.Students.Remove(student);
                context.SaveChanges();
                this.studentsTableAdapter.Fill(this.quizSystemDBDataSet2.Students);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
