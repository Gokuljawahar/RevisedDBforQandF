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
