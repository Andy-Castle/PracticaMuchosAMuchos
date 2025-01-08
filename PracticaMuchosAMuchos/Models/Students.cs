using System.ComponentModel.DataAnnotations;

namespace PracticaMuchosAMuchos.Models
{
    public class Students
    {
        [Key]
        public int StudentId { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }


        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public ICollection<StudentCourses> StudentCourses { get; set; }
    }
}
