using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameWorkTutorial.School
{
    public class Student : BaseEntity
    {
        [Key, Column(Order = 1)]
        public int StudentId { get; set; }

        [Required, MaxLength(100), Column(Order = 2)]
        public string StudentName { get; set; }

        [DataType(DataType.DateTime), Column(Order = 3)]
        public DateTime? DateOfBirth { get; set; }

        [Column(Order = 4)]
        public byte[] Photo { get; set; }

        [Column(Order = 6)]
        public School School { get; set; }

        [Column(Order = 7)]
        public StudentAddress Address { get; set; }

        [Column(Order = 8)]
        public StudentContact Contact { get; set; }

        [Column(Order = 9)]
        public int GradeId { get; set; }
        public StudentGrade Grade { get; set; }

        [Column(Order = 10)]
        public int CourseId { get; set; }
        public StudentCourse Course { get; set; }
    }
}
