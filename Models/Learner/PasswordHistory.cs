using System.ComponentModel.DataAnnotations;

namespace LMS
{
    public class PasswordHistory
    {
        [Key]
        public Guid password_id { get; set; }
        public Learner learner { get; set; }

        [MaxLength(30)]
        public string old_password { get; set; }

        [MaxLength(30)]
        public string new_password { get; set; }

        [Required]
        public string created_by { get; set; }

        [Required]
        public DateTime created_at { get; set; }
        public string? modified_by { get; set; }
        public DateTime? modified_at { get; set; }
        //public Guid UserID { get; set; }
    }
}
