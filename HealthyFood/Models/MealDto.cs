using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyFood.Models
{
    public class MealDto
    {
        public Guid Mea_MeaId { get; set; }
        public string Mea_Name { get; set; }
        public string Mea_Desc { get; set; }
    }
}
