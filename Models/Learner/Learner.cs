using System.ComponentModel.DataAnnotations;

namespace LMS
{
    public class Learner
    {
        [Key]
        public Guid learner_id { get; set; }

        [Required]
        [MaxLength(50)]
        public string email { get; set; }

        [Required]
        [MaxLength(30)]
        public string password { get; set; }

        [MaxLength(10)]
        public string role { get; set; }
        public bool unblock_request { get; set; }
        public bool account_status { get; set; }
        public DateTime user_last_login { get; set; }

        [Required]
        public string created_by { get; set; }

        [Required]
        public DateTime created_at { get; set; }
        public string? modified_by { get; set; }
        public DateTime? modified_at { get; set; }
    }
}
