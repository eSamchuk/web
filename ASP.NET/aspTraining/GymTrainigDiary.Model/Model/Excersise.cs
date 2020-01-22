using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymTrainingDiary.Model
{
    public class Excersise
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }


        public decimal ExcersiseTypeId { get; set; }
        public virtual PARAM ExcersiseType { get; set; }

        public List<RepeatSet> RepeatSets { get; set; }




    }
}
