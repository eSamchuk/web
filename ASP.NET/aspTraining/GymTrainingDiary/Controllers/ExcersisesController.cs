using GymTrainingDiary.Filters;
using GymTrainingDiary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GymTrainingDiary.Model;

namespace GymTrainingDiary.Controllers
{
    //[Authorize]
    [Log]
    public class ExcersisesController : Controller
    {
        // GET: Excersise
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewTrainings()
        {
            //ExcersisesModel model = new ExcersisesModel();
            //model.Excersises = new List<Training>(DbDataAccess.GetTrainings());

            return View(new List<Training>(DbDataAccess.GetTrainings()));
        }


        //[Authorize]
        public ActionResult Search(string id)
        {
            //throw new InvalidOperationException("Ooops!");
            //return Content(id);
            //return RedirectToAction("Index");
            return File("D:\\StabPhotos\\Male.jpg", "image/jpg");
            //return this.Json(new { Name = exName, Type = "Base excersise" }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Detailes()
        {
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }
        public ActionResult Delete()
        {
            return View();
        }

    }
}