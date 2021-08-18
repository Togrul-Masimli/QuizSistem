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
    public partial class AdminManageTestsForm : Form
    {
        private int index = 0;
        
        public AdminManageTestsForm()
        {
            InitializeComponent();
        }

        private void AdminManageTestsForm_Load(object sender, EventArgs e)
        {
            using (QuizSystemDbContext context = new QuizSystemDbContext())
            {
                var quizes = context.Quizes.ToList();
                foreach (var quiz in quizes)
                {
                    if (quiz.Name!=null)
                    {
                        quizesComboBox.Items.Add(quiz.Name);
                    } 
                }
                quizesComboBox.SelectedItem = quizes[0].Name;
                ShowTests();

            }
        }
        private void ShowTests()
        {
            using (QuizSystemDbContext context = new QuizSystemDbContext())
            {
                var selectedQuize = context.Quizes.Where(q => q.Name == quizesComboBox.SelectedItem.ToString()).FirstOrDefault();
                var tests = (from test in context.Tests
                             join teacher in context.Teachers
                              on test.TeacherId equals teacher.Id
                             where test.QuizId == selectedQuize.Id
                             select new
                             {
                                 Id = test.Id,
                                 Title = test.Title,
                                 Body = test.Body,
                                 A = test.A,
                                 B = test.B,
                                 C = test.C,
                                 D = test.D,
                                 Correct = test.CorrectAnswer,
                                 TeacherName = teacher.Name
                             }).ToList();

                dataGridView1.DataSource = tests;
            }

        }
         

        


        private void backBox_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.ShowDialog();
            this.Close();
        }

        private void exitBox_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deleteBtn_Click_1(object sender, EventArgs e)
        {
            using (QuizSystemDbContext context = new QuizSystemDbContext())
            {
                var deletedTest = context.Tests.FirstOrDefault(x => x.Id == index);
                var selectedQuize = context.Quizes.Where(q => q.Name == quizesComboBox.SelectedItem.ToString()).FirstOrDefault();
                selectedQuize.QuestionCount--;
                context.Tests.Remove(deletedTest);
                context.SaveChanges();
                MessageBox.Show($"{deletedTest.Title} - Deleted");
                ShowTests();
            }
        }

        private void updateBtn_Click_1(object sender, EventArgs e)
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
                MessageBox.Show($"{updatedTest.Title} - Updated");
                ShowTests();
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
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

        private void quizesComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ShowTests();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (quizesComboBox.SelectedIndex == -1 || string.IsNullOrEmpty(bodyBox.Text)
                || string.IsNullOrEmpty(titleBox.Text) || string.IsNullOrEmpty(aBox.Text)
                || string.IsNullOrEmpty(bBox.Text) || string.IsNullOrEmpty(cBox.Text)
                || string.IsNullOrEmpty(dBox.Text) || correctAnswerBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in the all fields");
            }
            else
            {
                using (QuizSystemDbContext context = new QuizSystemDbContext())
                {
                     
                    var selectedQuize = context.Quizes.Where(q => q.Name == quizesComboBox.SelectedItem.ToString()).FirstOrDefault();
                    var currentTest = context.Tests.Where(te => te.QuizId == selectedQuize.Id).FirstOrDefault();
                    var currentTeacher = context.Teachers.Where(t => t.Id == currentTest.TeacherId).FirstOrDefault();
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
                    MessageBox.Show($"{test.Title} - Added");

                    bodyBox.Clear();
                    titleBox.Clear();
                    aBox.Clear();
                    bBox.Clear();
                    cBox.Clear();
                    dBox.Clear();
                    correctAnswerBox.SelectedIndex = -1;
                }
            }
            ShowTests();
        }
    }
}
