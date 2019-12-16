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
    [Route("api/meals")]
    public class MealController : ControllerBase
    {
        private readonly IMealRepository _mealRepository;
        private readonly IMapper _mapper;

        public MealController(IMealRepository mealRepository, IMapper mapper)
        {
            _mealRepository = mealRepository ??
                throw new ArgumentNullException(nameof(mealRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet()]
        public ActionResult<IEnumerable<MealDto>> GetAllMeals()
        {
            var mealsFromRepo = _mealRepository.GetAllMeals();

            return Ok(_mapper.Map<IEnumerable<MealDto>>(mealsFromRepo));
        }

        [HttpGet("{mealId}")]
        public ActionResult<MealDto> GetMeal(Guid mealId)
        {
            var mealFromRepo = _mealRepository.GetMeal(mealId);

            if (mealFromRepo == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<MealDto>(mealFromRepo));
        }
    }
}
