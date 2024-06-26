using CodeFirstApproachForDB.Models.Course;
using LMS;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApproachForDB.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Quiz> quizzes { get; set; }
        public DbSet<QuizQuestion> quiz_questions { get; set; }
        public DbSet<QuestionOption> question_options { get; set; }
        public DbSet<LearnerAttempt> learner_attempts { get; set; }
        public DbSet<LearnerAnswer> learner_answers { get; set; }
        public DbSet<QuizFeedbackQuestion> QuizFeedbackQuestions { get; set; }
        public DbSet<TopicFeedbackQuestion> TopicFeedbackQuestions { get; set; }
        public DbSet<FeedbackQuestionOptions> FeedbackQuestionsOptions { get; set; }
        public DbSet<FeedbackResponse> FeedbackResponses { get; set; }

        //User
        public DbSet<Learner> learners { get; set; }
        public DbSet<LearnerProfile> learner_profiles { get; set; }
        public DbSet<Enrollment> enrollments { get; set; }
        public DbSet<PasswordHistory> password_histories { get; set; }

        public DbSet<Course> course { get; set; }
        public DbSet<CourseCategory> course_category { get; set; }
        public DbSet<CourseLevel> course_levels { get; set; }
        public DbSet<LearnerProgress> learner_progress { get; set; }
        public DbSet<Material> materials { get; set; }
        public DbSet<Topic> topic { get; set; }
        public DbSet<MaterialType> material_types { get; set; }

        public DbSet<CourseFeedbackQuestion> courseFeedbackQuestions { get; set; }
    }
}
