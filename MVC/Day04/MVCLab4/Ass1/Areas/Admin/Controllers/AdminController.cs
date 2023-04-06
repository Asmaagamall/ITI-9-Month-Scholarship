using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ass1.Areas.Admin.Controllers
{
    [HandleError(View ="MyPageError")]
    public class AdminController : Controller
    {
        // GET: Admin/Admin
        public ActionResult Index()
        {
            throw new Exception();
            //return View();
        }

        public ActionResult action()
        {
            int X = 2;
            int Y = 0;
            int RESULT = X / Y;
            return View(RESULT);
        }
    }
}