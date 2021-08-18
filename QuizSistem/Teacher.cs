using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSistem
{
    public class Teacher : SystemUser
    {
        public List<Test> Tests { get; set; }
    }
}
