using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyFood.Entities
{
    public class Link_Meal_Ingredient
    {
        [Key]
        public Guid LMI_LMIId { get; set; }
        [Required]
        public decimal LMI_Portion { get; set; }

        [ForeignKey("Day")]
        public Guid LMI_DayId { get; set; }
        public Day Day { get; set; }

        [ForeignKey("Ingredient")]
        public Guid LMI_IngId { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
