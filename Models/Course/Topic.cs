using System.ComponentModel.DataAnnotations;

namespace LMS
{
    public class Topic
    {
        [Key]
        public Guid topic_id { get; set; }
        public Course course { get; set; }

        [Required]
        [MaxLength(50)]
        public string name { get; set; }

        [Required]
        [MaxLength(250)]
        public string description { get; set; }

        [Required]
        public bool is_active { get; set; }

        [Required]
        public string created_by { get; set; }

        [Required]
        public DateTime created_at { get; set; }
        public string? modified_by { get; set; }
        public DateTime? modified_at { get; set; }

        public ICollection<Material> Materials { get; set; }

        public ICollection<LearnerProgress> UsersProgress { get; set; }
    }
}
