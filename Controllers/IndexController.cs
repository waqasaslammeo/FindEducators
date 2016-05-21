using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Web;
using System.Web.Mvc;
using FindEducators.Context;
using FindEducators.Models;

namespace FindEducators.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            List<User> lstUsr = new List<User>();
            

            using (FindEducatorsContext findEducatorsContext = new FindEducatorsContext())
            {
                lstUsr = findEducatorsContext.Users.Where(x => x.UserTypeId == 1).ToList();
            }

            return View(lstUsr);
        }

        [HttpGet]
        public ActionResult TeahcersList()
        {

            return View();
        }


        [HttpPost]
        public ActionResult TeahcersList(int id )
        {
            return View();
        }


        public ActionResult MyView()
        {
            return View();
        }
        
    }
}