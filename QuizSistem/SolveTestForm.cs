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
    public partial class SolveTestForm : Form
    {
        Quiz currentQuiz;
        Student currentStudent;
        List<Test> tests;
        int testIndex = 0;
        private int corrects = 0;
        private string correctAnswer;
        public SolveTestForm(Quiz quiz,Student student)
        {
            InitializeComponent();
            currentQuiz = quiz;
            currentStudent = student;
        }

        private void SolveTestForm_Load(object sender, EventArgs e)
        {
            quizName.Text = currentQuiz.Name;
            

            using (QuizSystemDbContext context = new QuizSystemDbContext())
            {
                var tests1 = from t in context.Tests
                             where t.QuizId == currentQuiz.Id
                             select t;
                tests = tests1.ToList();
            }


            testTitle.Text = tests[0].Title;
            testBody.Text = tests[0].Body;
            answerACheck.Text = tests[0].A;
            answerBCheck.Text = tests[0].B;
            answerCCheck.Text = tests[0].C;
            answerDCheck.Text = tests[0].D;

            if (tests.Count == 1)
            {
                nextBtn.Enabled = false;
            }

             

        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            testIndex++;
            answerACheck.Checked = false;
            answerBCheck.Checked = false;
            answerCCheck.Checked = false;
            answerDCheck.Checked = false;

            answerACheck.Enabled = true;
            answerBCheck.Enabled = true;
            answerCCheck.Enabled = true;
            answerDCheck.Enabled = true;

             

             

            testTitle.Text = tests[testIndex].Title;
            testBody.Text = tests[testIndex].Body;
            answerACheck.Text = tests[testIndex].A;
            answerBCheck.Text = tests[testIndex].B;
            answerCCheck.Text = tests[testIndex].C;
            answerDCheck.Text = tests[testIndex].D;

            if (testIndex == tests.Count - 1)
            {
                nextBtn.Enabled = false;
            }

             
            
            
            //for (int i = 1; i < tests.Count; i++)
            //{
            //    testTitle.Text = tests[i].Title;
            //    testBody.Text = tests[i].Body;
            //    answerACheck.Text = tests[i].A;
            //    answerBCheck.Text = tests[i].B;
            //    answerCCheck.Text = tests[i].C;
            //    answerDCheck.Text = tests[i].D;

            //    if (i == tests.Count -1)
            //    {
            //        nextBtn.Enabled = false;
            //    }

            //    if (tests[i].CorrectAnswer == correctAnswer)
            //    {
            //        corrects++;
            //    }

            //}


        }

        private void answerACheck_CheckedChanged(object sender, EventArgs e)
        {
            if (answerACheck.Checked)
            {
                answerBCheck.Enabled = false;
                answerCCheck.Enabled = false;
                answerDCheck.Enabled = false;

                correctAnswer = "A";
                if (tests[testIndex].CorrectAnswer == correctAnswer)
                {
                    corrects++;
                }
            }
        }

        private void answerBCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (answerBCheck.Checked)
            {
                answerACheck.Enabled = false;
                answerCCheck.Enabled = false;
                answerDCheck.Enabled = false;

                correctAnswer = "B";
                if (tests[testIndex].CorrectAnswer == correctAnswer)
                {
                    corrects++;
                }
            }
        }

        private void answerCCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (answerCCheck.Checked)
            {
                answerBCheck.Enabled = false;
                answerACheck.Enabled = false;
                answerDCheck.Enabled = false;

                correctAnswer = "C";
                if (tests[testIndex].CorrectAnswer == correctAnswer)
                {
                    corrects++;
                }
            }
        }

        private void answerDCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (answerDCheck.Checked)
            {
                answerBCheck.Enabled = false;
                answerCCheck.Enabled = false;
                answerACheck.Enabled = false;

                correctAnswer = "D";
                if (tests[testIndex].CorrectAnswer == correctAnswer)
                {
                    corrects++;
                }
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (tests[0].CorrectAnswer == correctAnswer)
            {
                corrects++;
            }
            MessageBox.Show($"Your correct answers count: {corrects}");

            using (QuizSystemDbContext context = new QuizSystemDbContext())
            {
                var student_quiz = new Student_Quizes
                {
                    QuizId = currentQuiz.Id,
                    StudentId = currentStudent.Id
                };
                context.Students_Quizes.Add(student_quiz);
                context.SaveChanges();
            }

            using (QuizSystemDbContext context = new QuizSystemDbContext())
            {
                var studentResult = new StudentResult
                {
                    StudentId = currentStudent.Id,
                    QuizId = currentQuiz.Id,
                    CorrectAnswers = corrects
                };
                context.StudentResults.Add(studentResult);
                context.SaveChanges();
            }

            this.Hide();
            StudentForm studentForm = new StudentForm(currentStudent);
            studentForm.ShowDialog();
            this.Close();
        }

        private void backBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentForm studentForm = new StudentForm(currentStudent);
            studentForm.ShowDialog();
            this.Close();
        }

        private void exitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
