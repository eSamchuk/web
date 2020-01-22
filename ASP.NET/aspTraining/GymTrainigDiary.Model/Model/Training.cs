using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymTrainingDiary.Model
{
    public class Training
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        public decimal UserId { get; set; }
        public virtual User User { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime FinishTime { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public TimeSpan TrainingDuration { get; set; }

        public virtual List<Excersise> Excersises { get; set; }


    }
}
