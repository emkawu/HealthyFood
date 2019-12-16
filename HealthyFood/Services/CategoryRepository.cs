using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthyFood.Data;
using HealthyFood.Entities;

namespace HealthyFood.Services
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories
                .OrderBy(c => c.Cat_Name).ToList();
        }

        public Category GetCategory(Guid cat_CatId)
        {
            if (cat_CatId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(cat_CatId));
            }

            return _context.Categories
              .Where(c => c.Cat_CatId == cat_CatId).FirstOrDefault();
        }
    }
}
