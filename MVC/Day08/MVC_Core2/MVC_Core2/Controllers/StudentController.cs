using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Core2.Model;
using System.Linq;

namespace MVC_Core2.Controllers
{
    public class StudentController : Controller
    {
        public ModelDbContext Context { get; }

        public StudentController(ModelDbContext context)
        {
            Context = context;
        }
        // GET: StudentController
        public ActionResult Index()
        {
            return View(Context.Students.ToList());
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int? id)
        {
            var std = Context.Students.FirstOrDefault(p=>p.Id == id);
            return View(std);
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student std)
        {
            try
            {
                Context.Students.Add(std);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int? id)
        {
            var std = Context.Students.Find(id);
            return View(std);
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Student std)
        {
            try
            {
                Context.Students.Update(std);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int? id)
        {
            var std = Context.Students.Find(id);
            return View(std);
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int? id , Student st)
        {
            try
            {
                var std = Context.Students.Find(id);
                Context.Students.Remove(std);
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
