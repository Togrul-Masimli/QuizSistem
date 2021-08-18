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
    public partial class SelectQuizForm : Form
    {
        private int count = 0;
        Quiz selectedQuiz;
        Student currentStudent;
        public SelectQuizForm(Student student)
        {
            InitializeComponent();
            currentStudent = student;
        }

        private void SelectQuizForm_Load(object sender, EventArgs e)
        {

            using (QuizSystemDbContext context = new QuizSystemDbContext())
            {
                var quizes1 = from s in context.Quizes
                             select s;
                var quizes = quizes1.ToList();

                for (int i = 0; i < quizes.Count; i++)
                {
                    if (quizes[i].Name!=null)
                    {
                        selectQuiz.Items.Add(quizes[i].Name);
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectQuiz.SelectedIndex > -1)
            {

                using (QuizSystemDbContext context = new QuizSystemDbContext())
                {
                    var quizFromCombo = selectQuiz.SelectedItem.ToString();

                    selectedQuiz = context.Quizes.Where(x => x.Name == quizFromCombo).FirstOrDefault();
                }

                this.Hide();
                SolveTestForm solveTest = new SolveTestForm(selectedQuiz, currentStudent);
                solveTest.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a quiz");
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
