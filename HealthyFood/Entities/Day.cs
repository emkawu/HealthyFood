using HealthyFood.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyFood.Entities
{
    public class Day
    {
        [Key]
        public Guid Day_DayId { get; set; }
        [Required]
        [StringLength(50)]
        public string Day_Name { get; set; }
        public string Day_Desc { get; set; }

        [ForeignKey("ApplicationUser")]
        public string Day_ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
