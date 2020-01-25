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
            return new GymTrainingContext().Users.ToList();
        }

        public static IEnumerable<Excersise> GetExcersises()
        {
            return new GymTrainingContext().Excersises
                .Include(x => x.ExcersiseType)
                .Include(x => x.RepeatSets.Select(y => y.WeightUnit))
                .ToList();
        }

        public static IEnumerable<Training> GetTrainings()
        {
            return new GymTrainingContext().Trainings
                .Include(x => x.User)
                .ToList();
        }

        public static Training GetTrainingById(decimal Id)
        {
            return new GymTrainingContext().Trainings
               .Include(x => x.User)
               .Include(x => x.Excersises)
               .FirstOrDefault(x => x.Id == Id);
        }



    }
}
