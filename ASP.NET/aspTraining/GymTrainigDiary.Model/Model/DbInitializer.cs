using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
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

            var x = new StringBuilder();
            x.AppendLine("create function dbo.CalculateTimeDiffAsTimeSpan (@timeStart time, @timeFinish time)");
            x.AppendLine("returns time");
            x.AppendLine("as");
            x.AppendLine("Begin");
            x.AppendLine(@"return CONVERT(varchar(5), DATEADD(mi, DATEDIFF(mi, @timeStart, @timeFinish), 0), 114) ");
            x.AppendLine(@"End;");

            context.Database.ExecuteSqlCommand(x.ToString());

            var drop = "alter table dbo.Trainings drop column TrainingDuration";
            context.Database.ExecuteSqlCommand(drop);

            var alter = "alter table dbo.Trainings add TrainingDuration as dbo.CalculateTimeDiffAsTimeSpan(TrainingStart, TrainingFinish)";
            context.Database.ExecuteSqlCommand(alter);
                       
            var u = new User
            {
                DisplayName = "Ramieru",
                IsActive = true,
                RegistrationDate = DateTime.Today,
                LastLoginDate = null,
                Login = "ramieru5th",
                PasswordHash = "1",
                BirthDate = new DateTime(1991, 08, 15),
                Name = "Evhen",
                Surname = "Samchuk",
                Photo = File.ReadAllBytes("D:\\StabPhotos\\Male.jpg")
            };

            var u2 = new User
            {
                DisplayName = "Inova_M",
                IsActive = true,
                RegistrationDate = DateTime.Today,
                LastLoginDate = null,
                Login = "mIonova",
                PasswordHash = "12",
                BirthDate = new DateTime(1984, 03, 27),
                Name = "Maria",
                Surname = "Ionova",
                Photo = File.ReadAllBytes("D:\\StabPhotos\\Female.jpg")
            };

            context.Users.Add(u);
            context.Users.Add(u2);
            context.SaveChanges();

            var tr = new Training
            {
                TrainingDate = DateTime.Today,
                TrainingStart = new TimeSpan(12, 0, 0),
                TrainingFinish = new TimeSpan(15, 0, 0),
                UserId = u.Id
            };

            var tr2 = new Training
            {
                TrainingDate = DateTime.Today,
                TrainingStart = new TimeSpan(17, 0, 0),
                TrainingFinish = new TimeSpan(19, 30, 0),
                UserId = u.Id
            };

            var tr3 = new Training
            {
                TrainingDate = DateTime.Today.AddDays(-1),
                TrainingStart = new TimeSpan(19, 0, 0),
                TrainingFinish = new TimeSpan(20, 15, 0),
                UserId = u2.Id
            };

            context.Trainings.Add(tr);
            context.Trainings.Add(tr2);
            context.Trainings.Add(tr3);

            context.SaveChanges();






        }

    }
}
