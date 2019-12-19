using AutoMapper;
using HealthyFood.Models;
using HealthyFood.Services;
using Microsoft.AspNetCore.Identity;
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
        private SignInManager<ApplicationUser> _signManager;
        private UserManager<ApplicationUser> _userManager;
        private readonly IMapper _mapper;

        public UserController(IUserRepository userRepository, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signManager, IMapper mapper)
        {
            _userRepository = userRepository ??
                throw new ArgumentNullException(nameof(userRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
            _userManager = userManager ??
                throw new ArgumentNullException(nameof(userManager));
            _signManager = signManager ??
                throw new ArgumentNullException(nameof(signManager));
        }

        [HttpGet]
        public ActionResult<IEnumerable<ApplicationUser>> GetAllUsers()
        {
            //var usersFromRepo = _userRepository.GetAllUsersAsync();
            var usersFromRepo = _userRepository.GetAllUsers();

            return Ok(usersFromRepo);
        }

        [HttpGet("{userId}", Name = "GetUser")]
        public ActionResult<IEnumerable<ApplicationUser>> GetAllUsers(string userId)
        {
            var userFromRepo = _userRepository.GetUser(userId);
            if(userFromRepo == null)
            {
                return NotFound();
            }
                
            return Ok(_mapper.Map<ApplicationUserDto>(userFromRepo));
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(ApplicationUserCreateDto user)
        {
            var userEntity = _mapper.Map<ApplicationUser>(user);
            var result = await _userManager.CreateAsync(userEntity, user.Password);

            if (result.Succeeded)
            {
                //await _signManager.SignInAsync(user, false);
                await _userManager.AddToRoleAsync(userEntity, Helpers.UserRoles.User);

                var userToReturn = _mapper.Map<ApplicationUserDto>(userEntity);
                return CreatedAtRoute("GetUser",
                    new { userId = userToReturn.Id },
                    userToReturn);
            }
            else
            {
                return NotFound();
            }
        }

    }
}
