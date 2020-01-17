using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GymTrainingDiary.Controllers
{
    public class ExcersisesController : Controller
    {
        // GET: Excersise
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search(string name)
        {
            return Content(name);
        }
    }
}