using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameWorkTutorial.School
{
    public class StudentCourse : BaseEntity
    {
        [Key, Column(Order = 1)]
        public int StudentCourseId { get; set; }

        [Required, MaxLength(150), Column(Order = 2)]
        public string CourseName { get; set; }

        [Required, Column(Order = 3)]
        public string CourseDescription { get; set; }

        public ICollection<Student> Student { get; set; }
    }
}
