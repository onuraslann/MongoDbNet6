using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDbNet6.Models;
using MongoDbNet6.Services;

namespace MongoDbNet6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public ActionResult<List<Student>> GetStudent()
        {
            var model = _studentService.Get();
            return model;
        }
        [HttpGet("{id}")]
        public ActionResult<Student> GetByIdStudent(string id)
        {
            var model = _studentService.GetById(id);
            if(model == null)
            {
                return NotFound();
            }
            return model;

        }
        [HttpPost]
        public ActionResult CreateStudent([FromBody] Student student)
        {
            var model = _studentService.Create(student);

            return Ok(model);



        }
        [HttpDelete]
        public ActionResult DeleteStudent(string id)
        {
            var model = _studentService.GetById(id);
            if (model == null)
            {
                return NotFound();
            }
            _studentService.Remove(model.Id);
            return Ok();
        }

        [HttpPut]
        public ActionResult UpdateStudent(string id, [FromBody] Student student)
        {
            var model = _studentService.GetById(id);
            if (model == null)
            {
                return NotFound();
            }
            _studentService.Update(id,model);
            return Ok();
        }
    }
}
