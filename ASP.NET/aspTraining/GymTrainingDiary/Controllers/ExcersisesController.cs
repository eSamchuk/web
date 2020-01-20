using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GymTrainingDiary.Controllers
{
    //[Authorize]
    public class ExcersisesController : Controller
    {
        // GET: Excersise
        public ActionResult Index()
        {
            return RedirectToAction("Search", new { id = "Prisyad" });
        }

        //[Authorize]
        public ActionResult Search(string id)
        {
            throw new InvalidOperationException("Ooops!");
            //return Content(id);
            //return RedirectToAction("Index");
            //return File("D:\\StabPhotos\\Male.jpg", "image/jpg");
            //return this.Json(new { Name = exName, Type = "Base excersise" }, JsonRequestBehavior.AllowGet);
        }
    }
}