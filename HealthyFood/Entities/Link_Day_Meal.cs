using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyFood.Entities
{
    public class Link_Day_Meal
    {
        [Key]
        public Guid LDM_LDMId { get; set; }

        [ForeignKey("Day")]
        public Guid LDM_DayId { get; set; }
        public Day Day { get; set; }

        [ForeignKey("Meal")]
        public Guid LDM_MeaId { get; set; }
        public Meal Meal { get; set; }
    }
}
