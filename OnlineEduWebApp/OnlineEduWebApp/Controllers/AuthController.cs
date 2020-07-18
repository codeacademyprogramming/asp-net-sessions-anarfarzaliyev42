using OnlineEduWebApp.Contexts;
using OnlineEduWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace OnlineEduWebApp.Controllers
{
    public class AuthController : Controller
    {
        readonly UserContext db = new UserContext();
        
        public ActionResult Index()
        {
            return View("SignIn");
        }
        [HttpPost]
        public ActionResult SignIn(string username,string password)
        {

           
            User _user = db.Users.FirstOrDefault(x => x.Username == username);

            bool isVerified = Crypto.VerifyHashedPassword(_user.Password, password);
            if (isVerified)
            {
                int userId = _user.Id;
                Session["login"] = true;
                Session["username"] = username;
                Session["userid"] = userId;
                return RedirectToAction("Index", "Home");
            }
            
            ModelState.AddModelError("", "Username or password not correct");
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Register(User user)
        {
            bool isUsernameExists = db.Users.Any(x => x.Username == user.Username);
            if (isUsernameExists)
            {
                ModelState.AddModelError("Username", "This username already exists");
               
            }
            bool isEmailExists = db.Users.Any(x => x.Email == user.Email);
            if (isEmailExists)
            {
                ModelState.AddModelError("Email", "This email address already used");
            
            }
            bool isCheckboxChecked = user.IsAgree;
            if (!isCheckboxChecked)
            {
                ModelState.AddModelError("IsAgree", "Please agree with rules");
            }
            if (ModelState.IsValid)
            {

                string hashedPassword = Crypto.HashPassword(user.Password);
                user.Password = hashedPassword;
                user.ConfirmPassword = hashedPassword;
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("index");
            }
            
            return View(user);
        }

        public ActionResult LogOut()
        {

            Session.Clear();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {

            if (disposing)
            {
                db.Dispose();
            }

            base.Dispose(disposing);
        }

    }
}