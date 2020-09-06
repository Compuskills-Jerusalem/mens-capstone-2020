using Mens2020.DataSource.DataSource;
using Mens2020.DataSource.Models;
using Microsoft.AspNet.Identity;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mens2020.Mvc.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            using (var db = new Capstone2020Context(nameof(Capstone2020Context)))
            {

                var currentUser = User.Identity.GetUserId();

                var userEvents = from loggedInUserEvent in db.UserEvents.Include(u => u.User)
                                 where currentUser == loggedInUserEvent.UserId
                                 select loggedInUserEvent
                                ;
                return View(userEvents.ToList());


            }

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
