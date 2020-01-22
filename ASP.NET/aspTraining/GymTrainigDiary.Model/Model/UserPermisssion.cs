using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymTrainingDiary.Model
{
    public class UserPermisssion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id { get; set; }

        public decimal PermissionId { get; set; }
        public virtual Permission Permission { get; set; }

        public decimal UserId { get; set; }
        public virtual User User { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime InsertTime { get; set; }

    }
}
