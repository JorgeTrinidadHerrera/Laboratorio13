using Laboratorio13.Models;
using Laboratorio13.Models.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorio13.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly SchoolContext _context;

        public StudentsController(SchoolContext context)
        {
            _context = context;
        }

        [HttpPost]

        public List<Student> ListarEstudiantes(StudentRequest request) { 

            return _context.Students.
                Where(x=>x.FirstName==request.FirstName || x.LastName==request.LastName || x.Email==request.Email)
                .OrderByDescending(x => x.FirstName)
                .ToList();
        }

        public List<Student> ListarEstudiantes2(StudentRequest2 request2)
        {

            return _context.Students.
                Where(x => x.Name == request2.Name || x.GradeID == request2.GradeID)
                .OrderByDescending(x => x.FirstName)
                .ToList();
        }
    }
}
