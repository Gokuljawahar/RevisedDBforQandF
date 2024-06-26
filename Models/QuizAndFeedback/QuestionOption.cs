using System.ComponentModel.DataAnnotations;

namespace LMS
{
    public class QuestionOption
    {
        [Key]
        public Guid question_option_id { get; set; }
        public QuizQuestion quiz_question { get; set; }
        public string option { get; set; }
        public bool is_correct { get; set; }

        [Required]
        public string? created_by { get; set; }

        [Required]
        public DateTime? created_at { get; set; }
        public string? modified_by { get; set; }
        public DateTime? modified_at { get; set; }
        public ICollection<LearnerAnswer> UserAnswers { get; set; }
    }
}
