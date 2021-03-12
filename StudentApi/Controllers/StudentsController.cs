using System.Linq;
using Microsoft.AspNetCore.Mvc;

[Route("students")]
[ApiController]
public class StudentsController : ControllerBase
{
    [HttpGet]
    [Route("all")]
    public ActionResult GetAllStudents()
    {
        var students = new string[] { "Dipesh", "Rajesh" };

        //students = null;
        if (students == null)
        {
            return NotFound();
        }
        return Ok(students);
    }

    [HttpGet]
    [Route("{name}")]
    public ActionResult GetStudentById(string name)
    {
        var students = new string[] { "Dipesh", "Rajesh" };
        var student = students.Where(x => x == name).FirstOrDefault();
        //student = null;
        if (student == null)
        {
            return NotFound();
        }
        return Ok(students);
    }

    [HttpPost]
    [Route("add")]
    public ActionResult CreateStudent(Student student)
    {
        if (student == null)
        {
            return BadRequest();
        }
        //Add student to db

        return Created("", student);
    }

    [HttpPut]
    [Route("update/{id}")]
    public ActionResult UpdateStudent(Student student, int id)
    {
        if (student == null)
        {
            return BadRequest();
        }
        //Add student to db

        return Ok(student);
    }

    [HttpDelete]
    [Route("delete/{id}")]
    public ActionResult DeleteStudent(){
        // delete student from db
        return NoContent();
    }


}