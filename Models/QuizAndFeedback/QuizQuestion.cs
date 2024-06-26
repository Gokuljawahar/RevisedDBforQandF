using System.ComponentModel.DataAnnotations;

namespace LMS
{
    public class QuizQuestion
    {
        [Key]
        public Guid quiz_question_id { get; set; }
        public Quiz quiz { get; set; }
        public int question_no { get; set; }
        public string question { get; set; }

        [MaxLength(30)]
        public string question_type { get; set; }

        [Required]
        public string? created_by { get; set; }

        [Required]
        public DateTime? created_at { get; set; }
        public string? modified_by { get; set; }
        public DateTime? modified_at { get; set; }
        public ICollection<QuestionOption> QuestionOptions { get; set; }
        public ICollection<LearnerAnswer> UserAnswers { get; set; }
    }
}
