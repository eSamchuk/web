using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace GymTrainingDiary.Model
{
    public static partial class DbDataAccess
    {

        public static IEnumerable<User> GetUsers()
        {
            using (var db = new GymTrainingContext())
            {
                return db.Users
                .Where(x => x.IsActive)
                .ToList();
            }
        }

        public static IEnumerable<Excersise> GetExcersises()
        {
            using (var db = new GymTrainingContext())
            {
                return db.Excersises
                .Include(x => x.ExcersiseType)
                .Include(x => x.RepeatSets.Select(y => y.WeightUnit))
                .ToList();
            }
        }

        public static IEnumerable<Training> GetTrainings()
        {
            using (var db = new GymTrainingContext())
            {
                return db.Trainings
                .Include(x => x.User)
                .ToList();
            }
        }

        public static Training GetTrainingById(decimal Id)
        {
            using (var db = new GymTrainingContext())
            {
                return db.Trainings
               .Include(x => x.User)
               .Include(x => x.Excersises)
               .FirstOrDefault(x => x.Id == Id);
            }
        }

        public static void DeleteTraining(decimal id)
        {
            var context = new GymTrainingContext();

            var remove = context.Trainings.Single(x => x.Id == id);

            context.Trainings.Remove(remove);
            context.SaveChanges();
        }
    }
}
