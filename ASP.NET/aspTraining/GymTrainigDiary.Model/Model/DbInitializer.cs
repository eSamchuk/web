using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTrainingDiary.Model
{
    public class DbInitializer : CreateDatabaseIfNotExists<GymTrainingContext>
    {
        protected override void Seed(GymTrainingContext context)
        {
            base.Seed(context);
        }

    }
}
