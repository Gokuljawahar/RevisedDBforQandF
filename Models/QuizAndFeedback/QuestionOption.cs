using System.ComponentModel.DataAnnotations;

namespace LMS
{
    public class QuestionOption
    {
        [Key]
        public Guid question_option_id { get; set; }
        public QuizQuestion quiz_question { get; set; }
        //public Guid QuizQuestionId { get; set; }
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
// using System.ComponentModel.DataAnnotations;

// namespace LMS
// {
//     public class QuestionOption
//     {
//         [Key]
//         public Guid QuestionOptionId { get; set; }
//         public QuizQuestion QuizQuestion { get; set; }
//         public string Option { get; set; }
//         public bool IsCorrect { get; set; }
//         [Required]
//         public string? CreatedBy { get; set; }
//         [Required]
//         public DateTime? CreatedAt { get; set; }
//         public string? ModifiedBy { get; set; }
//         public DateTime? ModifiedAt { get; set; }
//         public ICollection<LearnerAnswer> UserAnswers { get; set; }
//     }
// }