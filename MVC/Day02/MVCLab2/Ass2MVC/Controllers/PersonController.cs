using Ass2MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ass2MVC.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Add()
        {
            return View();
        }
        public ActionResult Display(int id , string name , int img)
        {
            Person person = new Person();
            person.Id = id;
            person.Name = name;
            person.Image = img;

            ViewBag.prs = person;

            return View();
        }
    }
}