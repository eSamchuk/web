using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTrainingDiary.Model
{
    public class RepeatSet
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        public int RepeatCount { get; set; }

        public decimal Weight { get; set; }

        public decimal WeightUnitId { get; set; }
        public PARAM WeightUnit { get; set; }


    }
}
