using System.ComponentModel.DataAnnotations;

namespace PracticaMuchosAMuchos.Models
{
    public class Courses
    {
        [Key]
        public int CourseId { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }

        [StringLength(255)]

        public string Description { get; set; }

        public ICollection<StudentCourses> StudentCourses { get; set; }

    }
}
