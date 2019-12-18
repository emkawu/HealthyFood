using HealthyFood.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyFood.Services
{
    public interface IIngredientRepository
    {
        IEnumerable<Ingredient> GetAllIngredients();
        Ingredient GetIngredient(Guid ing_IngId);
        void AddIngredient(Ingredient ingredient);
        void UpdateIngredient(Ingredient ingredient);
        void DeleteIngredient(Ingredient ingredient);
        bool Save();
    }
}
