using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using FindEducators.Models;

namespace FindEducators.Context
{
    public class FindEducatorsContext: DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Chat> Chats  { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<ChatMessage> ChatMessages { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<DegreeType> DegreeTypes { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<FeedbackDetail> FeedbackDetails { get; set; }
        public DbSet<FeedbackType> FeedbackTypes { get; set; }
        public DbSet<Institute> Institutes { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobType> JobTypes { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<LogType> LogTypes { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostDetail> PostDetails { get; set; }
        public DbSet<PostType> PostTypes { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SubjectCategory> SubjectCategories { get; set; }
        public DbSet<SubjectTest> SubjectTests { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<TestLevel> TestLevels { get; set; }
        public DbSet<TestResult> TestResults { get; set; }
        public DbSet<TestType> TestTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAchievement> UserAchievements { get; set; }
        public DbSet<UserEducation> UserEducations { get; set; }
        public DbSet<UserJob> UserJobs { get; set; }
        public DbSet<UserLocation> UserLocations { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }
        public DbSet<UserSkill> UserSkills { get; set; }
        public DbSet<UserSubject> UserSubjects { get; set; }
        public DbSet<UserTest> UserTests { get; set; }
        public DbSet<UserType> UserTypes { get; set; }

    }
}