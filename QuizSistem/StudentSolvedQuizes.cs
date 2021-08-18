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
    public partial class StudentSolvedQuizes : Form
    {
        Student currentStudent;
        public StudentSolvedQuizes(Student student)
        {
            InitializeComponent();
            currentStudent = student;
        }

        private void StudentSolvedQuizes_Load(object sender, EventArgs e)
        {
            using (QuizSystemDbContext context = new QuizSystemDbContext())
            {

                var quizes = from x in context.StudentResults
                             where x.StudentId == currentStudent.Id
                             select x.Quiz.Name;

                var answers = from x in context.StudentResults
                              where x.StudentId == currentStudent.Id
                              select x.CorrectAnswers;

                var mainQuizes = quizes.ToList();
                var mainAnswers = answers.ToList();
                
                for (int i = 0; i < mainQuizes.Count; i++)
                {
                    var thisQuiz = context.Quizes.Where(q => q.Name == mainQuizes[i]).FirstOrDefault();
                    var thisTests = context.Tests.Where(t => t.QuizId == thisQuiz.Id).ToList();
                    int questionNum = thisTests.Count;
                    string quizAndAnswer = $"{i+1}. Quiz - {mainQuizes[i]}," +
                        $"   Result - {mainAnswers[i] * 100 / questionNum  } % ";
                    listBox1.Items.Add(quizAndAnswer);
                }

                //quizName.Text = mainQuizes[0];
                //correctAnswersLbl.Text = mainAnswers[0].ToString();
            }
        }

        private void exitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentForm studentForm = new StudentForm(currentStudent);
            studentForm.ShowDialog();
            this.Close();
        }
    }
}
