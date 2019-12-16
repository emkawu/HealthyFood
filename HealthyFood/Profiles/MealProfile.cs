using AutoMapper;
using HealthyFood.Entities;
using HealthyFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyFood.Profiles
{
    public class MealProfile : Profile
    {
        public MealProfile()
        {
            CreateMap<Meal, MealDto>();
        }
    }
}
