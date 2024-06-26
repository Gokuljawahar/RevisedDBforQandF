using System.ComponentModel.DataAnnotations;

namespace LMS
{
    public class LearnerAttempt
    {
        [Key]
        public Guid learner_attempt_id { get; set; }

        //User id navigated
        public Learner learner { get; set; }
        public Quiz quiz { get; set; }
        public int attempt_count { get; set; }
        public DateTime start_time { get; set; }
        public DateTime end_time { get; set; }
        public float score { get; set; }

        [Required]
        public string? created_by { get; set; }

        [Required]
        public DateTime? created_at { get; set; }
        public string? modified_by { get; set; }
        public DateTime? modified_at { get; set; }
        public ICollection<LearnerAnswer> UserAnswers { get; set; }
    }
}
