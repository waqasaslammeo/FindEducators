using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;
using FindEducators.Context;
using FindEducators.Models;

namespace FindEducators.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            using(var context = new FindEducatorsContext())
            {
                UserLogin userLogin = null; //context.UserLogins.Where(x => x.Username == "username" && x.Password == "password").First();

                if (userLogin == null)
                {
                   return RedirectToAction("SignIn");
                }
                else
                {

                    return View();
                }
            }
           
        }

        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }


        [HttpPost]
        public ActionResult SignIn(string username, string password, Boolean rememberMe = false)
        {
            using (var context = new FindEducatorsContext())
            {
                var user = context.UserLogins.Single(x => x.Username == username && x.Password == password);

                if (user != null)
                {
                    

                    /*
                     1- ViewData
                     * 2- ViewBag
                     * 3- TempData
                     */

                 TempData.Add("uname", context.Users.Single(x => x.Id == user.UserId ).FirstName);
                 return RedirectToAction("Index", "Index");
                }
            }
            return View();
        }


        [HttpGet]
        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public  ActionResult SignUp(User user,string Username, string Password)
        {

            using (FindEducatorsContext findEducatorsContext = new FindEducatorsContext())
            {

                user.DOB = DateTime.Now.Date;
                user.UserTypeId = 1;
                findEducatorsContext.Users.Add(user);
                findEducatorsContext.SaveChanges();

              
            }

            using (FindEducatorsContext findEducatorsContext = new FindEducatorsContext())
            {
               var obj = findEducatorsContext.Users.Where(x=>x.CNIC==user.CNIC).First();

                var userLogin = new UserLogin();

                userLogin.Username = Username;
                userLogin.Password = Password;
                userLogin.UserId = obj.Id;
                findEducatorsContext.UserLogins.Add(userLogin);
                findEducatorsContext.SaveChanges();
            }
            return View();

        }
        //private bool SendSms(string number)
        //{
        //    try
        //    {

        //        var request = (HttpWebRequest)WebRequest.Create("https://www.experttexting.com/exptapi/exptsms.asmx/SendSMS");

        //        var postData = @"UserID=Kamranulhaq&PWD=kamran123&APIKEY=1tbrf9886j32v33&FROM=Find Educators&TO=" + number + "&MSG=You voting code is 23456. OVS.";
        //        var data = Encoding.ASCII.GetBytes(postData);

        //        request.Method = "POST";
        //        request.ContentType = "application/x-www-form-urlencoded";

        //        using (var stream = request.GetRequestStream())
        //        {
        //            stream.Write(data, 0, data.Length);
        //        }

        //        var response = (HttpWebResponse)request.GetResponse();

        //        var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //    return true;
        //}


        // GET: Users/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Users/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        // GET: Users/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Users/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
