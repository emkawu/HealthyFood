using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthyFood.Data;
using HealthyFood.Entities;

namespace HealthyFood.Services
{
    public class IngredientRepository : IIngredientRepository, IDisposable
    {
        private readonly ApplicationDbContext _context;

        public IngredientRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void AddIngredient(Ingredient ingredient)
        {
            if (ingredient == null)
            {
                throw new ArgumentNullException(nameof(ingredient));
            }

            // the repository fills the id (instead of using identity columns)
            ingredient.Ing_IngId = Guid.NewGuid();

            _context.Ingredients.Add(ingredient);
        }

        public void UpdateIngredient(Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        public void DeleteIngredient(Ingredient ingredient)
        {
            throw new NotImplementedException();
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

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose resources when needed
            }
        }
    }
}
