using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameWorkTutorial.School
{
    public class SchoolTeacherAddress : BaseEntity
    {
        [Key, Column(Order = 1)]
        public int SchoolTeacherAddressId { get; set; }

        [Required, MaxLength(255), Column(Order = 2)]
        public string AddressLineOne { get; set; }

        [MaxLength(255), Column(Order = 3)]
        public string AddressLineTwo { get; set; }

        [MaxLength(255), Column(Order = 4)]
        public string AddressLineThree { get; set; }

        [Required, MaxLength(100), Column(Order = 5)]
        public string City { get; set; }

        [Required, MaxLength(100), Column(Order = 6)]
        public string County { get; set; }

        [Required, MaxLength(10), Column(Order = 7)]
        public string Postcode { get; set; }

        [Column(Order = 8)]
        public int SchoolTeacherId { get; set; }
        public SchoolTeacher SchoolTeacher { get; set; }
    }
}
