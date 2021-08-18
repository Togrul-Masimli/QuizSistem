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
    public partial class AdminManageQuizesForm : Form
    {
        private int index = 0;
        public AdminManageQuizesForm()
        {
            InitializeComponent();
        }
        
        private void AdminManageQuizesForm_Load(object sender, EventArgs e)
        {
            ShowQuizes();
        }
        private void ShowQuizes()
        {
            using (QuizSystemDbContext context = new QuizSystemDbContext())
            {
                //var quizes = (from q in context.Quizes
                //             join test in context.Tests on q.Id equals test.QuizId
                //             join t in context.Teachers on test.TeacherId equals t.Id
                //             select new
                //             {
                //                 Id = q.Id,
                //                 QuizName = q.Name,
                //                 Count = q.QuestionCount,
                //                 Teacher = t.Name
                //             }).ToList();
                var quizes = context.Quizes.Where(q=>q.Name!=null).ToList();
                dataGridView1.DataSource = quizes;
            }
        }
         

         

         

        private void exitBox_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deleteBtn_Click_1(object sender, EventArgs e)
        {
            using (QuizSystemDbContext context = new QuizSystemDbContext())
            {
                var deletedQuiz = context.Quizes.FirstOrDefault(x => x.Id == index);
                context.Quizes.Remove(deletedQuiz);
                context.SaveChanges();
                MessageBox.Show($"{deletedQuiz.Name}- Deleted");
                ShowQuizes();
                nameBox.Clear();
            }
        }

        private void updateBtn_Click_1(object sender, EventArgs e)
        {
            using (QuizSystemDbContext context = new QuizSystemDbContext())
            {
                var updatedQuiz = context.Quizes.FirstOrDefault(x => x.Id == index);
                updatedQuiz.Name = nameBox.Text;
                context.Quizes.Update(updatedQuiz);
                context.SaveChanges();
                MessageBox.Show($"{updatedQuiz.Name}- Updated");
                ShowQuizes();
                nameBox.Clear();
            }
        }

        private void backBox_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
            this.Close();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            index = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            nameBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
