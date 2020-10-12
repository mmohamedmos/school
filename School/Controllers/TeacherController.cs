//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using School.Models;
//using School.Repositry;

//namespace School.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class TeacherController : ControllerBase
//    {
//        public ISchoolRepositry<Teacher> SchoolRepositry { get; }

//        public TeacherController(ISchoolRepositry<Teacher> schoolRepositry)
//        {
//            SchoolRepositry = schoolRepositry;
//        }
//        // GET: api/Student
//        [HttpGet("Get")]
//        public IActionResult Get(int id)
//        {
//            Teacher teacher = SchoolRepositry.get(id);
//            return Ok(teacher);
//        }

//        // GET: api/Student/5
//        [HttpGet("GetAll")]
//        public IActionResult GetAll()
//        {
//            List<Teacher> teachers = SchoolRepositry.getAll();
//            return Ok(teachers);
//        }

//        // POST: api/Student
//        [HttpPost]
//        public IActionResult Post([FromBody] Teacher value)
//        {
//            SchoolRepositry.Add(value);
//            return StatusCode(201);
//        }

//        // PUT: api/Student/5
//        [HttpPut("{id}")]
//        public IActionResult Put(int id, [FromBody] Teacher value)
//        {
//            SchoolRepositry.update(id, value);
//            return StatusCode(201);
//        }

//        // DELETE: api/ApiWithActions/5
//        [HttpDelete("{id}")]
//        public IActionResult Delete(int id)
//        {
//            SchoolRepositry.delete(id);
//            return StatusCode(201);
//        }
//    }
//}
