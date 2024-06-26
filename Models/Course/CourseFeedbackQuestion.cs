using System.ComponentModel.DataAnnotations;

namespace LMS
{
    public class CourseFeedbackQuestion
    {
        [Key]
        public Guid CourseFeedbackQuestionId { get; set; }
        public Course course { get; set; }
        public int QuestionNo { get; set; }
        public string Question { get; set; }
        public string QuestionType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
