using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exam.webapi.Entity
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string qtext { get; set; }
        public string opt1 { get; set; }
        public string opt2 { get; set; }
        public string opt3 { get; set; }
        public string opt4 { get; set; }
        public string opt5 { get; set; }
        public string copt { get; set; }

    }
}
