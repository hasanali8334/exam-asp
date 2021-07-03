using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exam.webapi.Entity
{
    public class Exam
    {
        public int ExamId { get; set; }
        public string examname { get; set; }
        public List<Question> Questions { get; set; }
    }
}
