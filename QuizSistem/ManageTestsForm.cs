using Microsoft.Data.SqlClient;
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
    
    public partial class ManageTestsForm : Form
    {
        Teacher currentTeacher;
        private int index = 0;
        List<Quiz> _quizes = new List<Quiz>();
        public ManageTestsForm(Teacher teacher)
        {
            InitializeComponent();
            currentTeacher = teacher;
        }
        public void ShowSelfTests()
        {
            using (QuizSystemDbContext context = new QuizSystemDbContext())
            {
                var selectedQuize = context.Quizes.Where(q => q.Name == quizesComboBox.SelectedItem.ToString()).FirstOrDefault();
                var tests = context.Tests.Where(t => t.TeacherId == currentTeacher.Id && t.QuizId == selectedQuize.Id).ToList();
                DataTable dt = new DataTable();
                dataGridView1.DataSource = tests;            
            }
        }
        private void ManageTestsForm_Load(object sender, EventArgs e)
        {

            using (QuizSystemDbContext context = new QuizSystemDbContext())
            {
                var tests = context.Tests.Where(t => t.TeacherId == currentTeacher.Id).ToList();
                foreach (var test in tests)
                {
                    Quiz quiz = context.Quizes.Where(q => q.Id == test.QuizId).FirstOrDefault();
                    if (!_quizes.Contains(quiz)&& quiz.Name!=null)
                    {
                        _quizes.Add(quiz);
                    }
                     
                }
                foreach (var quiz in _quizes)
                {
                    quizesComboBox.Items.Add(quiz.Name);
                }
            }

            dataGridView1.Enabled = false;
             

        }

         

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            using (QuizSystemDbContext context = new QuizSystemDbContext())
            {
                var deletedTest = context.Tests.FirstOrDefault(x => x.Id == index);
                context.Tests.Remove(deletedTest);
                var selectedQuize = context.Quizes.Where(q => q.Name == quizesComboBox.SelectedItem.ToString()).FirstOrDefault();
                selectedQuize.QuestionCount--;
                context.SaveChanges();
                MessageBox.Show($"{deletedTest.Title}- Deleted");
                ShowSelfTests();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            using (QuizSystemDbContext context = new QuizSystemDbContext())
            {
                var updatedTest = context.Tests.FirstOrDefault(x => x.Id == index);
                updatedTest.Title = titleBox.Text;
                updatedTest.Body = bodyBox.Text;
                updatedTest.A = aBox.Text;
                updatedTest.B = bBox.Text;
                updatedTest.C = cBox.Text;
                updatedTest.D = dBox.Text;
                updatedTest.CorrectAnswer = correctAnswerBox.SelectedItem.ToString();

                context.Tests.Update(updatedTest);
                context.SaveChanges();
                MessageBox.Show($"{updatedTest.Title}- Updated");
                ShowSelfTests();
            }
        }

        private void quizesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Enabled = true;
            ShowSelfTests();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            titleBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            bodyBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            aBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            bBox.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            cBox.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            dBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            correctAnswerBox.SelectedItem = dataGridView1.CurrentRow.Cells[7].Value;
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (quizesComboBox.SelectedIndex==-1 || string.IsNullOrEmpty(bodyBox.Text)
                || string.IsNullOrEmpty(titleBox.Text) || string.IsNullOrEmpty(aBox.Text)
                || string.IsNullOrEmpty(bBox.Text)|| string.IsNullOrEmpty(cBox.Text)
                || string.IsNullOrEmpty(dBox.Text) || correctAnswerBox.SelectedIndex==-1)
            {
                MessageBox.Show("Please fill in the all fields");
            }
            else
            {
                using (QuizSystemDbContext context = new QuizSystemDbContext())
                {
                    var selectedQuize = context.Quizes.Where(q => q.Name == quizesComboBox.SelectedItem.ToString()).FirstOrDefault();

                    var test = new Test
                    {
                        Body = bodyBox.Text,
                        Title = titleBox.Text,
                        A = aBox.Text,
                        B = bBox.Text,
                        C = cBox.Text,
                        D = dBox.Text,
                        CorrectAnswer = correctAnswerBox.SelectedItem.ToString(),
                        QuizId = selectedQuize.Id,
                        TeacherId = currentTeacher.Id
                    };

                    context.Tests.Add(test);
                    selectedQuize.QuestionCount++;
                    context.SaveChanges();

                    bodyBox.Clear();
                    titleBox.Clear();
                    aBox.Clear();
                    bBox.Clear();
                    cBox.Clear();
                    dBox.Clear();
                    correctAnswerBox.SelectedIndex = -1;
                }
            }
            ShowSelfTests();
        }
    }
}
