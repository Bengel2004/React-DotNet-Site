using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using TutorialAPI_DotNet.Data;
using TutorialAPI_DotNet.Entities;

namespace TutorialAPI_DotNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public StudentController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {
            var students = await _dataContext.Students.ToListAsync();

            return Ok(students);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetSpecificStudent(int id)
        {
            var student = await _dataContext.Students.FindAsync(id);

            if (student == null) return NotFound();


            return Ok(student);
        }

        [HttpPost]
        public async Task<ActionResult<StudentRequest>> AddStudent(StudentRequest studentDTO)
        {
            // Because required is required, you must set it like so or the constructor wont work.
            var studentToAdd = new Student(studentDTO) { Name = studentDTO.Name };
            _dataContext.Students.Add(studentToAdd);

            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.Students.ToListAsync());
        }

        [HttpPut]
        public async Task<ActionResult<List<Student>>> UpdateStudent(int id, StudentRequest studentDTO)
        {
            // Because required is required, you must set it like so or the constructor wont work.
            var studentToEdit = await _dataContext.Students.FindAsync(id);

            if(studentToEdit == null) return NotFound();

            studentToEdit.Name = studentDTO.Name;
            studentToEdit.firstName = studentDTO.firstName;
            studentToEdit.lastName = studentDTO.lastName;
            studentToEdit.lastGrade = studentDTO.lastGrade;

            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.Students.ToListAsync());
        }

        [HttpDelete]
        public async Task<ActionResult<List<Student>>> DeleteStudent(int id)
        {
            var student = await _dataContext.Students.FindAsync(id);

            if(student == null) return NotFound();

            _dataContext.Students.Remove(student);
            await _dataContext.SaveChangesAsync();

            return Ok(await _dataContext.Students.ToListAsync());
        }
    }
}
