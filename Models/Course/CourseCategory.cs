using System.ComponentModel.DataAnnotations;

namespace LMS
{
    public class CourseCategory
    {
        [Key]
        public Guid category_id { get; set; }
        [Required]
        [MaxLength(50)]
        public string category { get; set; }
        [Required]
        public string created_by { get; set; }
        [Required]
        public DateTime created_at { get; set; }
        public string? modified_by { get; set; }
        public DateTime? modified_at { get; set; }

        // One to many
        public ICollection<Course> Course { get; set; }
    }
}
