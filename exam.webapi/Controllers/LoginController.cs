using exam.webapi.Context;
using exam.webapi.Entity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
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
       
        public async Task<IActionResult> Login(User u)
        {
            var bilgiler = _context.Users.FirstOrDefault(x => x.mail == u.mail && x.password == u.password);
            if (bilgiler!=null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email,u.mail)
                };
                var useridentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Home");

            }

            return View();
        }
        public IActionResult register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult register(string mail,string password)
        {
            User us = new User() { mail = mail, password = password };

            _context.Users.Add(us);
            _context.SaveChanges();
            
           
            return View();
        }
    }
}
