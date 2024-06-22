using Laboratorio13.Models;
using Laboratorio13.Models.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorio13.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class Grade2Controller : ControllerBase
    {
        private readonly SchoolContext _context;

        public Grade2Controller(SchoolContext context)
        {
            _context = context;
        }

        [HttpPost]
        public void Insert(GradeInsertRequest request)
        {
            //Request=>Model

            Grade grade = new Grade();
            grade.Name = request.Name;
            grade.Description = request.Description;
            grade.Active = true;

            _context.Grades.Add(grade);
            _context.SaveChanges();

        }

        [HttpDelete]

        public async Task<IActionResult> GradeDeleteRequest(int id)
        {
            if (_context.Grades == null)
            {
                return NotFound();
            }
            var grade = await _context.Grades.FindAsync(id);
            if (grade == null)
            {
                return NotFound();
            }

            grade.Active = false;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GradeExists(int id)
        {
            return (_context.Grades?.Any(e => e.GradeID == id)).GetValueOrDefault();
        }
    }
}
