using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSistem
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int QuestionCount { get; set; }
        public int View { get; set; }

        public List<Test> Tests { get; set; }

        public List<Student_Quizes> Student_Quizes { get; set; }

        public List<StudentResult> StudentResults { get; set; }
    }
}
