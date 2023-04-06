using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_CoreIdentity.Models;
using MVC_CoreIdentity.RepoServices;

namespace MVC_CoreIdentity.Controllers
{
    public class TraineeController : Controller
    {
        public ITraineeRepo TraineeRepo { get; }
        public ITrackRepo TrackRepo { get; }

        public TraineeController(ITraineeRepo traineeRepo , ITrackRepo trackRepo)
        {
            TraineeRepo = traineeRepo;
            TrackRepo = trackRepo;
        }
        // GET: TraineeController
        public ActionResult Index()
        {
            return View(TraineeRepo.GetAll());
        }

        // GET: TraineeController/Details/5
        public ActionResult Details(int id)
        {
            return View(TraineeRepo.GetDetails(id));
        }

        // GET: TraineeController/Create
        public ActionResult Create()
        {
            ViewBag.Track = TrackRepo.GetAll();
            return View();
        }

        // POST: TraineeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Trainee trainee)
        {
            try
            {
                TraineeRepo.Insert(trainee);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TraineeController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Track = TrackRepo.GetAll();
            return View(TraineeRepo.GetDetails(id));
        }

        // POST: TraineeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Trainee trainee)
        {
            try
            {
                TraineeRepo.UpdateTrainee(id, trainee);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TraineeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TraineeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Trainee trainee)
        {
            try
            {
                TraineeRepo.DeleteTrainee(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
