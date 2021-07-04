using exam.webapi.Context;
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
        
    }
}
