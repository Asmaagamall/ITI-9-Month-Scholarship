using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_CoreIdentity.Models;
using MVC_CoreIdentity.RepoServices;

namespace MVC_CoreIdentity.Controllers
{
    public class CourseController : Controller
    {
        public ICourse Course { get; }
        public ITraineeRepo TraineeRepo { get; }

        public CourseController(ICourse course , ITraineeRepo traineeRepo)
        {
            Course = course;
            TraineeRepo = traineeRepo;
        }
        // GET: CourseController
        public ActionResult Index()
        {
            return View(Course.GetAll());
        }

        // GET: CourseController/Details/5
        public ActionResult Details(int id)
        {
            return View(Course.GetDetails(id));
        }

        // GET: CourseController/Create
        public ActionResult Create()
        {
            ViewBag.Trainee = TraineeRepo.GetAll();
            return View();
        }

        // POST: CourseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Course course)
        {
            try
            {
                Course.Insert(course);
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
            ViewBag.Trainee = TraineeRepo.GetAll();
            return View(Course.GetDetails(id));
        }

        // POST: CourseController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Course course)
        {
            try
            {
                Course.UpdateCrs(id,course);
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
            return View(Course.GetDetails(id));
        }

        // POST: CourseController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                Course.DeleteCrs(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
