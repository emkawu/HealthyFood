using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyFood.Models
{
    public class ApplicationUserDto
    {
        public Guid Id { get; set; }
        [StringLength(256)]
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserDesc { get; set; }
        public int UserAge { get; set; }
    }
}
