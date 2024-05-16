using System.ComponentModel.DataAnnotations;

namespace LMS
{
    public class LearnerAnswer
    {
        [Key]
        public Guid learner_answer_id { get; set; }
        public LearnerAttempt learner_attempt { get; set; }
        public QuizQuestion quiz_question { get; set; }
        public QuestionOption question_option { get; set; }
        [Required]
        public string? created_by { get; set; }
        [Required]
        public DateTime? created_at { get; set; }
        public string? modified_by { get; set; }
        public DateTime? modified_at { get; set; }
        
    }
}
// using System.ComponentModel.DataAnnotations;

// namespace LMS
// {
//     public class LearnerAnswer
//     {
//         [Key]
//         public Guid LearnerAnswerId { get; set; }
//         public LearnerAttempt LearnerAttempt { get; set; }
//         public QuizQuestion QuizQuestion { get; set; }
//         public QuestionOption QuestionOption { get; set; }
//         [Required]
//         public string? CreatedBy { get; set; }
//         [Required]
//         public DateTime? CreatedAt { get; set; }
//         public string? ModifiedBy { get; set; }
//         public DateTime? ModifiedAt { get; set; }
//     }
// }