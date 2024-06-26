using System.ComponentModel.DataAnnotations;

namespace LMS
{
    public class LearnerProgress
    {
        [Key]
        public Guid learner_progress_id { get; set; }
        public Course course { get; set; }

        public Topic topic { get; set; }

        public Material material { get; set; }
        public Learner learner { get; set; }

        [Required]
        public TimeOnly watch_time { get; set; }

        [Required]
        public TimeOnly total_time { get; set; }

        [Required]
        public bool is_watched { get; set; }
    }
}
