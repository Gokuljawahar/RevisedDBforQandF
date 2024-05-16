using System.ComponentModel.DataAnnotations;

namespace LMS
{
    public class Course
    {
        [Key]
        public Guid course_id { get; set; }
        public CourseLevel Level { get; set; }
        public CourseCatagory Catagory { get; set; }
        [Required]
        [MaxLength(50)]
        public string title { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public decimal duration { get; set; }
        [Required]
        public string thumbnail { get; set; }
        [Required]
        public bool is_active { get; set; }
        [Required]
        public bool is_available { get; set; }
        [Required]
        public string created_by { get; set; }
        [Required]
        public DateTime created_at { get; set; }
        public string? modified_by { get; set; }
        public DateTime? modified_at { get; set; }
        public ICollection<Topic> Topics { get; set; }
        
        public ICollection<LearnerProgress> Userprogress { get; set; }


    }
}
