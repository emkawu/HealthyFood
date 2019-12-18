using AutoMapper;
using HealthyFood.Models;
using HealthyFood.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyFood.Controllers
{
    [ApiController]
    [Route("api/categories")]
    public class CategoryController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public ActionResult<IEnumerable<CategoryDto>> GetAllCategories()
        {
            var categoriesFromRepo = _categoryRepository.GetAllCategories();

            return Ok(_mapper.Map<IEnumerable<CategoryDto>>(categoriesFromRepo));
        }

        [HttpGet("{categoryId}", Name = "GetCategory")]
        public ActionResult<CategoryDto> GetCategory(Guid categoryId)
        {
            var categoryFromRepo = _categoryRepository.GetCategory(categoryId);

            if (categoryFromRepo == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<CategoryDto>(categoryFromRepo));
        }

        [HttpPost]
        public ActionResult<CategoryDto> CreateCategory(CategoryCreateDto category)
        {
            var categoryEntity = _mapper.Map<Entities.Category>(category);
            _categoryRepository.AddCategory(categoryEntity);
            _categoryRepository.Save();

            var categoryToReturn = _mapper.Map<CategoryDto>(categoryEntity);
            return CreatedAtRoute("GetCategory",
                new { categoryId = categoryToReturn.Cat_CatId },
                categoryToReturn);
        }
    }
}
