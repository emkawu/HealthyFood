using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthyFood.Entities;
using HealthyFood.Models;

namespace HealthyFood.Profiles
{
    public class DayProfile : Profile
    {
        public DayProfile()
        {
            CreateMap<Day, DayDto>();
        }
    }
}
