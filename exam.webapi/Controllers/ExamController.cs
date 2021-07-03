using exam.webapi.Context;
using exam.webapi.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace exam.webapi.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {
        private readonly ExamContext _context;
        public ExamController(ExamContext context)
        {
            _context = context;
        }
        // GET: api/<ExamController>
        [HttpGet]
       // public IEnumerable<string> Get()
        public IEnumerable<Exam> Get()
        {
            List<Exam> exams= _context.Exams.ToList();
            
            return exams;
           
        }

        // GET api/<ExamController>/5
        [HttpGet("{id}")]
        public Exam Get(int id)
        {
          Exam exam = _context.Exams.Find(id);
            
            return exam;
        }

        // POST api/<ExamController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ExamController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ExamController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
