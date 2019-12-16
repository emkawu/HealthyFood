using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HealthyFood.Entities
{
    public class Ingredient
    {
        [Key]
        public Guid Ing_IngId { get; set; }
        [Required]
        [StringLength(50)]
        public string Ing_Name { get; set; }
        public string Ing_Description { get; set; }
        public decimal Ing_Protein { get; set; }
        public decimal Ing_Carb { get; set; }
        public decimal Ing_Fat { get; set; }
        public decimal Ing_Calories { get; set; }

        [ForeignKey("Category")]
        public Guid Ing_CatId { get; set; }
        public Category Category { get; set; }
    }
}
