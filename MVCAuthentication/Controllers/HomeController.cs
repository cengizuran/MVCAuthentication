using MVCAuthentication.AuthenticationClasses;
using MVCAuthentication.DesignPatterns.SingletonPattern;
using MVCAuthentication.Models.Context;
using MVCAuthentication.Models.Entities;
using MVCAuthentication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAuthentication.Controllers
{
    //In this MVC project, an authentication process is simulated. "username:admin, pw:admin" will assign Admin role to the user and open an admin session, "username:member, pw:member" will simulate logging in as a standard member, and all other login attempts will return a "user not found" error. Note that, one can only reach the admin panel( /Home/Panel in this case) through login panel. User won't be able to reach this page without an admin session, which is only possible through login panel. Singleton pattern is used to ensure database is only instanced once.
    public class HomeController : Controller
    {
        MyContext _db;

        public HomeController()
        {
            _db = DBTool.DBInstance;
        }


        [AdminAuthentication]
        public ActionResult Panel()
        {
            HomeVM hvm = new HomeVM
            {
                AppUsers = _db.AppUsers.ToList()
            };
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AppUser appuser)
        {
            AppUser ap = _db.AppUsers.FirstOrDefault(x => x.UserName == appuser.UserName && x.Password == appuser.Password);

            if (ap != null)
            {
                if (ap.Role == Models.Enums.UserRole.Admin)
                {
                    Session["admin"] = ap;
                    return RedirectToAction("Panel");
                }

                ViewBag.Message = "Logged in as standard member";
                return View();
            }
            ViewBag.Message = "User not found";
            return View();
           
        }
    }
}