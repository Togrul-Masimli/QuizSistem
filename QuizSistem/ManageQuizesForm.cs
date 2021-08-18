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
    public partial class ManageQuizesForm : Form
    {
        private int index = 0;
        Teacher currentTeacher;
        List<Quiz> _quizes = new List<Quiz>();
        public ManageQuizesForm(Teacher teacher)
        {
            InitializeComponent();
            currentTeacher = teacher;
        }
        private void ShowSelfQuizes()
        {
            using (QuizSystemDbContext context = new QuizSystemDbContext())
            {
                var tests = context.Tests.Where(t => t.TeacherId == currentTeacher.Id).ToList();
                for (int i = 0; i < tests.Count; i++)
                {
                    var quize = context.Quizes.Where(q => q.Id == tests[i].QuizId).FirstOrDefault();
                    if (!_quizes.Contains(quize))
                    {
                        _quizes.Add(quize);
                    }          
                }
                 
                dataGridView1.DataSource = _quizes;
            }
        }
        private void ManageQuizesForm_Load(object sender, EventArgs e)
        {
            ShowSelfQuizes();
        }

        

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            using (QuizSystemDbContext context = new QuizSystemDbContext())
            {
                var deletedQuiz = context.Quizes.FirstOrDefault(x => x.Id == index);
                context.Quizes.Remove(deletedQuiz);
                context.SaveChanges();
                MessageBox.Show($"{deletedQuiz.Name}- Deleted");
                this.quizesTableAdapter.Fill(this.quizSystemDBDataSet.Quizes);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            using (QuizSystemDbContext context = new QuizSystemDbContext())
            {
                var updatedQuiz = context.Quizes.FirstOrDefault(x => x.Id == index);
                updatedQuiz.Name = nameBox.Text;
                context.Quizes.Update(updatedQuiz);
                context.SaveChanges();
                MessageBox.Show($"{updatedQuiz.Name}- Updated");
                this.quizesTableAdapter.Fill(this.quizSystemDBDataSet.Quizes);
            }
        }

        private void backBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherForm teacherForm = new TeacherForm(currentTeacher);
            teacherForm.ShowDialog();
            this.Close();
        }

        private void exitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            nameBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
