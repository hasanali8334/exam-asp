using exam.webapi.Context;
using exam.webapi.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace exam.webapi.Controllers
{
    
    public class LoginController : Controller
    {
        private readonly ExamContext _context;

        public LoginController(ExamContext context)
        {
            _context = context;
        }
       
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult register(User us)
        {
            _context.Users.Add(us);
            _context.SaveChanges();
            
           
            return View();
        }
    }
}
