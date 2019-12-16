using HealthyFood.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyFood.Services
{
    public interface IMealRepository
    {
        IEnumerable<Meal> GetAllMeals();
        Meal GetMeal(Guid mea_MeaId);
    }
}
