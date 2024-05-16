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
        public int? AttemptsAllowed {get;set;}
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


// using System.ComponentModel.DataAnnotations;

// namespace LMS
// {
//     public class Quiz
//     {
//         [Key]
//         public Guid QuizId { get; set; }
//         public Course Course { get; set; }
//         public Topic Topic { get; set; }
//         public string NameOfQuiz { get; set; }
//         public int Duration { get; set; }
//         public int PassMark { get; set; }
//         public int? AttemptsAllowed { get; set; }
//         [Required]
//         public string? CreatedBy { get; set; }
//         [Required]
//         public DateTime? CreatedAt { get; set; }
//         public string? ModifiedBy { get; set; }
//         public DateTime? ModifiedAt { get; set; }
//         public ICollection<QuizQuestion> QuizQuestions { get; set; }
//         public ICollection<LearnerAttempt> UserAttempts { get; set; }
//     }
// }