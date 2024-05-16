using System.ComponentModel.DataAnnotations;

namespace LMS
{
    public class TopicFeedbackQuestion
{
        [Key]
    public Guid TopicFeedbackQuestionId { get; set; }
    public Topic Topic { get; set; }
    public int QuestionNo { get; set; }
    public string Question { get; set; }
    public string QuestionType { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? CreatedAt { get; set; }
    public string? ModifiedBy { get; set; }
    public DateTime? ModifiedAt { get; set; }
}
}

// using System.ComponentModel.DataAnnotations;

// namespace LMS
// {
//     public class TopicFeedbackQuestion
//     {
//         [Key]
//         public Guid TopicFeedbackQuestionId { get; set; }
//         public Topic Topic { get; set; }
//         public int QuestionNo { get; set; }
//         public string Question { get; set; }
//         public string QuestionType { get; set; }
//         public string? CreatedBy { get; set; }
//         public DateTime? CreatedAt { get; set; }
//         public string? ModifiedBy { get; set; }
//         public DateTime? ModifiedAt { get; set; }
//     }
// }