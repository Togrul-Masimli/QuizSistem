﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSistem
{
    public class Student_Quizes
    {
        public int Id { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }


    }
}
