using IdentityWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace IdentityWebApp.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        MainDbContext context = new MainDbContext();
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                context.users.Add(user);
                context.SaveChanges();

                var UsrIdentity = new ClaimsIdentity(new List<Claim>
                {
                    new Claim(ClaimTypes.Name , user.Name),
                    new Claim(ClaimTypes.Email , user.Email),
                    new Claim(ClaimTypes.Country , user.Country),
                    new Claim(ClaimTypes.MobilePhone , user.PhoneNumber),
                    new Claim("Password" , user.Password),
                    new Claim("Job" , user.Job),
                }
                ,"AppCookie");

                Request.GetOwinContext().Authentication.SignIn(UsrIdentity);
                return RedirectToAction("Index" , "Home");
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            var loggedUser = context.users.FirstOrDefault(e=>e.Email ==  user.Email && e.Password == user.Password);
            if(loggedUser != null)
            {
                var LoginIdentity = new ClaimsIdentity(new List<Claim>
                {
                    new Claim(ClaimTypes.Email , user.Email),
                    new Claim("Password" , user.Password),
                }
                , "AppCookie");

                Request.GetOwinContext().Authentication.SignIn(LoginIdentity);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("Name","Email or Password is not correct");
                return View();
            }
        }

        public ActionResult Logout()
        {
            Request.GetOwinContext().Authentication.SignOut("AppCookie");
            return RedirectToAction("Login");
        }
    }
}