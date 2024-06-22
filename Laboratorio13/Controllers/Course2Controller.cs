using Laboratorio13.Models;
using Laboratorio13.Models.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorio13.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Course2Controller : ControllerBase
    {
        private readonly SchoolContext _context;

        public Course2Controller(SchoolContext context)
        {
            _context = context;
        }

        [HttpPost]
        public void Insert(CourseInsertRequest request)
        {
            //Request=>Model

            Course course = new Course();
            course.Name = request.Name;
            course.Credit = request.Credit;
            course.Active = true;

            _context.Courses.Add(course);
            _context.SaveChanges();

        }

        [HttpDelete]
       
            public async Task<IActionResult> CourseDeleteRequest(int id)
            {
                if (_context.Courses == null)
                {
                    return NotFound();
                }
                var course = await _context.Courses.FindAsync(id);
                if (course == null)
                {
                    return NotFound();
                }

                course.Active = false;
                await _context.SaveChangesAsync();

                return NoContent();
            }

            private bool CourseExists(int id)
            {
                return (_context.Courses?.Any(e => e.CourseId == id)).GetValueOrDefault();
            }

    }
}
