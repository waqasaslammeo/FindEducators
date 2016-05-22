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

        public ActionResult Degree()
        {
            return View();
        }

        public ActionResult Areas()
        {
            return View();
        }

        public ActionResult Institution()
        {
            return View();
        }
        public ActionResult FeedbackType()
        {
            return View();
        }
        public ActionResult JobType()
        {
            return View();
        }
        public ActionResult Log()
        {
            return View();
        }
        public ActionResult LogType()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Post (int id =0)
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
