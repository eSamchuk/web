using GymTrainingDiary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GymTrainingDiary.Models
{
    public class NewTrainigModel
    {
        public Training NewTraining { get; set; } = new Training();

        public List<User> Users { get; set; } = new List<User>();

        public IEnumerable<SelectListItem> Items
        {
            get { return new SelectList(this.Users, "Id", "DisplayName"); }
        }

        public decimal SelectedUserId { get; set; }

    }
}