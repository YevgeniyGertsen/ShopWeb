using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using Users;

namespace Shop.Controllers
{
    public class UsersController : Controller
    {
        Entity db = new Entity();
        // GET: Users
        public ActionResult Index()
        {
           List<User> users = db.Users.ToList();
           // ViewBag.VisitHistory = db.VisitHistory.ToList();

            return View(users);
        }

        public ActionResult Adduser(string Name)
        {
            User user = new User();
            user.Name = Name;
            db.Users.Add(user);

            return RedirectToAction("Index");
        }
        //
    }
}