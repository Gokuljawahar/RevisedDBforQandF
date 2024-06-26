using System.ComponentModel.DataAnnotations;

namespace LMS
{
    public class FeedbackQuestionOptions
    {
        [Key]
        public Guid FeedbackQuestionOptionId { get; set; }
        public QuizFeedbackQuestion? QuizFeedbackQuestion { get; set; }
        public TopicFeedbackQuestion? TopicFeedbackQuestion { get; set; }
        public CourseFeedbackQuestion? CourseFeedbackQuestion { get; set; }
        public string OptionText { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
