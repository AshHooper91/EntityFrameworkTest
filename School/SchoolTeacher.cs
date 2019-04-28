using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFrameWorkTutorial.School
{
    public class SchoolTeacher : BaseEntity
    {
        [Key, Column(Order = 1)]
        public int SchoolTeacherId { get; set; }

        [Required, MaxLength(100), Column(Order = 2)]
        public string Name { get; set; }

        [Required, MaxLength(100), Column(Order = 3)]
        public string JobTitle { get; set; }

        [ForeignKey("SchoolTeacherAddress"), Column(Order = 4)]
        public int SchoolTeacherAddressId { get; set; }
        public SchoolTeacherAddress SchoolTeacherAddress { get; set; }

        [ForeignKey("SchoolTeacherContact"), Column(Order = 5)]
        public int SchoolTeacherContactId { get; set; }
        public SchoolTeacherContact SchoolTeacherContact { get; set; }
    }
}
