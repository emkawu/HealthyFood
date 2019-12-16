using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyFood.Entities
{
    public class Meal
    {
        [Key]
        public Guid Mea_MeaId { get; set; }
        [Required]
        [StringLength(50)]
        public string Mea_Name { get; set; }
        public string Mea_Desc { get; set; }
    }
}
