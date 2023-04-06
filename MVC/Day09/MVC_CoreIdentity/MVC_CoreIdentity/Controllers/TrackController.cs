using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_CoreIdentity.Models;
using MVC_CoreIdentity.RepoServices;

namespace MVC_CoreIdentity.Controllers
{
    public class TrackController : Controller
    {
        public ITrackRepo TrackRepo { get; }

        public TrackController(ITrackRepo trackRepo)
        {
            TrackRepo = trackRepo;
        }
        // GET: TrackController
        public ActionResult Index()
        {
            return View(TrackRepo.GetAll());
        }

        // GET: TrackController/Details/5
        public ActionResult Details(int id)
        {
            return View(TrackRepo.GetDetails(id));
        }

        // GET: TrackController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TrackController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Track track)
        {
            try
            {
                TrackRepo.Insert(track);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TrackController/Edit/5
        public ActionResult Edit(int id)
        {
            
            return View(TrackRepo.GetDetails(id));
        }

        // POST: TrackController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Track track)
        {
            try
            {

                TrackRepo.UpdateTrack(id, track);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TrackController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TrackController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                TrackRepo.DeleteTrack(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
