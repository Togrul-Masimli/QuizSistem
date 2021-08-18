using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSistem
{
    public class Student : SystemUser
    {
        public List<Student_Quizes> Student_Quizes { get; set; }

        public List<StudentResult> StudentResults { get; set; }
    }
}
