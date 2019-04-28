using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFrameWorkTutorial.School
{
    public class School : BaseEntity
    {
        [Key, Column(Order = 1)]
        public int SchoolId { get; set; }

        [Required, MaxLength(100), Column(Order = 2)]
        public string SchoolName { get; set; }

        [Required, MaxLength(255), Column(Order = 3)]
        public string SchoolAddressLineOne { get; set; }

        [MaxLength(255), Column(Order = 4)]
        public string SchoolAddressLineTwo { get; set; }

        [MaxLength(255), Column(Order = 5)]
        public string SchoolAddressLineThree { get; set; }

        [Required, MaxLength(100), Column(Order = 6)]
        public string SchoolAddressCity { get; set; }

        [MaxLength(100), Column(Order = 7)]
        public string SchoolAddressCounty { get; set; }

        [Required, MaxLength(100), Column(Order = 8)]
        public string SchoolAddressCountry { get; set; }

        [Required, MaxLength(10), Column(Order = 9)]
        public string SchoolAddressPostcode { get; set; }
    }
}
