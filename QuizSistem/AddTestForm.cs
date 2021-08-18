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
    public partial class AddTestForm : Form
    {
        Teacher currentTeacher;
        Quiz currentQuiz;
        private int counter = 0;
        public AddTestForm(Teacher teacher,Quiz quiz)
        {
            InitializeComponent();
            currentTeacher = teacher;
            currentQuiz = quiz;
        }

        private void AddTestForm_Load(object sender, EventArgs e)
        {
         
        }

        private void addTestBtn_Click(object sender, EventArgs e)
        {
            using (QuizSystemDbContext context = new QuizSystemDbContext())
            {
                if (string.IsNullOrEmpty(quizNameBox.Text.Trim()))
                {
                    MessageBox.Show("Please fill in the quiz name field");
                }
                else
                {
                    if (string.IsNullOrEmpty(testTitleBox.Text.Trim()) || string.IsNullOrEmpty(testBodyBox.Text.Trim())
                    || string.IsNullOrEmpty(aAnswerBox.Text.Trim()) || string.IsNullOrEmpty(bAnswerBox.Text.Trim())
                        || string.IsNullOrEmpty(cAnswerBox.Text.Trim()) || string.IsNullOrEmpty(dAnswerBox.Text.Trim()) ||
                         correctAnswerBox.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please fill all fields. ");
                    }
                    else
                    {
                        var test = new Test
                        {
                            Title = testTitleBox.Text.Trim(),
                            Body = testBodyBox.Text.Trim(),
                            A = aAnswerBox.Text.Trim(),
                            B = bAnswerBox.Text.Trim(),
                            C = cAnswerBox.Text.Trim(),
                            D = dAnswerBox.Text.Trim(),
                            CorrectAnswer = correctAnswerBox.SelectedItem.ToString(),
                            TeacherId = currentTeacher.Id,
                            QuizId = currentQuiz.Id
                        };

                        context.Tests.Add(test);
                        context.SaveChanges();
                        counter++;
                        MessageBox.Show($"Test {counter} Added Succesfully");
                        addTestLabel.Text = $"Add Test {counter + 1}";

                        testTitleBox.Text = "";
                        testBodyBox.Text = "";
                        aAnswerBox.Text = "";
                        bAnswerBox.Text = "";
                        cAnswerBox.Text = "";
                        dAnswerBox.Text = "";
                        correctAnswerBox.SelectedIndex = -1;
                    }
                     
                }
            }

             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (counter!=0)
            {
                using (QuizSystemDbContext context = new QuizSystemDbContext())
                {
                    currentQuiz.Name = quizNameBox.Text.Trim();
                    currentQuiz.QuestionCount = counter;
                    context.Quizes.Update(currentQuiz);
                    context.SaveChanges();
                }

                MessageBox.Show($"{currentQuiz.Name} Quiz Added Succesfully");
            }
            else
            {
                MessageBox.Show("Please add test");
            }
             
            quizNameBox.Text = "";
            testTitleBox.Text = "";
            testBodyBox.Text = "";
            aAnswerBox.Text = "";
            bAnswerBox.Text = "";
            cAnswerBox.Text = "";
            dAnswerBox.Text = "";
            correctAnswerBox.SelectedIndex = -1;
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
    }
}
