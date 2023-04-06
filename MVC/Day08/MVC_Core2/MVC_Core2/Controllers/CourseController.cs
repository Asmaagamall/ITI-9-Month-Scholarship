using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Core2.Model;
using System.Linq;
using System.Runtime.Intrinsics.Arm;

namespace MVC_Core2.Controllers
{
    public class CourseController : Controller
    {
        public ModelDbContext Context { get; }

        public CourseController(ModelDbContext context)
        {
            Context = context;
        }
        // GET: CourseController
        public ActionResult Index()
        {
            return View(Context.Courses.ToList());
        }

        // GET: CourseController/Details/5
        public ActionResult Details(int? id)
        {
            var crs = Context.Courses.FirstOrDefault(P=>P.Id == id);
            return View(crs);
        }

        // GET: CourseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Course crs)
        {
            try
            {
                Context.Courses.Add(crs);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseController/Edit/5
        public ActionResult Edit(int id)
        {
            var crs = Context.Courses.Find(id);
            return View(crs);
        }

        // POST: CourseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Course crs)
        {
            try
            {
                Context.Courses.Update(crs);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CourseController/Delete/5
        public ActionResult Delete(int id)
        {
            var crs = Context.Courses.Find(id); 
            return View();
        }

        // POST: CourseController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Course cs)
        {
            try
            {
                var crs = Context.Courses.Find(id);
                Context.Courses.Remove(crs); 
                Context.SaveChanges();  
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
