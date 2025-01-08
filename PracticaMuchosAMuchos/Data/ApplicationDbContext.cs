using Microsoft.EntityFrameworkCore;
using PracticaMuchosAMuchos.Models;

namespace PracticaMuchosAMuchos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }

        DbSet<Students> Students { get; set; }

        DbSet<Courses> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourses>().HasKey(studentCourses => new { studentCourses.StudentId, studentCourses.CourseId});
        }
    }
}
