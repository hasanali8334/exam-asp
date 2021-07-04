using exam.webapi.Context;
using exam.webapi.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exam.webapi.Controllers
{

    public class HomeController : Controller
    {
        private readonly ExamContext _context;
        
        public HomeController(ExamContext context)
        {
            _context = context;

        }
        [Authorize]
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(string examname,string qtext,string opt1, string opt2,string opt3 ,string opt4,string opt5 , string copt)
        {
            string[] qtexta = qtext.Split(',');
            string[] op1a = opt1.Split(',');
            string[] op2a = opt2.Split(',');
            string[] op3a = opt3.Split(',');
            string[] op4a = opt4.Split(',');
            string[] op5a = opt5.Split(',');
            string[] copta = copt.Split(',');
            Exam exam = new Exam();
            exam.examname = examname;
            

            for (int i = 0; i < qtexta.Length; i++)
            {
                Question q = new Question();
                q.qtext = qtexta[i].ToString();
                q.opt1 = op1a[i].ToString();
                q.opt2 = op2a[i].ToString();
                q.opt3 = op3a[i].ToString();
                q.opt4 = op4a[i].ToString();
                q.opt5 = op5a[i].ToString();
                q.copt = copta[i].ToString();
                exam.Questions.Add(q);
            }

            _context.Exams.Add(exam);
            _context.SaveChanges();


            return View();
        }

    }
}
