using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthyFood.Data;
using HealthyFood.Entities;

namespace HealthyFood.Services
{
    public class IngredientRepository : IIngredientRepository
    {
        private readonly ApplicationDbContext _context;

        public IngredientRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<Ingredient> GetAllIngredients()
        {
            return _context.Ingredients.ToList();
        }

        public Ingredient GetIngredient(Guid ing_IngId)
        {
            if(ing_IngId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(ing_IngId));
            }

            return _context.Ingredients
                .Where(i => i.Ing_IngId == ing_IngId).FirstOrDefault();
        }
    }
}
