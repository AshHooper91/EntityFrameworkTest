using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameWorkTutorial.School
{
    public class StudentContact : BaseEntity
    {
        [Key, Column(Order = 1)]
        public int StudentContactId { get; set; }

        [Required, MaxLength(100), Column(Order = 2)]
        public string PrimaryContactName { get; set; }

        [Required, DataType(DataType.PhoneNumber), MaxLength(11), Column(Order = 3)]
        public string PrimaryContactTelephoneNumber { get; set; }

        [Required, DataType(DataType.EmailAddress), MaxLength(255), Column(Order = 4)]
        public string PrimaryContactEmailAddresss { get; set; }

        [Required, MaxLength(100), Column(Order = 5)]
        public string SecondaryContactName { get; set; }

        [Required, DataType(DataType.PhoneNumber), MaxLength(11), Column(Order = 6)]
        public string SecondaryContactTelephoneNumber { get; set; }

        [Required, DataType(DataType.EmailAddress), MaxLength(255), Column(Order = 7)]
        public string SecondaryContactEmailAddresss { get; set; }

        [Column(Order = 8)]
        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
