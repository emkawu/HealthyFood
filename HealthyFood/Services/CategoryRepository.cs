using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthyFood.Data;
using HealthyFood.Entities;

namespace HealthyFood.Services
{
    public class CategoryRepository : ICategoryRepository, IDisposable
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

        public void AddCategory(Category category)
        {
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category));
            }

            category.Cat_CatId = Guid.NewGuid();

            _context.Categories.Add(category);
        }


        public void UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(Category category)
        {
            throw new NotImplementedException();
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
