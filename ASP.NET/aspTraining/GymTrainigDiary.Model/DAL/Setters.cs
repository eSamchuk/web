using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTrainingDiary.Model
{
    public static partial class DbDataAccess
    {
        public static void SaveOrUpdateTraining(Training val)
        {
            var context = new GymTrainingContext();
            context.Entry(val).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }



    }
}
