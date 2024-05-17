using CodeFirstApproachForDB.Models.Course;
using LMS;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstApproachForDB.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

       
         public DbSet<Quiz> quizzes { get; set; }
        public DbSet<QuizQuestion> quiz_questions { get; set; }
        public DbSet<QuestionOption> question_options { get; set; }
        public DbSet<LearnerAttempt> learner_attempts { get; set; }
        public DbSet<LearnerAnswer> learner_answers { get; set; }
         public DbSet<QuizFeedbackQuestion> QuizFeedbackQuestions { get; set; }
        public DbSet<TopicFeedbackQuestion> TopicFeedbackQuestions { get; set; }
        public DbSet<FeedbackQuestionOptions> FeedbackQuestionsOptions{ get; set; }
        public DbSet<FeedbackResponse> FeedbackResponses{ get; set; }


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
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    //Quiz
        //    modelBuilder.Entity<QuizQuestion>()
        //        .HasOne(qq => qq.Quiz)
        //        .WithMany(q => q.QuizQuestions)
        //        .HasForeignKey(qq => qq.QuizId);

        //    modelBuilder.Entity<QuestionOption>()
        //        .HasOne(qo => qo.QuizQuestion)
        //        .WithMany(qq => qq.QuestionOptions)
        //        .HasForeignKey(qo => qo.QuizQuestionId);

        //    modelBuilder.Entity<UserAttempt>()
        //        .HasOne(ua => ua.Quiz)
        //        .WithMany(q => q.UserAttempts)
        //        .HasForeignKey(ua => ua.QuizId);

        //    modelBuilder.Entity<UserAnswer>()
        //        .HasOne(ua => ua.UserAttempt)
        //        .WithMany(ua => ua.UserAnswers)
        //        .HasForeignKey(ua => ua.UserAttemptId);

        //    modelBuilder.Entity<UserAnswer>()
        //        .HasOne(ua => ua.QuizQuestion)
        //        .WithMany(qq => qq.UserAnswers)
        //        .HasForeignKey(ua => ua.QuizQuestionId);

        //    modelBuilder.Entity<UserAnswer>()
        //        .HasOne(ua => ua.QuestionOption)
        //        .WithMany(qo => qo.UserAnswers)
        //        .HasForeignKey(ua => ua.QuestionOptionId);

        //    modelBuilder.Entity<FeedbackResponse>()
        //        .HasOne(fr => fr.FeedbackQuestion)
        //        .WithMany(fq => fq.FeedbackResponses)
        //        .HasForeignKey(fr => fr.FeedbackQuestionId);

        //    //User

        //    modelBuilder.Entity<Profile>()
        //       .HasOne(p => p.User)
        //       .WithOne(u => u.Profile)
        //       .HasForeignKey<Profile>(p => p.UserID);

        //    modelBuilder.Entity<Enrollment>()
        //        .HasOne(e => e.User)
        //        .WithOne(u => u.Enrollment)
        //        .HasForeignKey<Enrollment>(e => e.UserID);

        //    modelBuilder.Entity<PasswordHistory>()
        //        .HasOne(ph => ph.User)
        //        .WithOne(u => u.PasswordHistory)
        //        .HasForeignKey<PasswordHistory>(ph => ph.UserID);

           
        //}
    }
}
