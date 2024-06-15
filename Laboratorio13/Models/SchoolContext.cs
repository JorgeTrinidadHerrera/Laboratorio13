using Microsoft.EntityFrameworkCore;

namespace Laboratorio13.Models
{
    public class SchoolContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LAB1504-24\\SQLEXPRESS; User Id=user02 Password=123456;" + "Initial Catalog=School; Integrated Security=True; trustservercertificate=True");
        }
    }
}

  