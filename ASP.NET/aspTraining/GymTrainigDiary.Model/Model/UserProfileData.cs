using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GymTrainingDiary.Model
{
    public class UserProfileData
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        public byte[] Photo { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime? BirthDate { get; set; }

    }
}
