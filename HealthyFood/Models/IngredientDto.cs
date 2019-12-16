using HealthyFood.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyFood.Models
{
    public class IngredientDto
    {
        public Guid Ing_IngId { get; set; }
        public string Ing_Name { get; set; }
        public string Ing_Description { get; set; }
        public decimal Ing_Protein { get; set; }
        public decimal Ing_Carb { get; set; }
        public decimal Ing_Fat { get; set; }
        public decimal Ing_Calories { get; set; }
        public Category Category { get; set; }
    }
}
