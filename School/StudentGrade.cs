using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameWorkTutorial.School
{
    public class StudentGrade : BaseEntity
    {
        [Key, Column(Order = 1)]
        public int StudentGradeId { get; set; }

        [Required, MaxLength(150), Column(Order = 2)]
        public string GradeName { get; set; }

        [Column(Order = 3)]
        public ICollection<Student> Student { get; set; }
    }
}
