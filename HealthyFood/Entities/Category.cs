using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyFood.Entities
{
    public class Category
    {
        [Key]
        public Guid Cat_CatId { get; set; }
        [Required]
        [StringLength(50)]
        public string Cat_Name { get; set; }
        public string Cat_Desc { get; set; }
    }
}
