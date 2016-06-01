using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FindEducators.Context;

namespace FindEducators.Controllers
{
    public class APIController : Controller
    {

        [HttpPost]
        public string AuthenticateUser(string username, string password)
        {

            using (FindEducatorsContext db= new FindEducatorsContext())
            {
                var status = db.UserLogins.Any(x => x.Username == username && x.Password == password);

                if (status)
                {
                    return "true";
                }
            }
            return "false";
        }
    }
}