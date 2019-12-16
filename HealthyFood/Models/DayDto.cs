using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyFood.Models
{
    public class DayDto
    {
        public Guid Day_DayId { get; set; }
        public string Day_Name { get; set; }
        public string Day_Desc { get; set; }
    }
}
