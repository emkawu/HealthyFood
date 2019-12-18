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
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository ??
                throw new ArgumentNullException(nameof(userRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public ActionResult<IEnumerable<ApplicationUser>> GetAllUsers()
        {
            //var usersFromRepo = _userRepository.GetAllUsersAsync();
            var usersFromRepo = _userRepository.GetAllUsers();

            return Ok(usersFromRepo);
        }

        [HttpGet("{userId}")]
        public ActionResult<IEnumerable<ApplicationUser>> GetAllUsers(string userId)
        {
            var userFromRepo = _userRepository.GetUser(userId);
            return Ok(_mapper.Map<ApplicationUserDto>(userFromRepo));
        }

    }
}
