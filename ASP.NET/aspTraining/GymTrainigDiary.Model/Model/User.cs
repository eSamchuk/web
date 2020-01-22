using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTrainingDiary.Model
{
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        public string DisplayName { get; set; }

        public string Login { get; set; }

        public string PasswordHash { get; set; }

        public byte[] Photo { get; set; }

        public virtual List<UserPermisssion> Permissions { get; set; }

        public virtual List<Training> Trainings { get; set; }


    }
}
