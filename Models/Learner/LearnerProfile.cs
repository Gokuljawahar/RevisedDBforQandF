using System.ComponentModel.DataAnnotations;

namespace LMS
{
    public class LearnerProfile
    {
        [Key]
        public Guid profile_id { get; set; }

        [Required]
        [MaxLength(50)]
        public string first_name { get; set; }

        [Required]
        [MaxLength(50)]
        public string last_name { get; set; }

        [Required]
        public DateOnly dob { get; set; }

        [Required]
        [MaxLength(20)]
        public string gender { get; set; }

        [Required]
        [MaxLength(15)]
        public string contact_number { get; set; }

        [Required]
        [MaxLength(50)]
        public string stream { get; set; }

        public string profile_photo { get; set; }

        //modified
        public Learner learner { get; set; }

        [Required]
        public string created_by { get; set; }

        [Required]
        public DateTime created_at { get; set; }
        public string? modified_by { get; set; }
        public DateTime? modified_at { get; set; }
        //public User User { get; set; }
    }
}
