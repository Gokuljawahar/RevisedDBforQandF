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
        //public Quiz Quiz { get; set; }
        public ICollection<QuestionOption> QuestionOptions { get; set; }
        public ICollection<LearnerAnswer> UserAnswers { get; set; }
    }
}

// using System.ComponentModel.DataAnnotations;

// namespace LMS
// {
//     public class QuizQuestion
//     {
//         [Key]
//         public Guid QuizQuestionId { get; set; }
//         public Quiz Quiz { get; set; }
//         public int QuestionNo { get; set; }
//         public string Question { get; set; }
//         [MaxLength(30)]
//         public string QuestionType { get; set; }
//         [Required]
//         public string? CreatedBy { get; set; }
//         [Required]
//         public DateTime? CreatedAt { get; set; }
//         public string? ModifiedBy { get; set; }
//         public DateTime? ModifiedAt { get; set; }
//         public ICollection<QuestionOption> QuestionOptions { get; set; }
//         public ICollection<LearnerAnswer> UserAnswers { get; set; }
//     }
// }