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
        //public Quiz Quiz { get; set; }
        public ICollection<LearnerAnswer> UserAnswers { get; set; }
    }
}

// using System.ComponentModel.DataAnnotations;

// namespace LMS
// {
//     public class LearnerAttempt
//     {
//         [Key]
//         public Guid LearnerAttemptId { get; set; }
//         public Learner Learner { get; set; }
//         public Quiz Quiz { get; set; }
//         public int AttemptCount { get; set; }
//         public DateTime StartTime { get; set; }
//         public DateTime EndTime { get; set; }
//         public float Score { get; set; }
//         [Required]
//         public string? CreatedBy { get; set; }
//         [Required]
//         public DateTime? CreatedAt { get; set; }
//         public string? ModifiedBy { get; set; }
//         public DateTime? ModifiedAt { get; set; }
//         public ICollection<LearnerAnswer> UserAnswers { get; set; }
//     }
// }