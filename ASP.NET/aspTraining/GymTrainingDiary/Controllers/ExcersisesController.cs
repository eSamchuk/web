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

        public ActionResult ViewTrainings(DateTime? dateFromSearch = null)
        {
            return View(new List<Training>(DbDataAccess.GetTrainings().Where(x => dateFromSearch == null || x.TrainingDate >= dateFromSearch)));
        }

        public ActionResult Create()
        {
            var nModel = new NewTrainigModel();
            nModel.Users = new List<User>(DbDataAccess.GetUsers());
            nModel.NewTraining.TrainingDate = DateTime.Today;

            return View(nModel);
        }

        [HttpPost]
        public ActionResult Create(Training tr)
        {
            DbDataAccess.SaveOrUpdateTraining(tr);
            return RedirectToAction("ViewTrainings");
        }


        public ActionResult Details(decimal Id)
        {
            return View(DbDataAccess.GetTrainingById(Id));
        }

        public ActionResult Edit(decimal Id)
        {
            return View(DbDataAccess.GetTrainingById(Id));
        }

        [HttpPost]
        public ActionResult Edit(decimal Id, FormCollection col)
        {
            var t = DbDataAccess.GetTrainingById(Id);

            if (TryUpdateModel(t))
            {
                DbDataAccess.SaveOrUpdateTraining(t);
                return RedirectToAction("ViewTrainings");

            }
            return View(t);
        }

        
        public ActionResult Delete(decimal Id)
        {
            try
            {
                DbDataAccess.DeleteTraining(Id);
            }
            catch (Exception e)
            {

            }

            return RedirectToAction("ViewTrainings");
        }

    }
}