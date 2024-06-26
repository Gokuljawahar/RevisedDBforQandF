using System.ComponentModel.DataAnnotations;

namespace LMS
{
    public class Quiz
    {
        [Key]
        public Guid quiz_id { get; set; }
        public Course course { get; set; }
        public Topic topic { get; set; }
        public string name_of_quiz { get; set; }
        public int duration { get; set; }
        public int pass_mark { get; set; }
        public int? AttemptsAllowed { get; set; }

        [Required]
        public string? created_by { get; set; }

        [Required]
        public DateTime? created_at { get; set; }
        public string? modified_by { get; set; }
        public DateTime? modified_at { get; set; }
        public ICollection<QuizQuestion> QuizQuestions { get; set; }
        public ICollection<LearnerAttempt> UserAttempts { get; set; }
    }
}
