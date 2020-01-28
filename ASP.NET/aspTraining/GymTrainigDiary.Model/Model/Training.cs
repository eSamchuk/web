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

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date of training")]
        public DateTime TrainingDate { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = @"{0:hh\:mm}",  ApplyFormatInEditMode = true)]
        [Display(Name = "Training stared")]
        public TimeSpan TrainingStart { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = @"{0:hh\:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Training finished")]
        public TimeSpan TrainingFinish { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Display(Name = "Duration of training")]
        public TimeSpan TrainingDuration { get; set; }

        public virtual List<Excersise> Excersises { get; set; }


    }
}
