using GymTrainingDiary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GymTrainingDiary.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            return View(DbDataAccess.GetUsers());
        }

        public ActionResult Edit(decimal Id)
        {
            return View();
        }

        public ActionResult Delete(decimal Id)
        {
            return View();
        }

        public ActionResult Details(decimal Id)
        {
            return View();
        }

    }
}