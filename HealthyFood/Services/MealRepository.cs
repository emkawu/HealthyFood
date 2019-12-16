using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthyFood.Data;
using HealthyFood.Entities;

namespace HealthyFood.Services
{
    public class MealRepository : IMealRepository
    {
        private readonly ApplicationDbContext _context;

        public MealRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<Meal> GetAllMeals()
        {
            return _context.Meals
                .OrderBy(m => m.Mea_MeaId).ToList();
        }

        public Meal GetMeal(Guid mea_MeaId)
        {
            if (mea_MeaId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(mea_MeaId));
            }

            return _context.Meals
              .Where(m => m.Mea_MeaId == mea_MeaId).FirstOrDefault();
        }
    }
}
