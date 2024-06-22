using Laboratorio13.Models.Request;
using Laboratorio13.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Laboratorio13.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Student2Controller : ControllerBase
    {
        private readonly SchoolContext _context;

        public Student2Controller(SchoolContext context)
        {
            _context = context;
        }

        [HttpPost]
        public void Insert(StudentInsertRequest request)
        {
            //Request=>Model

            Student student = new Student();
            student.FirstName = request.FirstName;
            student.LastName = request.LastName;
            student.Email = request.Email;
            student.Phone = request.Phone;
            student.GradeID = request.GradeID;
            student.Activo = true;

            _context.Students.Add(student);
            _context.SaveChanges();

        }

        /*
        [HttpPost]

        public void UpdateContact(StudentInserRequest request)
        {
            var student = _context.Students.FirstOrDefault(s => s.StudentId == request.StudentId);
            if (student != null)
            {
                BadRequest("Student not found");

            }
            else
            {
                student.Phone = request.Phone;
                student.Email = request.Email;
                _context.SaveChanges();
            }
        }
        public void UpdatePersonal(UpdatePersonalDataRequest request)
        {
            var student = _context.Students.FirstOrDefault(s => s.StudentId == request.StudentId);
            if (student != null)
            {
                BadRequest("Student not found");

            }
            else
            {
                student.FirstName = request.FirstName;
                student.LastName = request.LastName;
                _context.SaveChanges();
            }
        }
        */

    }
}
