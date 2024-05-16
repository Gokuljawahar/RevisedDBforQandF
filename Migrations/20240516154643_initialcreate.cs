using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstApproachForDB.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "course_category",
                columns: table => new
                {
                    catagory_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    category = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_by = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    modified_by = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    modified_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_course_category", x => x.catagory_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "course_levels",
                columns: table => new
                {
                    level_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    level = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_by = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    modified_by = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    modified_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_course_levels", x => x.level_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "learners",
                columns: table => new
                {
                    learner_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    password = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    role = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    unblock_request = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    account_status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    user_last_login = table.Column<DateTime>(type: "datetime", nullable: false),
                    created_by = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    modified_by = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    modified_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_learners", x => x.learner_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "material_types",
                columns: table => new
                {
                    material_type_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    type = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_material_types", x => x.material_type_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "course",
                columns: table => new
                {
                    course_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    level_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    catagory_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    title = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    duration = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    thumbnail = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    is_active = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    is_available = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    created_by = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    modified_by = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    modified_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_course", x => x.course_id);
                    table.ForeignKey(
                        name: "FK_course_course_category_catagory_id",
                        column: x => x.catagory_id,
                        principalTable: "course_category",
                        principalColumn: "catagory_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_course_course_levels_level_id",
                        column: x => x.level_id,
                        principalTable: "course_levels",
                        principalColumn: "level_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "learner_profiles",
                columns: table => new
                {
                    profile_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    first_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    last_name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    dob = table.Column<DateOnly>(type: "date", nullable: false),
                    gender = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    contact_number = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    stream = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    profile_photo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    learner_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    created_by = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    modified_by = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    modified_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_learner_profiles", x => x.profile_id);
                    table.ForeignKey(
                        name: "FK_learner_profiles_learners_learner_id",
                        column: x => x.learner_id,
                        principalTable: "learners",
                        principalColumn: "learner_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "password_histories",
                columns: table => new
                {
                    password_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    learner_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    old_password = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    new_password = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_by = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    modified_by = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    modified_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_password_histories", x => x.password_id);
                    table.ForeignKey(
                        name: "FK_password_histories_learners_learner_id",
                        column: x => x.learner_id,
                        principalTable: "learners",
                        principalColumn: "learner_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "enrollments",
                columns: table => new
                {
                    enrollment_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    learner_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    course_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    enrollment_date = table.Column<DateTime>(type: "datetime", nullable: false),
                    enroll_status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    enroll_request_status = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    created_by = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    modified_by = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    modified_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enrollments", x => x.enrollment_id);
                    table.ForeignKey(
                        name: "FK_enrollments_course_course_id",
                        column: x => x.course_id,
                        principalTable: "course",
                        principalColumn: "course_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_enrollments_learners_learner_id",
                        column: x => x.learner_id,
                        principalTable: "learners",
                        principalColumn: "learner_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "topic",
                columns: table => new
                {
                    topic_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    course_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    is_active = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    created_by = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    modified_by = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    modified_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_topic", x => x.topic_id);
                    table.ForeignKey(
                        name: "FK_topic_course_course_id",
                        column: x => x.course_id,
                        principalTable: "course",
                        principalColumn: "course_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TopicFeedbackQuestions",
                columns: table => new
                {
                    TopicFeedbackQuestionId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    topic_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    QuestionNo = table.Column<int>(type: "int", nullable: false),
                    Question = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QuestionType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModifiedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopicFeedbackQuestions", x => x.TopicFeedbackQuestionId);
                    table.ForeignKey(
                        name: "FK_TopicFeedbackQuestions_topic_topic_id",
                        column: x => x.topic_id,
                        principalTable: "topic",
                        principalColumn: "topic_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "materials",
                columns: table => new
                {
                    material_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    topic_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    material_type_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    file_path = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    duration = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    is_active = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    is_available = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    created_by = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    modified_by = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    modified_at = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_materials", x => x.material_id);
                    table.ForeignKey(
                        name: "FK_materials_material_types_material_type_id",
                        column: x => x.material_type_id,
                        principalTable: "material_types",
                        principalColumn: "material_type_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_materials_topic_topic_id",
                        column: x => x.topic_id,
                        principalTable: "topic",
                        principalColumn: "topic_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "quizzes",
                columns: table => new
                {
                    quiz_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    course_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    topic_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    name_of_quiz = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    duration = table.Column<int>(type: "int", nullable: false),
                    pass_mark = table.Column<int>(type: "int", nullable: false),
                    AttemptsAllowed = table.Column<int>(type: "int", nullable: true),
                    created_by = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    modified_by = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    modified_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quizzes", x => x.quiz_id);
                    table.ForeignKey(
                        name: "FK_quizzes_course_course_id",
                        column: x => x.course_id,
                        principalTable: "course",
                        principalColumn: "course_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_quizzes_topic_topic_id",
                        column: x => x.topic_id,
                        principalTable: "topic",
                        principalColumn: "topic_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "learner_progress",
                columns: table => new
                {
                    learner_progress_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    course_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    topic_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    material_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    learner_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    watch_time = table.Column<TimeOnly>(type: "time(0)", nullable: false),
                    total_time = table.Column<TimeOnly>(type: "time(0)", nullable: false),
                    is_watched = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_learner_progress", x => x.learner_progress_id);
                    table.ForeignKey(
                        name: "FK_learner_progress_course_course_id",
                        column: x => x.course_id,
                        principalTable: "course",
                        principalColumn: "course_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_learner_progress_learners_learner_id",
                        column: x => x.learner_id,
                        principalTable: "learners",
                        principalColumn: "learner_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_learner_progress_materials_material_id",
                        column: x => x.material_id,
                        principalTable: "materials",
                        principalColumn: "material_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_learner_progress_topic_topic_id",
                        column: x => x.topic_id,
                        principalTable: "topic",
                        principalColumn: "topic_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "QuizFeedbackQuestions",
                columns: table => new
                {
                    QuizFeedbackQuestionId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    quiz_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    QuestionNo = table.Column<int>(type: "int", nullable: false),
                    Question = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QuestionType = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModifiedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuizFeedbackQuestions", x => x.QuizFeedbackQuestionId);
                    table.ForeignKey(
                        name: "FK_QuizFeedbackQuestions_quizzes_quiz_id",
                        column: x => x.quiz_id,
                        principalTable: "quizzes",
                        principalColumn: "quiz_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "learner_attempts",
                columns: table => new
                {
                    learner_attempt_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    learner_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    quiz_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    attempt_count = table.Column<int>(type: "int", nullable: false),
                    start_time = table.Column<DateTime>(type: "datetime", nullable: false),
                    end_time = table.Column<DateTime>(type: "datetime", nullable: false),
                    score = table.Column<float>(type: "float", nullable: false),
                    created_by = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    modified_by = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    modified_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_learner_attempts", x => x.learner_attempt_id);
                    table.ForeignKey(
                        name: "FK_learner_attempts_learners_learner_id",
                        column: x => x.learner_id,
                        principalTable: "learners",
                        principalColumn: "learner_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_learner_attempts_quizzes_quiz_id",
                        column: x => x.quiz_id,
                        principalTable: "quizzes",
                        principalColumn: "quiz_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "quiz_questions",
                columns: table => new
                {
                    quiz_question_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    quiz_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    question_no = table.Column<int>(type: "int", nullable: false),
                    question = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    question_type = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_by = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    modified_by = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    modified_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quiz_questions", x => x.quiz_question_id);
                    table.ForeignKey(
                        name: "FK_quiz_questions_quizzes_quiz_id",
                        column: x => x.quiz_id,
                        principalTable: "quizzes",
                        principalColumn: "quiz_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FeedbackQuestionsOptions",
                columns: table => new
                {
                    FeedbackQuestionOptionId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    QuizFeedbackQuestionId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    TopicFeedbackQuestionId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    OptionText = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModifiedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedbackQuestionsOptions", x => x.FeedbackQuestionOptionId);
                    table.ForeignKey(
                        name: "FK_FeedbackQuestionsOptions_QuizFeedbackQuestions_QuizFeedbackQ~",
                        column: x => x.QuizFeedbackQuestionId,
                        principalTable: "QuizFeedbackQuestions",
                        principalColumn: "QuizFeedbackQuestionId");
                    table.ForeignKey(
                        name: "FK_FeedbackQuestionsOptions_TopicFeedbackQuestions_TopicFeedbac~",
                        column: x => x.TopicFeedbackQuestionId,
                        principalTable: "TopicFeedbackQuestions",
                        principalColumn: "TopicFeedbackQuestionId");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FeedbackResponses",
                columns: table => new
                {
                    FeedbackresponseId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    QuizFeedbackQuestionId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    TopicFeedbackQuestionId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci"),
                    learner_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Response = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    OptionId = table.Column<int>(type: "int", nullable: true),
                    GeneratedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GeneratedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifiedBy = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ModifiedAt = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedbackResponses", x => x.FeedbackresponseId);
                    table.ForeignKey(
                        name: "FK_FeedbackResponses_QuizFeedbackQuestions_QuizFeedbackQuestion~",
                        column: x => x.QuizFeedbackQuestionId,
                        principalTable: "QuizFeedbackQuestions",
                        principalColumn: "QuizFeedbackQuestionId");
                    table.ForeignKey(
                        name: "FK_FeedbackResponses_TopicFeedbackQuestions_TopicFeedbackQuesti~",
                        column: x => x.TopicFeedbackQuestionId,
                        principalTable: "TopicFeedbackQuestions",
                        principalColumn: "TopicFeedbackQuestionId");
                    table.ForeignKey(
                        name: "FK_FeedbackResponses_learners_learner_id",
                        column: x => x.learner_id,
                        principalTable: "learners",
                        principalColumn: "learner_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "question_options",
                columns: table => new
                {
                    question_option_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    quiz_question_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    option = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    is_correct = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    created_by = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    modified_by = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    modified_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_question_options", x => x.question_option_id);
                    table.ForeignKey(
                        name: "FK_question_options_quiz_questions_quiz_question_id",
                        column: x => x.quiz_question_id,
                        principalTable: "quiz_questions",
                        principalColumn: "quiz_question_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "learner_answers",
                columns: table => new
                {
                    learner_answer_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    learner_attempt_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    quiz_question_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    question_option_id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    created_by = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime", nullable: false),
                    modified_by = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    modified_at = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_learner_answers", x => x.learner_answer_id);
                    table.ForeignKey(
                        name: "FK_learner_answers_learner_attempts_learner_attempt_id",
                        column: x => x.learner_attempt_id,
                        principalTable: "learner_attempts",
                        principalColumn: "learner_attempt_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_learner_answers_question_options_question_option_id",
                        column: x => x.question_option_id,
                        principalTable: "question_options",
                        principalColumn: "question_option_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_learner_answers_quiz_questions_quiz_question_id",
                        column: x => x.quiz_question_id,
                        principalTable: "quiz_questions",
                        principalColumn: "quiz_question_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_FeedbackQuestionsOptions_QuizFeedbackQuestionId",
                table: "FeedbackQuestionsOptions",
                column: "QuizFeedbackQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_FeedbackQuestionsOptions_TopicFeedbackQuestionId",
                table: "FeedbackQuestionsOptions",
                column: "TopicFeedbackQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_FeedbackResponses_QuizFeedbackQuestionId",
                table: "FeedbackResponses",
                column: "QuizFeedbackQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_FeedbackResponses_TopicFeedbackQuestionId",
                table: "FeedbackResponses",
                column: "TopicFeedbackQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_FeedbackResponses_learner_id",
                table: "FeedbackResponses",
                column: "learner_id");

            migrationBuilder.CreateIndex(
                name: "IX_QuizFeedbackQuestions_quiz_id",
                table: "QuizFeedbackQuestions",
                column: "quiz_id");

            migrationBuilder.CreateIndex(
                name: "IX_TopicFeedbackQuestions_topic_id",
                table: "TopicFeedbackQuestions",
                column: "topic_id");

            migrationBuilder.CreateIndex(
                name: "IX_course_catagory_id",
                table: "course",
                column: "catagory_id");

            migrationBuilder.CreateIndex(
                name: "IX_course_level_id",
                table: "course",
                column: "level_id");

            migrationBuilder.CreateIndex(
                name: "IX_enrollments_course_id",
                table: "enrollments",
                column: "course_id");

            migrationBuilder.CreateIndex(
                name: "IX_enrollments_learner_id",
                table: "enrollments",
                column: "learner_id");

            migrationBuilder.CreateIndex(
                name: "IX_learner_answers_learner_attempt_id",
                table: "learner_answers",
                column: "learner_attempt_id");

            migrationBuilder.CreateIndex(
                name: "IX_learner_answers_question_option_id",
                table: "learner_answers",
                column: "question_option_id");

            migrationBuilder.CreateIndex(
                name: "IX_learner_answers_quiz_question_id",
                table: "learner_answers",
                column: "quiz_question_id");

            migrationBuilder.CreateIndex(
                name: "IX_learner_attempts_learner_id",
                table: "learner_attempts",
                column: "learner_id");

            migrationBuilder.CreateIndex(
                name: "IX_learner_attempts_quiz_id",
                table: "learner_attempts",
                column: "quiz_id");

            migrationBuilder.CreateIndex(
                name: "IX_learner_profiles_learner_id",
                table: "learner_profiles",
                column: "learner_id");

            migrationBuilder.CreateIndex(
                name: "IX_learner_progress_course_id",
                table: "learner_progress",
                column: "course_id");

            migrationBuilder.CreateIndex(
                name: "IX_learner_progress_learner_id",
                table: "learner_progress",
                column: "learner_id");

            migrationBuilder.CreateIndex(
                name: "IX_learner_progress_material_id",
                table: "learner_progress",
                column: "material_id");

            migrationBuilder.CreateIndex(
                name: "IX_learner_progress_topic_id",
                table: "learner_progress",
                column: "topic_id");

            migrationBuilder.CreateIndex(
                name: "IX_materials_material_type_id",
                table: "materials",
                column: "material_type_id");

            migrationBuilder.CreateIndex(
                name: "IX_materials_topic_id",
                table: "materials",
                column: "topic_id");

            migrationBuilder.CreateIndex(
                name: "IX_password_histories_learner_id",
                table: "password_histories",
                column: "learner_id");

            migrationBuilder.CreateIndex(
                name: "IX_question_options_quiz_question_id",
                table: "question_options",
                column: "quiz_question_id");

            migrationBuilder.CreateIndex(
                name: "IX_quiz_questions_quiz_id",
                table: "quiz_questions",
                column: "quiz_id");

            migrationBuilder.CreateIndex(
                name: "IX_quizzes_course_id",
                table: "quizzes",
                column: "course_id");

            migrationBuilder.CreateIndex(
                name: "IX_quizzes_topic_id",
                table: "quizzes",
                column: "topic_id");

            migrationBuilder.CreateIndex(
                name: "IX_topic_course_id",
                table: "topic",
                column: "course_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeedbackQuestionsOptions");

            migrationBuilder.DropTable(
                name: "FeedbackResponses");

            migrationBuilder.DropTable(
                name: "enrollments");

            migrationBuilder.DropTable(
                name: "learner_answers");

            migrationBuilder.DropTable(
                name: "learner_profiles");

            migrationBuilder.DropTable(
                name: "learner_progress");

            migrationBuilder.DropTable(
                name: "password_histories");

            migrationBuilder.DropTable(
                name: "QuizFeedbackQuestions");

            migrationBuilder.DropTable(
                name: "TopicFeedbackQuestions");

            migrationBuilder.DropTable(
                name: "learner_attempts");

            migrationBuilder.DropTable(
                name: "question_options");

            migrationBuilder.DropTable(
                name: "materials");

            migrationBuilder.DropTable(
                name: "learners");

            migrationBuilder.DropTable(
                name: "quiz_questions");

            migrationBuilder.DropTable(
                name: "material_types");

            migrationBuilder.DropTable(
                name: "quizzes");

            migrationBuilder.DropTable(
                name: "topic");

            migrationBuilder.DropTable(
                name: "course");

            migrationBuilder.DropTable(
                name: "course_category");

            migrationBuilder.DropTable(
                name: "course_levels");
        }
    }
}
