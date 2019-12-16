using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyFood.Models
{
    public class CategoryDto
    {
        public Guid Cat_CatId { get; set; }
        public string Cat_Name { get; set; }
        public string Cat_Desc { get; set; }
    }
}
