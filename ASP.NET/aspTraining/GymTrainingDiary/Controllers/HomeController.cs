using GymTrainingDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GymTrainingDiary.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"];

            ViewBag.Message = $"{controller}::{action} {id}";

            return View();
        }

        public ActionResult About()
        {
            var model = new AboutModel();

            model.DeveloperName = "Evhen Samchuk";
            model.DeveloperPhone = "0664656827";
            model.DeveloperEmail = "evhen.samchuk@gmail.com";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}