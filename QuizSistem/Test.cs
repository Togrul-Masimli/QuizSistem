using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSistem
{
    public class Test
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public string CorrectAnswer { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }
    }
}
