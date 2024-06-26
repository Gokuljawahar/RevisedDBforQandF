using System.ComponentModel.DataAnnotations;

namespace LMS
{
    public class Enrollment
    {
        [Key]
        public Guid enrollment_id { get; set; }

        public Learner learner { get; set; }
        public Course course { get; set; }
        public DateTime enrollment_date { get; set; }
        public bool enroll_status { get; set; }
        public bool enroll_request_status { get; set; }

        [Required]
        public string created_by { get; set; }

        [Required]
        public DateTime created_at { get; set; }
        public string? modified_by { get; set; }
        public DateTime? modified_at { get; set; }
    }
}
