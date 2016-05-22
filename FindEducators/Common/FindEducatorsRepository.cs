using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FindEducators.Context;
using FindEducators.Models;

namespace FindEducators.Common
{
    public static class FindEducatorsRepository
    {

        #region Get

        public static DegreeType GetDegreeTypeById(int degreeTypeId)
        {
            var degreeType = new DegreeType();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                degreeType = db.DegreeTypes.Single(x => x.Id == degreeTypeId);
            }

            return degreeType;
        }

        public static Test GetTestById(int testId)
        {
            var test = new Test();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                test = db.Tests.Single(x => x.Id == testId);
            }

            return test;
        }
        public static TestType GetTestTypeById(int testTypeId)
        {
            var testType = new TestType();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                testType = db.TestTypes.Single(x => x.Id == testTypeId);
            }

            return testType;
        }
        public static TestLevel GetTestLevekById(int testLevelId)
        {
            var testLevel = new TestLevel();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                testLevel = db.TestLevels.Single(x => x.Id == testLevelId);
            }

            return testLevel;
        }

        public static Area GetAreaById(int Id)
        {
            var area = new Area();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                area = db.Areas.Single(x => x.Id == Id);
            }

            return area;
        }
        public static Degree GetDegreeById(int degreeId)
        {
            var degree = new Degree();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                degree = db.Degrees.Single(x => x.Id == degreeId);
            }

            return degree;
        }
        public static Institute GetInstituteById(int InstituteId)
        {
            var institute = new Institute();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                institute = db.Institutes.Single(x => x.Id == InstituteId);
            }

            return institute;
        }
        public static FeedbackType GetFeedBackTypeById(int feedbackTypeId)
        {
            var feedbackType = new FeedbackType();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                feedbackType = db.FeedbackTypes.Single(x => x.Id == feedbackTypeId);
            }

            return feedbackType;
        }
        public static JobType GetJobTypeById(int jobTypeId)
        {
            var jobType = new JobType();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                jobType = db.JobTypes.Single(x => x.Id == jobTypeId);
            }

            return jobType;
        }
        public static Log GetLogById(int logId)
        {
            var log = new Log();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                log = db.Logs.Single(x => x.Id == logId);
            }

            return log;
        }
         public static LogType GetLogTypeById(int logTypeId)
        {
            var logType = new LogType();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                logType = db.LogTypes.Single(x => x.Id == logTypeId);
            }

            return logType;
        }
         public static Post GetPostById(int postId)
         {
             var post = new Post();

             using (FindEducatorsContext db = new FindEducatorsContext())
             {
                 post = db.Posts.Single(x => x.Id == postId);
             }

             return post;
         }
         public static PostType GetPostTypeById(int PostTypeId)
         {
             var postType = new PostType();

             using (FindEducatorsContext db = new FindEducatorsContext())
             {
                 postType = db.PostTypes.Single(x => x.Id == PostTypeId);
             }

             return postType;
         }
         public static Subject GetSubjectById(int subjectId)
         {
             var subject = new Subject();

             using (FindEducatorsContext db = new FindEducatorsContext())
             {
                 subject = db.Subjects.Single(x => x.Id == subjectId);
             }

             return subject;
         }
         public static SubjectCategory GetSubjectCategoryById(int subjectCategoryId)
         {
             var subjectCategory = new SubjectCategory();

             using (FindEducatorsContext db = new FindEducatorsContext())
             {
                 subjectCategory = db.SubjectCategories.Single(x => x.Id == subjectCategoryId);
             }

             return subjectCategory;
         }

        #endregion

        #region List

        public static List<DegreeType> GetAllDegreeTypes()
        {
            var degreeTypeList = new List<DegreeType>();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                degreeTypeList = db.DegreeTypes.ToList();
            }

            return degreeTypeList;
        }

        public static List<Test> GetAllTests()
        {
            var testList = new List<Test>();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                testList = db.Tests.ToList();
            }

            return testList;
        }
        public static List<TestType> GetAllTestTypes()
        {
            var testTypeList = new List<TestType>();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                testTypeList = db.TestTypes.ToList();
            }

            return testTypeList;
        }

        public static List<TestLevel> GetAllTestLevels()
        {
            var testLevelList = new List<TestLevel>();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                testLevelList = db.TestLevels.ToList();
            }

            return testLevelList;
        }

        public static List<Area> GetAllAreas()
        {
            var areaList = new List<Area>();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
               areaList = db.Areas.ToList();
            }

            return areaList;
        }
        public static List<Degree> GetAllDegrees()
        {
            var degree = new List<Degree>();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                degree = db.Degrees.ToList();
            }

            return degree;
        }
        public static List<Institute> GetAllInstitutes()
        {
            var instituteList = new List<Institute>();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                instituteList = db.Institutes.ToList();
            }

            return instituteList;
        }
        public static List<FeedbackType> GetAllFeedbackTypes()
    {
            var feedbackTypeList = new List<FeedbackType>();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                feedbackTypeList = db.FeedbackTypes.ToList();
            }

            return feedbackTypeList;
        }
        public static List<JobType> GetAllJobTypes()
        {
            var jobTypeList = new List<JobType>();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                jobTypeList = db.JobTypes.ToList();
            }

            return jobTypeList;
        }
        public static List<Log> GetAllLogs()
        {
            var logList = new List<Log>();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                logList = db.Logs.ToList();
            }

            return logList;
        }
        public static List<LogType> GetAllLogTypes()
        {
            var logTypeList = new List<LogType>();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                logTypeList = db.LogTypes.ToList();
            }

            return logTypeList;
        }
        public static List<Post> GetAllPost()
        {
            var postList = new List<Post>();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                postList = db.Posts.ToList();
            }

            return postList;
        }
        public static List<PostType> GetAllPostsTypes()
        {
            var PostTypeList = new List<PostType>();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                PostTypeList = db.PostTypes.ToList();
            }

            return PostTypeList;
        }
        public static List<Subject> GetAllSubjects()
        {
            var subjectList = new List<Subject>();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                subjectList = db.Subjects.ToList();
            }

            return subjectList;
        }
        public static List<SubjectCategory> GetAllSubjectCategories()
        {
            var subjectCategoryList = new List<SubjectCategory>();

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                subjectCategoryList = db.SubjectCategories.ToList();
            }

            return subjectCategoryList;

        }
        #endregion

        #region Insert

        public static void InsertDegreeType(DegreeType degreeType)
        {
            
            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                db.DegreeTypes.Add(degreeType);
                db.SaveChanges();
            }
        }

        public static void InsertTest(Test test)
        {

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                db.Tests.Add(test);
                db.SaveChanges();
            }
        }
        
        public static void InsertTestType(TestType testType)
        {
             using (FindEducatorsContext db = new FindEducatorsContext())
            {
                db.TestTypes.Add(testType);
                db.SaveChanges();
            }
        }
        public static void InsertArea(Area area)
        {
            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                  db.Areas.Add(area);
                db.SaveChanges();
            }
        }
        public static void InsertTestLevel(TestLevel testLevel)
        {
           using(FindEducatorsContext db = new FindEducatorsContext())
            {
                db.TestLevels.Add(testLevel);
                db.SaveChanges();
            }
        }
        
        public static void InsertDegree(Degree degree)
        {
                using (FindEducatorsContext db = new FindEducatorsContext())
            {
                db.Degrees.Add(degree);
                db.SaveChanges();
            }
        }
        public static void InsertInstitute(Institute institute)
        {

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                db.Institutes.Add(institute);
                db.SaveChanges();
            }
        }
        public static void InsertFeedbackType(FeedbackType feedbackType)
        {

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                db.FeedbackTypes.Add(feedbackType);
                db.SaveChanges();
            }
        }
        public static void InsertJobType(JobType jobType)
        {

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                db.JobTypes.Add(jobType);
                db.SaveChanges();
            }
        }
        public static void InsertLog(Log log)
        {

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                db.Logs.Add(log);
                db.SaveChanges();
            }
        }
        public static void InsertLogType(LogType logType)
        {

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                db.LogTypes.Add(logType);
                db.SaveChanges();
            }
        }
        public static void InsertPost(Post post)
        {

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                db.Posts.Add(post);
                db.SaveChanges();
            }
        }
        public static void InsertSubject(Subject subject)
        {

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                db.Subjects.Add(subject);
                db.SaveChanges();
            }
        }
        public static void InsertSubjectCategory(SubjectCategory subjectCategory)
        {

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                db.SubjectCategories.Add(subjectCategory);
                db.SaveChanges();
            }
        }
        public static void InsertPostType(PostType postType)
        {

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                db.PostTypes.Add(postType);
                db.SaveChanges();
            }
       
        }
        #endregion

        #region Update
        public static void UpdateDegreeType(DegreeType degreeType)
        {
            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempDegreetype = db.DegreeTypes.Single(x => x.Id == degreeType.Id);
                tempDegreetype.DegreeTypeName = degreeType.DegreeTypeName;
                db.SaveChanges();
            }
        }

        public static void UpdateTest(Test test)
        {
            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempTest = db.Tests.Single(x => x.Id == test.Id);
                tempTest.TestName = test.TestName;
                tempTest.TestLevelId = test.TestLevelId;
                tempTest.TestTypeId = test.TestTypeId;
                db.SaveChanges();
            }
        }
        public static void UpdateTestType(TestType testType)
        {
            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempTesttype = db.TestTypes.Single(x => x.Id == testType.Id);
                tempTesttype.TestTypeName = testType.TestTypeName;
                db.SaveChanges();
            }
        }

        public static void UpdateTestLevel(TestLevel testLevel)
        {
            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempTestlevel = db.TestLevels.Single(x => x.Id == testLevel.Id);
                tempTestlevel.TestLevelName = testLevel.TestLevelName;
            }
        }

        public static void UpdateArea(Area area)
        {
            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempArea = db.Areas.Single(x => x.Id ==area.Id);
                tempArea.AreaName = area.AreaName;
                tempArea.CityId = area.CityId;
                db.SaveChanges();
            }
        }
        public static void UpdateDegree(Degree degree)
        {
            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempDegree = db.Degrees.Single(x => x.Id == degree.Id);
                tempDegree.DegreeName = degree.DegreeName;
                tempDegree.DegreeAbbrivation = degree.DegreeAbbrivation;
                tempDegree.DegreeTypeId = degree.DegreeTypeId;
                db.SaveChanges();
            }
        }
        public static void UpdateInstitute(Institute institute)
        {
            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempInstitute = db.Institutes.Single(x => x.Id == institute.Id);
                tempInstitute.InstituteName = institute.InstituteName;
                tempInstitute.CityId = institute.CityId;
                db.SaveChanges();
            }
        }
        public static void UpdateFeedbackType(FeedbackType feedbackType)
        {
            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempFeedbacktype = db.FeedbackTypes.Single(x => x.Id == feedbackType.Id);
                tempFeedbacktype.FeedbackTypeName = feedbackType.FeedbackTypeName;
                db.SaveChanges();
            }
        }
        public static void UpdateJobType(JobType jobType)
        {
            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempJobType = db.JobTypes.Single(x => x.Id == jobType.Id);
                tempJobType.JobTypeName = jobType.JobTypeName;
                db.SaveChanges();
            }
        }
        public static void UpdateLog(Log log)
        {
            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempLog = db.Logs.Single(x => x.Id == log.Id);
                tempLog.LogTypeId = log.LogTypeId;
                tempLog.LogDetail = log.LogDetail;
                db.SaveChanges();
            }
        }
        public static void UpdateLogType(LogType logType)
        {
            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempLogtype = db.LogTypes.Single(x => x.Id == logType.Id);
                tempLogtype.LogTypeName = logType.LogTypeName;
                db.SaveChanges();
            }
        }
        public static void UpdatePost(Post post)
        {
            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempPost = db.Posts.Single(x => x.Id ==post.Id);
                tempPost.PostTitle = post.PostTitle;
                tempPost.PostDate = post.PostDate;
                tempPost.PostTypeId = post.PostTypeId;
                tempPost.PostedBy = post.PostedBy;
                db.SaveChanges();
            }
        }
        public static void UpdatePostType(PostType postType)
        {
            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempPostType = db.PostTypes.Single(x => x.Id == postType.Id);
                tempPostType.PostTypeName= postType.PostTypeName;
               
                db.SaveChanges();
            }
        }
        public static void UpdateSubject(Subject subject)
        {
            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempSubject = db.Subjects.Single(x => x.Id == subject.Id);
                tempSubject.SubjectName= subject.SubjectName;
                tempSubject.SubjectCategoryId = subject.SubjectCategoryId;
                db.SaveChanges();
            }
        }
        public static void UpdateSubjectCategory(SubjectCategory subjectCategory)
        {
            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempSubjectCategory = db.SubjectCategories.Single(x => x.Id == subjectCategory.Id);
                tempSubjectCategory.SubjectCategoryName = subjectCategory.SubjectCategoryName;
                db.SaveChanges();
            }
        }
        #endregion

        #region Delete

        public static void DeleteDegreeType(int degreeTypeId)
        {

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempDegreeType = db.DegreeTypes.Single(x => x.Id == degreeTypeId);
                db.DegreeTypes.Remove(tempDegreeType);
               db.SaveChanges();
            }
        }
        public static void DeleteTest(int testId)
        {

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempTest = db.Tests.Single(x => x.Id == testId);
                db.Tests.Remove(tempTest);
                db.SaveChanges();
            }
        }

        public static void DeleteTestType(int testTypeId)
        {
            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempTestType = db.TestTypes.Single(x => x.Id == testTypeId);
                db.TestTypes.Remove(tempTestType);
                db.SaveChanges();
            }
        }

        public static void DeleteArea(int areaId)
        {
            using (FindEducatorsContext db = new FindEducatorsContext())
            {

                var tempAreas = db.Areas.Single(x => x.Id == areaId);
                db.Areas.Remove(tempAreas);
                db.SaveChanges();
            }

        }
        
        public static void DeleteTestLevel(int testLevelId)
        {
            using(FindEducatorsContext db = new FindEducatorsContext())
            {

                var tempTestLevel = db.TestLevels.Single(x => x.Id == testLevelId);
                db.TestLevels.Remove(tempTestLevel);
                db.SaveChanges();
            }
        }
        public static void DeleteDegree(int degreeId)
        {

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempDegree = db.Degrees.Single(x => x.Id ==degreeId);
                db.Degrees.Remove(tempDegree);
                db.SaveChanges();
            }
        }
        public static void DeleteInstitute(int instituteId)
        {

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempInstitute = db.Institutes.Single(x => x.Id ==instituteId );
                db.Institutes.Remove(tempInstitute);
                db.SaveChanges();
            }
        }
        public static void DeleteFeedbackType(int feedbackTypeId)
        {

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempFeedbackType = db.FeedbackTypes.Single(x => x.Id == feedbackTypeId);
                db.FeedbackTypes.Remove(tempFeedbackType);
                db.SaveChanges();
            }
        }
        public static void DeleteJobType(int jobTypeId)
        {

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempJobType = db.JobTypes.Single(x => x.Id == jobTypeId);
                db.JobTypes.Remove(tempJobType);
                db.SaveChanges();
            }
        }
        public static void DeleteLog(int logId)
        {

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempLog = db.Logs.Single(x => x.Id == logId);
                db.Logs.Remove(tempLog);
                db.SaveChanges();
            }
        }
        public static void DeleteLogType(int logTypeId)
        {

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempLogType = db.LogTypes.Single(x => x.Id == logTypeId);
                db.LogTypes.Remove(tempLogType);
                db.SaveChanges();
            }
        }
        public static void DeletePost(int postId)
        {

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempPost = db.Posts.Single(x => x.Id ==postId);
                db.Posts.Remove(tempPost);
                db.SaveChanges();
            }
        }
        public static void DeletePostType(int postTypeId)
        {

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempPostType = db.PostTypes.Single(x => x.Id ==postTypeId);
                db.PostTypes.Remove(tempPostType);
                db.SaveChanges();
            }
        }
        public static void DeleteSubject(int subjectId)
        {

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                var tempSubject = db.Subjects.Single(x => x.Id == subjectId);
                db.Subjects.Remove(tempSubject);
                db.SaveChanges();
            }
        }
        public static void DeleteSubjectCategory(int subjectCategoryId)

        {

            using (FindEducatorsContext db = new FindEducatorsContext())
            {
                
                var tempSubjectCategory = db.SubjectCategories.Single(x => x.Id == subjectCategoryId);
                db.SubjectCategories.Remove(tempSubjectCategory);
                db.SaveChanges();
            }
        }
        #endregion


    }
}