using HealthyFood.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyFood.Services
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
        Category GetCategory(Guid cat_CatId);
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
        bool Save();
    }
}
