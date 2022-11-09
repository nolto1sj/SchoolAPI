﻿using Microsoft.AspNetCore.Mvc;
using School.Data.TableModels;
using School.Services.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace School.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _service;

        public StudentsController(IStudentService service)
        {
            _service = service;
        }


        // GET: api/<StudentsController>
        [HttpGet]
        public ActionResult Get()
        {
            var students = _service.GetStudents();
            return Ok(students);
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var student = _service.GetStudent(id);
            if (student == null) return NotFound("There is no student with an id of " + id);
            return Ok(student);
        }

        // POST api/<StudentsController>
        [HttpPost]
        public ActionResult Post(string name)
        {
            return Ok(_service.CreateStudent(name));
        }

        // POST api/Students/random
        [HttpPost("random")]
        public async Task<ActionResult> Post()
        {
            var student = await _service.CreateRandomStudent();
            if (student == null)
            {
                return StatusCode(500);
            }
            return Ok(student);
        }

        //// PUT api/<StudentsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<StudentsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
