using System.ComponentModel.DataAnnotations.Schema;

namespace PracticaMuchosAMuchos.Models
{
    public class StudentCourses
    {
        [ForeignKey("Students")]
        public int StudentId { get; set; }


        [ForeignKey("Courses")]
        public int CourseId { get; set; }

    }
}
