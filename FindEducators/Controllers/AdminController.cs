using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using FindEducators.Common;
using FindEducators.Context;
using FindEducators.Models;

namespace FindEducators.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult CreateAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAdmin(FormCollection formCollection)
        {
            return View();
        }
         [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }
         [HttpPost]
        public ActionResult SignUp(Admin admin )
        {
            return View();
        }


         [HttpGet]
         public ActionResult SignIn()
         {
             return View();
         }


         [HttpPost]
         public ActionResult SignIn(Admin admin)
         {
             return View();
         }


        [HttpGet]
        public ActionResult DegreeType(int id=0)
        {
            var degreeTypeList = FindEducatorsRepository.GetAllDegreeTypes();
            var degreeType = new DegreeType();
            if (id > 0)
            {
                degreeType = FindEducatorsRepository.GetDegreeTypeById(id);
            }
            else
            {
                degreeType.Id = -1;
                degreeType.DegreeTypeName = "";
            }                      
            ViewBag.DegreeTypeList = degreeTypeList;
            ViewBag.DegreeType = degreeType;
            return View(degreeType);
        }



        [HttpPost]
        public ActionResult DegreeType(DegreeType degreeType)
        {
            if (degreeType.Id > -1)
            {
              FindEducatorsRepository.UpdateDegreeType(degreeType);  
            }
            else
            {
                FindEducatorsRepository.InsertDegreeType(degreeType);
            }

            var degreeTypeList = FindEducatorsRepository.GetAllDegreeTypes();
            ViewBag.DegreeTypeList = degreeTypeList;
            
            degreeType.Id = -1;
            degreeType.DegreeTypeName = "";

            ViewBag.DegreeType = degreeType;

            return View();
        }


        public ActionResult DeleteDegreeType(int id = 0)
        {
            FindEducatorsRepository.DeleteDegreeType(id);

            return RedirectToAction("DegreeType");
        }


        [HttpGet]
        public ActionResult Degree(int id=0)
        {
            var degreeList = FindEducatorsRepository.GetAllDegrees();
            var degree = new Degree();
            if (id > 0)
            {
                degree = FindEducatorsRepository.GetDegreeById(id);
            }
            else
            {
                degree.Id = -1;
                degree.DegreeName = "";

            }

            ViewBag.DegreeList = degreeList;

            ViewBag.Degree = degree;
            return View(degree);
        }
    

        public ActionResult DeleteDegree(int id = 0)
            {
                FindEducatorsRepository.DeleteDegree(id);

                return RedirectToAction("Degree");
            }
        

        [HttpPost]
        public ActionResult Degree(Degree degree)
        {
            if (degree.Id > -1)
            {
                FindEducatorsRepository.UpdateDegree(degree);
            }
            else
            {
                FindEducatorsRepository.InsertDegree(degree);
            }

            var degreeList = FindEducatorsRepository.GetAllDegrees();
            ViewBag.DegreeList = degreeList;

            degree.Id = -1;
            degree.DegreeName = "";

            ViewBag.Degree = degree;

            return View();
        }


        [HttpGet]
        public ActionResult Area (int id=0)
        {
            var areaList = FindEducatorsRepository.GetAllAreas();
            var area = new Area();
            if (id > 0)
            {
                area = FindEducatorsRepository.GetAreaById(id);
            }
            else
            {
                area.Id = -1;
                area.AreaName = "";
            }
            ViewBag.AreaList = areaList;
            ViewBag.Area = area;
            return View(area);
        }


        public ActionResult DeleteArea(int id = 0)
        {
            FindEducatorsRepository.DeleteDegree(id);
            return RedirectToAction("Degree");
        }

        [HttpPost]
        public ActionResult Areas(Area area)
        {
            {
                if (area.Id > -1)
                {
                    FindEducatorsRepository.UpdateArea(area);
                }
                else
                {
                    FindEducatorsRepository.InsertArea(area);
                }
                var areaList = FindEducatorsRepository.GetAllAreas();
                ViewBag.AreaList = areaList;
                area.Id = -1;
                area.AreaName = "";
                ViewBag.AreaList= area;
                return View();
            }
        }

        [HttpGet]
        public ActionResult Institute(int id= 0)
        {
            var instituteList = FindEducatorsRepository.GetAllInstitutes();
            var institute = new Institute();
            if (id > 0)
            {
                institute = FindEducatorsRepository.GetInstituteById(id);
            }
            else
            {
                institute.Id = -1;
                institute.InstituteName = "";

            }

            ViewBag.InstituteList = instituteList;

            ViewBag.Institute = institute;
            return View(institute);
        }


        [HttpPost]
        public ActionResult Institute(Institute institute)
        {
            if (institute.Id > -1)
            {
                FindEducatorsRepository.UpdateInstitute(institute);
            }
            else
            {
                FindEducatorsRepository.InsertInstitute(institute);
            }

            var degreeTypeList = FindEducatorsRepository.GetAllInstitutes();
            ViewBag.InstituteList = institute;

            institute.Id = -1;
            institute.InstituteName = "";

            ViewBag.InstituteList = institute;

            return View();  
        }


        public ActionResult DeleteInstitute(int id = 0)
        {
            FindEducatorsRepository.DeleteInstitute(id);

            return RedirectToAction("Institute");
        }


        [HttpGet]
        public ActionResult FeedbackType(int id =0)
        {
            var feedbackList = FindEducatorsRepository.GetAllFeedbackTypes();
            var feedbackType = new FeedbackType();
            if (id > 0)
            {
                feedbackType = FindEducatorsRepository.GetFeedBackTypeById(id);
            }
            else
            {
                feedbackType.Id = -1;
                feedbackType.FeedbackTypeName = "";
            }

            ViewBag.FeedbackTypeList = feedbackList;
            ViewBag.FeedbackType = feedbackType;
            return View(feedbackType);
        }

        [HttpPost]
        public ActionResult FeedbackType(FeedbackType feedbackType)
        {
            if (feedbackType.Id > -1)
            {
                FindEducatorsRepository.UpdateFeedbackType(feedbackType);
            }
            else
            {
                FindEducatorsRepository.InsertFeedbackType(feedbackType);
            }

            var feedbackTypeList = FindEducatorsRepository.GetAllFeedbackTypes();
            ViewBag.FeedbackTypeList = feedbackTypeList;

            feedbackType.Id = -1;
            feedbackType.FeedbackTypeName= "";

            ViewBag.FeedbackType = feedbackType;

            return View();
        }

        public ActionResult DeleteFeedbackType(int id)
        {
            FindEducatorsRepository.DeleteFeedbackType(id);
            return RedirectToAction("FeedbackType");
        }

        [HttpGet]
        public ActionResult JobType(int id=0)
        {
            var jobTypeList = FindEducatorsRepository.GetAllJobTypes();
            var jobType = new JobType();
            if (id > 0)
            {
                jobType = FindEducatorsRepository.GetJobTypeById(id);
            }
            else
            {
                jobType.Id = -1;
                jobType.JobTypeName = "";
            }
            ViewBag.JobTypeList = jobTypeList;
            ViewBag.JobType = jobType;
            return View(jobType);
        }


        [HttpPost]
        public ActionResult JobType(JobType jobType)
        {
            if (jobType.Id > -1)
            {
                FindEducatorsRepository.UpdateJobType(jobType);
            }
            else
            {
                FindEducatorsRepository.InsertJobType(jobType);
            }

            var jobTypeList = FindEducatorsRepository.GetAllJobTypes();
            ViewBag.JobTypeList = jobTypeList;

            jobType.Id = -1;
            jobType.JobTypeName = "";
            ViewBag.JobType = jobType;

            return View();
        }

        public ActionResult DeleteJobType(int id = 0)
        {
           
            FindEducatorsRepository.DeleteJobType(id);

            return RedirectToAction("JobType");
        }


        [HttpGet]
        public ActionResult Log(int id= 0)
        {
            var logList = FindEducatorsRepository.GetAllLogs();
            var log = new Log();
            if (id > 0)
            {
                log = FindEducatorsRepository.GetLogById(id);
            }
            else
            {
                log.Id = -1;
                log.LogDetail = "";
            }
            ViewBag.LogList = logList;
            ViewBag.Log = log;
            return View(log);

        }

        [HttpPost]
        public ActionResult Log(Log log)
        {
            if (log.Id > -1)
            {
                FindEducatorsRepository.UpdateLog(log);
            }
            else
            {
                FindEducatorsRepository.InsertLog(log);
            }

            var logList = FindEducatorsRepository.GetAllLogs();
            ViewBag.LogList = logList;

            log.Id = -1;
            log.LogDetail = "";
            log.LogTypeId = 0;

            ViewBag.DegreeType = log;

            return View();
        }

        public ActionResult DeleteLog(int id = 0)
            {
                FindEducatorsRepository.DeleteLog(id);

                return RedirectToAction("Log");
            }


         [HttpGet]
        public ActionResult LogType(int id = 0)
        {
            var logTypeList = FindEducatorsRepository.GetAllLogTypes();
            var logType = new LogType();
            if (id > 0)
            {
                logType = FindEducatorsRepository.GetLogTypeById(id);
            }
            else
            {
                logType.Id = -1;
                logType.LogTypeName = "";
            }
            ViewBag.LogTypeList = logTypeList;
            ViewBag.LogType = logType;
            return View(logType);
        }

        [HttpPost]
        public ActionResult LogType(LogType logType)
        {
            if (logType.Id > -1)
            {
                FindEducatorsRepository.UpdateLogType(logType);
            }
            else
            {
                FindEducatorsRepository.InsertLogType(logType);
            }

            var logTypeList = FindEducatorsRepository.GetAllLogTypes();
            ViewBag.LogType = logType;

            logType.Id = -1;
            logType.LogTypeName= "";

            ViewBag.LogTypeList = logTypeList;
            ViewBag.DegreeType = logType;

            return View();
        }

        public ActionResult DeleteLogType(int id = 0)
        {
            FindEducatorsRepository.DeleteLogType(id);

            return RedirectToAction("LogType");
        }

        [HttpGet]
        public ActionResult Post(int id = 0)
        {
            var postList = FindEducatorsRepository.GetAllPost();
            var post = new Post();
            if (id > 0)
            {
                post = FindEducatorsRepository.GetPostById(id);
            }
            else
            {
                post.Id = -1;
                post.PostTitle = "";
            }

            ViewBag.PostList = postList;

            ViewBag.Post = post;
            return View(post);
        }
        [HttpPost]
        public ActionResult Post(Post post)
        {
            if (post.Id > -1)
            {
                FindEducatorsRepository.UpdatePost(post);
            }
            else
            {
                FindEducatorsRepository.InsertPost(post);
            }

            var postList = FindEducatorsRepository.GetAllPost();
            ViewBag.PostList = postList;

            post.Id = -1;
            post.PostTitle = "";

            ViewBag.Post = post;

            return View();
        }
        public ActionResult DeletePost(int id = 0)
        {
            FindEducatorsRepository.DeletePost(id);

            return RedirectToAction("Post");
        }
        

        [HttpGet]
        public ActionResult PostType(int id = 0)
        {
            var postTypeList = FindEducatorsRepository.GetAllPostsTypes();
            var postType = new PostType();
            if (id > 0)
            {
                postType = FindEducatorsRepository.GetPostTypeById(id);
            }
            else
            {
                postType.Id = -1;
                postType.PostTypeName = "";
            }

            ViewBag.PostTypeList = postTypeList;

            ViewBag.PostType = postType;
            return View(postType);
        }

        [HttpPost]
        public ActionResult PostType(PostType postType)
        {
            if (postType.Id > -1)
            {
                FindEducatorsRepository.UpdatePostType(postType);
            }
            else
            {
                FindEducatorsRepository.InsertPostType(postType);
            }

            var postTypeList = FindEducatorsRepository.GetAllPostsTypes();
            ViewBag.PostTypeList = postTypeList;

            postType.Id = -1;
            postType.PostTypeName = "";

            ViewBag.PostType = postType;

            return View();
        }


        public ActionResult DeletePostType(int id = 0)
        {
            FindEducatorsRepository.DeletePostType(id);

            return RedirectToAction("PostType");
        }
       

        [HttpGet]
        public ActionResult Subject(int id = 0)
        {
            var subjectList = FindEducatorsRepository.GetAllSubjects();
            var subject = new Subject();
            if (id > 0)
            {
                subject = FindEducatorsRepository.GetSubjectById(id);
            }
            else
            {
                subject.Id = -1;
                subject.SubjectName = "";
            }

            ViewBag.SubjectList = subjectList;

            ViewBag.Subject = subject;
            return View(subject);
        }

        [HttpPost]
        public ActionResult Subject(Subject subject)
        {
            if (subject.Id > -1)
            {
                FindEducatorsRepository.UpdateSubject(subject);
            }
            else
            {
                FindEducatorsRepository.InsertSubject(subject);
            }

            var subjectList = FindEducatorsRepository.GetAllSubjects();
            ViewBag.SubjectList = subjectList;

            subject.Id = -1;
            subject.SubjectName = "";

            ViewBag.Subject = subject;

            return View();
        }


        public ActionResult DeleteSubject(int id = 0)
        {
            FindEducatorsRepository.DeleteSubject(id);

            return RedirectToAction("Subject");
        }

        [HttpGet]
        public ActionResult SubjectCategory(int id = 0)
        {
            var subjectCategoryList = FindEducatorsRepository.GetAllSubjectCategories();
            var subjectCategory = new SubjectCategory();
            if (id > 0)
            {
                subjectCategory = FindEducatorsRepository.GetSubjectCategoryById(id);
            }
            else
            {
                subjectCategory.Id = -1;
                subjectCategory.SubjectCategoryName = "";
            }

            ViewBag.SubjectCategoryList = subjectCategoryList;

            ViewBag.SubjectCategory = subjectCategory;
            return View(subjectCategory);

        }
        
        [HttpPost]
        public ActionResult SubjectCategory(SubjectCategory subjectCategory)
        {
            if (subjectCategory.Id > -1)
            {
                FindEducatorsRepository.UpdateSubjectCategory(subjectCategory);
            }
            else
            {
                FindEducatorsRepository.InsertSubjectCategory(subjectCategory);
            }

            var subjectCategoryList = FindEducatorsRepository.GetAllSubjectCategories();
            ViewBag.SubjectCategoryList = subjectCategoryList;

            subjectCategory.Id = -1;
            subjectCategory.SubjectCategoryName = "";

            ViewBag.SubjectCategory = subjectCategory;

            return View();
        }


        public ActionResult DeleteSubjectCategory(int id = 0)
        {
              FindEducatorsRepository.DeleteSubjectCategory(id);

            return RedirectToAction("SubjectCategory");
        }

 
        [HttpGet]
        public ActionResult TestLevel(int id = 0)
        {
            var testLevelList = FindEducatorsRepository.GetAllTestLevels();
            var testLevel = new TestLevel();
            if (id > 0)
            {
                testLevel = FindEducatorsRepository.GetTestLevekById(id);
            }
            else
            {
                testLevel.Id = -1;
                testLevel.TestLevelName = "";
            }

            ViewBag.TestLevelList = testLevelList;

            ViewBag.TestLevel = testLevel;
            return View(testLevel);
        }

        [HttpPost]
        public ActionResult TestLevel(TestLevel testLevel)
        {
            if (testLevel.Id > -1)
            {
                FindEducatorsRepository.UpdateTestLevel(testLevel);
            }
            else
            {
                FindEducatorsRepository.InsertTestLevel(testLevel);
            }


            var testLevelList = FindEducatorsRepository.GetAllTestLevels();
            ViewBag.TestLevelList = testLevelList;

            testLevel.Id = -1;
            testLevel.TestLevelName = "";

            ViewBag.TestLevel = testLevel;

            return View();
        }


        public ActionResult DeleteTestLevel(int id = 0)
        {
            FindEducatorsRepository.DeleteTestLevel(id);

            return RedirectToAction("TestLevel");
        }

        [HttpGet]
        public ActionResult Test(int id = 0)
        {
            var testList = FindEducatorsRepository.GetAllTests();
            var test = new Test();
            if (id > 0)
            {
                test = FindEducatorsRepository.GetTestById(id);
            }
            else
            {
                test.Id = -1;
                test.TestName = "";
            }

            ViewBag.TestList = testList;

            ViewBag.Test = test;
            return View(test);
        }

        [HttpPost]
        public ActionResult Test(Test test)
        {
            if (test.Id > -1)
            {
                FindEducatorsRepository.UpdateTest(test);
            }
            else
            {
                FindEducatorsRepository.InsertTest(test);
            }

            var testList = FindEducatorsRepository.GetAllTests();
            ViewBag.TestList = testList;

            test.Id = -1;
            test.TestName = "";

            ViewBag.Test = test;

            return View();
        }

        public ActionResult DeleteTest(int id = 0)
        {
            FindEducatorsRepository.DeleteTest(id);

            return RedirectToAction("Test");
        }

        [HttpGet]
        public ActionResult TestType(int id = 0)
        {
            var testTypeList = FindEducatorsRepository.GetAllTestTypes();
            var testType = new TestType();
            if (id > 0)
            {
                testType = FindEducatorsRepository.GetTestTypeById(id);
            }
            else
            {
                testType.Id = -1;
                testType.TestTypeName = "";
            }

            ViewBag.TestTypeList = testTypeList;

            ViewBag.TestType = testType;
            return View(testType);
        }

        [HttpPost]
        public ActionResult TestType(TestType testType)
        {
            if (testType.Id > -1)
            {
                FindEducatorsRepository.UpdateTestType(testType);
            }
            else
            {
                FindEducatorsRepository.InsertTestType(testType);
            }

            var testTypeList = FindEducatorsRepository.GetAllTestTypes();
            ViewBag.TestTypeList = testTypeList;

            testType.Id = -1;
            testType.TestTypeName = "";

            ViewBag.TestType = testType;

            return View();
        }

        public ActionResult DeleteTestType(int id = 0)
        {
            FindEducatorsRepository.DeleteTestType(id);

            return RedirectToAction("TestType");
        }

    }
}
