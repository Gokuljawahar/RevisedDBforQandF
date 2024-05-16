using System.ComponentModel.DataAnnotations;

namespace LMS
{
    public class FeedbackResponse
{
        [Key]
    public Guid FeedbackresponseId { get; set; }
    public QuizFeedbackQuestion? QuizFeedbackQuestion { get; set; }
    public TopicFeedbackQuestion? TopicFeedbackQuestion { get; set; }
    public Learner learner { get; set; }
    public string? Response { get; set; }
    public int? OptionId { get; set; }
    public string? GeneratedBy { get; set; }
    public DateTime? GeneratedAt { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime? ModifiedAt { get; set; }
}
}

// using System.ComponentModel.DataAnnotations;

// namespace LMS
// {
//     public class FeedbackResponse
//     {
//         [Key]
//         public Guid FeedbackResponseId { get; set; }
//         public QuizFeedbackQuestion? QuizFeedbackQuestion { get; set; }
//         public TopicFeedbackQuestion? TopicFeedbackQuestion { get; set; }
//         public Learner Learner { get; set; }
//         public string? Response { get; set; }
//         public int? OptionId { get; set; }
//         public string? GeneratedBy { get; set; }
//         public DateTime? GeneratedAt { get; set; }
//         public string? ModifiedBy { get; set; }
//         public DateTime? ModifiedAt { get; set; }
//     }
// }