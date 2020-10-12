using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using MassTransit.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using School.IServices;
using School.Models;
using School.Repositry;

namespace School.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public IStudenService StudenService { get; set; }

        public StudentController(IStudenService studenService )
        {
            StudenService = studenService;
        }
        // GET: api/Student
        [HttpGet("Get")]
        public IActionResult Get(int id)
        {
            Student student = StudenService.Get(id);
            if (student != null)
            {
                return Ok(student);
            }
            else
            {
                return StatusCode(400);
            }
        }

        // GET: api/Student/5
        [HttpGet("GetAll")]
        //[Route("test")]
        public IActionResult GetAll()
        {
            List<Student> students = StudenService.GetAll();
            if (students != null)
            {
                return Ok(students);
            }
            return StatusCode(400);
        }

        // POST: api/Student
        [HttpPost]
        public IActionResult Post([FromBody] Student value)
        {
            StudenService.Post(value);

            return StatusCode(201);
        }

        // PUT: api/Student/5
        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            StudenService.Put(id);
            return StatusCode(201);
        }

        // DELETE: api/ApiWithActions/5

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            StudenService.Delete(id);
            return StatusCode(201);
        }

    }
}
