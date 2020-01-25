using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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


        [Display(Name = "User name")]
        public string DisplayName { get; set; }

        public string Login { get; set; }

        public string PasswordHash { get; set; }

        public bool IsActive { get; set; }

        public DateTime RegistrationDate { get; set; }

        public DateTime LastLoginDate { get; set; }




        public byte[] Photo { get; set; }

        public virtual List<UserPermisssion> Permissions { get; set; }

        public virtual List<Training> Trainings { get; set; }


    }
}
