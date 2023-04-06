using ITIDBASS1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITIDBASS1.Controllers
{
    public class StudentController : Controller
    {
        ITIEntities context = new ITIEntities();
        // GET: Student
        public ActionResult Index()
        {
            ViewBag.Dept = context.Departments.ToList();

            return View(context.Students.ToList());
        }
        [HttpPost]
        public ActionResult Index(int id)
        {
            var std = context.Students.Where(e => e.Dept_Id == id);
            ViewBag.Dept = context.Departments.ToList();
            return View(std);
        }
        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            Student s = context.Students.Find(id);
            return View(s);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            ViewBag.Dept = context.Departments.ToList();
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Student student = new Student();
                student.St_Id = int.Parse(collection["St_Id"]);
                student.St_Lname = collection["St_Lname"];
                student.St_Fname = collection["St_Fname"];
                student.St_Address = collection["St_Address"];
                student.St_Age = int.Parse(collection["St_Age"]);
                student.Dept_Id = int.Parse(collection["Dept_Id"]);

                context.Students.Add(student);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            Student std = context.Students.Find(id);
            ViewBag.Dept = context.Departments.ToList();
            return View(std);
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                Student s = context.Students.Find(id);

                s.St_Lname = collection["St_Lname"];
                s.St_Fname = collection["St_Fname"];
                s.St_Address = collection["St_Address"];
                s.St_Age = int.Parse(collection["St_Age"]);
                s.Dept_Id = int.Parse(collection["Dept_Id"]);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            Student s = context.Students.Find(id);
            context.Students.Remove(s);
            return View();
        }

        // POST: Student/Delete/5
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
