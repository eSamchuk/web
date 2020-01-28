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

        [Display(Name = "Password")]
        public string PasswordHash { get; set; }


        [Display(Name = "Is active user")]
        public bool IsActive { get; set; }

        [Display(Name = "Date of registration")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime RegistrationDate { get; set; }

        [Display(Name = "Last login date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? LastLoginDate { get; set; }


        public byte[] Photo { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? BirthDate { get; set; }

        public virtual List<UserPermisssion> Permissions { get; set; }

        public virtual List<Training> Trainings { get; set; }


    }
}
