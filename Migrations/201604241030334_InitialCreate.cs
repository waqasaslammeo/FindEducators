namespace FindEducators.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        UserName = c.String(),
                        Password = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        DOB = c.DateTime(nullable: false),
                        CNIC = c.String(),
                        EmailAddress = c.String(),
                        PhoneNo1 = c.String(),
                        PhoneNo2 = c.String(),
                        Address = c.String(),
                        UserTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.UserTypes", t => t.UserTypeId, cascadeDelete: true)
                .Index(t => t.UserTypeId);
            
            CreateTable(
                "dbo.UserTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Areas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CityId = c.Int(nullable: false),
                        AreaName = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ChatMessages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SenderId = c.Int(nullable: false),
                        RecieverId = c.Int(nullable: false),
                        Message = c.String(),
                        PostedDate = c.DateTime(nullable: false),
                        PostedTime = c.String(),
                        ChatId = c.Int(nullable: false),
                        Users1_Id = c.Int(),
                        Users2_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Chats", t => t.ChatId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .ForeignKey("dbo.Users", t => t.Users2_Id)
                .Index(t => t.ChatId)
                .Index(t => t.Users1_Id)
                .Index(t => t.Users2_Id);
            
            CreateTable(
                "dbo.Chats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreateBy = c.Int(nullable: false),
                        Users_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .Index(t => t.Users_Id);
            
            CreateTable(
                "dbo.Degrees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DegreeName = c.String(),
                        DegreeTypeId = c.Int(nullable: false),
                        DegreeAbbrivation = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DegreeTypes", t => t.DegreeTypeId, cascadeDelete: true)
                .Index(t => t.DegreeTypeId);
            
            CreateTable(
                "dbo.DegreeTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DegreeTypeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FeedbackDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FeedbackId = c.Int(nullable: false),
                        Punctual = c.Int(nullable: false),
                        Behavior = c.Int(nullable: false),
                        Personality = c.Int(nullable: false),
                        Knowledge = c.Int(nullable: false),
                        Overall = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Feedbacks", t => t.FeedbackId, cascadeDelete: true)
                .Index(t => t.FeedbackId);
            
            CreateTable(
                "dbo.Feedbacks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PostedById = c.Int(nullable: false),
                        PostedToId = c.Int(nullable: false),
                        Message = c.String(),
                        PostedDate = c.DateTime(nullable: false),
                        FeedbackTypeId = c.Int(nullable: false),
                        Users1_Id = c.Int(),
                        Users2_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.FeedbackTypes", t => t.FeedbackTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.Users1_Id)
                .ForeignKey("dbo.Users", t => t.Users2_Id)
                .Index(t => t.FeedbackTypeId)
                .Index(t => t.Users1_Id)
                .Index(t => t.Users2_Id);
            
            CreateTable(
                "dbo.FeedbackTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FeedbackTypeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Institutes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        InstituteName = c.String(),
                        CityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobTitle = c.String(),
                        PostedBy = c.Int(nullable: false),
                        PostedDate = c.DateTime(nullable: false),
                        ExpiryDate = c.DateTime(nullable: false),
                        JobTypeId = c.Int(nullable: false),
                        Experience = c.String(),
                        Location = c.String(),
                        Timing = c.DateTime(nullable: false),
                        Users_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.JobTypes", t => t.JobTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .Index(t => t.JobTypeId)
                .Index(t => t.Users_Id);
            
            CreateTable(
                "dbo.JobTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobTypeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LogTypeId = c.Int(nullable: false),
                        LogDetail = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LogTypes", t => t.LogTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.LogTypeId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.LogTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LogTypeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PostDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PostId = c.Int(nullable: false),
                        PostBody = c.String(),
                        FeaturedImage = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Posts", t => t.PostId, cascadeDelete: true)
                .Index(t => t.PostId);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PostTitle = c.String(),
                        PostDate = c.DateTime(nullable: false),
                        PostedBy = c.Int(nullable: false),
                        PostTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PostTypes", t => t.PostTypeId, cascadeDelete: true)
                .Index(t => t.PostTypeId);
            
            CreateTable(
                "dbo.PostTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PostTypeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SubjectCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubjectCategoryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubjectName = c.String(),
                        SubjectCategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SubjectCategories", t => t.SubjectCategoryId, cascadeDelete: true)
                .Index(t => t.SubjectCategoryId);
            
            CreateTable(
                "dbo.SubjectTests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TestId = c.Int(nullable: false),
                        SubjectId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .ForeignKey("dbo.Tests", t => t.TestId, cascadeDelete: true)
                .Index(t => t.TestId)
                .Index(t => t.SubjectId);
            
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TestName = c.String(),
                        TestLevelId = c.Int(nullable: false),
                        TestTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TestTypes", t => t.TestTypeId, cascadeDelete: true)
                .ForeignKey("dbo.TestLevels", t => t.TestLevelId, cascadeDelete: true)
                .Index(t => t.TestLevelId)
                .Index(t => t.TestTypeId);
            
            CreateTable(
                "dbo.TestTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TestTypeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TestLevels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TestLevelName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TestResults",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TestId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        Result = c.String(),
                        Distinction = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tests", t => t.TestId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.TestId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.UserAchievements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Achievement = c.String(),
                        AchievementYear = c.DateTime(nullable: false),
                        Link = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.UserEducations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        DegreeId = c.Int(nullable: false),
                        InstituteId = c.Int(nullable: false),
                        PassingYear = c.String(),
                        CGPA = c.String(),
                        Percentage = c.String(),
                        Grade = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Degrees", t => t.DegreeId, cascadeDelete: true)
                .ForeignKey("dbo.Institutes", t => t.InstituteId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.DegreeId)
                .Index(t => t.InstituteId);
            
            CreateTable(
                "dbo.UserJobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        ApplyDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Jobs", t => t.JobId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.JobId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.UserLocations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        AreaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Areas", t => t.AreaId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.AreaId);
            
            CreateTable(
                "dbo.UserLogins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Username = c.String(),
                        Password = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.UserSkills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        Skills = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.UserSubjects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SubjectId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subjects", t => t.SubjectId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.SubjectId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.UserTests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        TestId = c.Int(nullable: false),
                        ResultId = c.Int(nullable: false),
                        Results_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TestResults", t => t.Results_Id)
                .ForeignKey("dbo.Tests", t => t.TestId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.TestId)
                .Index(t => t.Results_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserTests", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserTests", "TestId", "dbo.Tests");
            DropForeignKey("dbo.UserTests", "Results_Id", "dbo.TestResults");
            DropForeignKey("dbo.UserSubjects", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserSubjects", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.UserSkills", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserLogins", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserLocations", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserLocations", "AreaId", "dbo.Areas");
            DropForeignKey("dbo.UserJobs", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserJobs", "JobId", "dbo.Jobs");
            DropForeignKey("dbo.UserEducations", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserEducations", "InstituteId", "dbo.Institutes");
            DropForeignKey("dbo.UserEducations", "DegreeId", "dbo.Degrees");
            DropForeignKey("dbo.UserAchievements", "UserId", "dbo.Users");
            DropForeignKey("dbo.TestResults", "UserId", "dbo.Users");
            DropForeignKey("dbo.TestResults", "TestId", "dbo.Tests");
            DropForeignKey("dbo.SubjectTests", "TestId", "dbo.Tests");
            DropForeignKey("dbo.Tests", "TestLevelId", "dbo.TestLevels");
            DropForeignKey("dbo.Tests", "TestTypeId", "dbo.TestTypes");
            DropForeignKey("dbo.SubjectTests", "SubjectId", "dbo.Subjects");
            DropForeignKey("dbo.Subjects", "SubjectCategoryId", "dbo.SubjectCategories");
            DropForeignKey("dbo.PostDetails", "PostId", "dbo.Posts");
            DropForeignKey("dbo.Posts", "PostTypeId", "dbo.PostTypes");
            DropForeignKey("dbo.Logs", "UserId", "dbo.Users");
            DropForeignKey("dbo.Logs", "LogTypeId", "dbo.LogTypes");
            DropForeignKey("dbo.Jobs", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.Jobs", "JobTypeId", "dbo.JobTypes");
            DropForeignKey("dbo.Institutes", "CityId", "dbo.Cities");
            DropForeignKey("dbo.FeedbackDetails", "FeedbackId", "dbo.Feedbacks");
            DropForeignKey("dbo.Feedbacks", "Users2_Id", "dbo.Users");
            DropForeignKey("dbo.Feedbacks", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.Feedbacks", "FeedbackTypeId", "dbo.FeedbackTypes");
            DropForeignKey("dbo.Degrees", "DegreeTypeId", "dbo.DegreeTypes");
            DropForeignKey("dbo.ChatMessages", "Users2_Id", "dbo.Users");
            DropForeignKey("dbo.ChatMessages", "Users1_Id", "dbo.Users");
            DropForeignKey("dbo.ChatMessages", "ChatId", "dbo.Chats");
            DropForeignKey("dbo.Chats", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.Areas", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Admins", "UserId", "dbo.Users");
            DropForeignKey("dbo.Users", "UserTypeId", "dbo.UserTypes");
            DropIndex("dbo.UserTests", new[] { "Results_Id" });
            DropIndex("dbo.UserTests", new[] { "TestId" });
            DropIndex("dbo.UserTests", new[] { "UserId" });
            DropIndex("dbo.UserSubjects", new[] { "UserId" });
            DropIndex("dbo.UserSubjects", new[] { "SubjectId" });
            DropIndex("dbo.UserSkills", new[] { "UserId" });
            DropIndex("dbo.UserLogins", new[] { "UserId" });
            DropIndex("dbo.UserLocations", new[] { "AreaId" });
            DropIndex("dbo.UserLocations", new[] { "UserId" });
            DropIndex("dbo.UserJobs", new[] { "UserId" });
            DropIndex("dbo.UserJobs", new[] { "JobId" });
            DropIndex("dbo.UserEducations", new[] { "InstituteId" });
            DropIndex("dbo.UserEducations", new[] { "DegreeId" });
            DropIndex("dbo.UserEducations", new[] { "UserId" });
            DropIndex("dbo.UserAchievements", new[] { "UserId" });
            DropIndex("dbo.TestResults", new[] { "UserId" });
            DropIndex("dbo.TestResults", new[] { "TestId" });
            DropIndex("dbo.Tests", new[] { "TestTypeId" });
            DropIndex("dbo.Tests", new[] { "TestLevelId" });
            DropIndex("dbo.SubjectTests", new[] { "SubjectId" });
            DropIndex("dbo.SubjectTests", new[] { "TestId" });
            DropIndex("dbo.Subjects", new[] { "SubjectCategoryId" });
            DropIndex("dbo.Posts", new[] { "PostTypeId" });
            DropIndex("dbo.PostDetails", new[] { "PostId" });
            DropIndex("dbo.Logs", new[] { "UserId" });
            DropIndex("dbo.Logs", new[] { "LogTypeId" });
            DropIndex("dbo.Jobs", new[] { "Users_Id" });
            DropIndex("dbo.Jobs", new[] { "JobTypeId" });
            DropIndex("dbo.Institutes", new[] { "CityId" });
            DropIndex("dbo.Feedbacks", new[] { "Users2_Id" });
            DropIndex("dbo.Feedbacks", new[] { "Users1_Id" });
            DropIndex("dbo.Feedbacks", new[] { "FeedbackTypeId" });
            DropIndex("dbo.FeedbackDetails", new[] { "FeedbackId" });
            DropIndex("dbo.Degrees", new[] { "DegreeTypeId" });
            DropIndex("dbo.Chats", new[] { "Users_Id" });
            DropIndex("dbo.ChatMessages", new[] { "Users2_Id" });
            DropIndex("dbo.ChatMessages", new[] { "Users1_Id" });
            DropIndex("dbo.ChatMessages", new[] { "ChatId" });
            DropIndex("dbo.Areas", new[] { "CityId" });
            DropIndex("dbo.Users", new[] { "UserTypeId" });
            DropIndex("dbo.Admins", new[] { "UserId" });
            DropTable("dbo.UserTests");
            DropTable("dbo.UserSubjects");
            DropTable("dbo.UserSkills");
            DropTable("dbo.UserLogins");
            DropTable("dbo.UserLocations");
            DropTable("dbo.UserJobs");
            DropTable("dbo.UserEducations");
            DropTable("dbo.UserAchievements");
            DropTable("dbo.TestResults");
            DropTable("dbo.TestLevels");
            DropTable("dbo.TestTypes");
            DropTable("dbo.Tests");
            DropTable("dbo.SubjectTests");
            DropTable("dbo.Subjects");
            DropTable("dbo.SubjectCategories");
            DropTable("dbo.PostTypes");
            DropTable("dbo.Posts");
            DropTable("dbo.PostDetails");
            DropTable("dbo.LogTypes");
            DropTable("dbo.Logs");
            DropTable("dbo.JobTypes");
            DropTable("dbo.Jobs");
            DropTable("dbo.Institutes");
            DropTable("dbo.FeedbackTypes");
            DropTable("dbo.Feedbacks");
            DropTable("dbo.FeedbackDetails");
            DropTable("dbo.DegreeTypes");
            DropTable("dbo.Degrees");
            DropTable("dbo.Chats");
            DropTable("dbo.ChatMessages");
            DropTable("dbo.Cities");
            DropTable("dbo.Areas");
            DropTable("dbo.UserTypes");
            DropTable("dbo.Users");
            DropTable("dbo.Admins");
        }
    }
}
