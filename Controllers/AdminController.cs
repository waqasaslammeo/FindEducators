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

        public ActionResult Post ()
        {
            return View();
        }
        public ActionResult PostType()
        {
            return View();
        }
        public ActionResult Subject()
        {
            return View();
        }
        public ActionResult SubjectCategory()
        {
            return View();
        }
        public ActionResult TestLevel()
        {
            return View();
        }
        public ActionResult Test()
        {
            return View();
        }
        public ActionResult TestType()
        {
            return View();
        }
    }
}
