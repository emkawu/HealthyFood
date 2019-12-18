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
    [Route("api/ingredients")]
    public class IngredientController : ControllerBase
    {
        private readonly IIngredientRepository _ingredientRepository;
        private readonly IMapper _mapper;

        public IngredientController(IIngredientRepository ingredientRepository, IMapper mapper)
        {
            _ingredientRepository = ingredientRepository ??
                throw new ArgumentNullException(nameof(ingredientRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet()]
        public ActionResult<IEnumerable<IngredientDto>> GetAllIngredients()
        {
            var ingredientsFromRepo = _ingredientRepository.GetAllIngredients();

            return Ok(_mapper.Map<IEnumerable<IngredientDto>>(ingredientsFromRepo));
        }

        [HttpGet("{ingId}", Name = "GetIngredient")]
        public ActionResult<IngredientDto> GetIngredient(Guid ingId)
        {
            var ingredientFromRepo = _ingredientRepository.GetIngredient(ingId);

            if (ingredientFromRepo == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<IngredientDto>(ingredientFromRepo));
        }

        [HttpPost]
        public ActionResult<IngredientDto> CreateIngredient(IngredientCreateDto ingredient)
        {
            var ingredientEntity = _mapper.Map<Entities.Ingredient>(ingredient);
            _ingredientRepository.AddIngredient(ingredientEntity);
            _ingredientRepository.Save();

            var ingredientToReturn = _mapper.Map<IngredientDto>(ingredientEntity);
            return CreatedAtRoute("GetIngredient",
                new { ingId = ingredientToReturn.Ing_IngId },
                ingredientToReturn);
        }
    }
}
