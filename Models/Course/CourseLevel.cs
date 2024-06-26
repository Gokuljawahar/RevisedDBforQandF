using System.ComponentModel.DataAnnotations;

namespace LMS
{
    public class CourseLevel
    {
        [Key]
        public Guid level_id { get; set; }

        [Required]
        [MaxLength(50)]
        public string level { get; set; }

        [Required]
        public string created_by { get; set; }

        [Required]
        public DateTime created_at { get; set; }
        public string? modified_by { get; set; }
        public DateTime? modified_at { get; set; }

        //One to many
        public ICollection<Course> Courses { get; set; }
    }
}
