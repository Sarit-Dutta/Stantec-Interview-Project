using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using TeleHealth_API.Models;
using TeleHealth_API.Services;

namespace TeleHealth_API.Controllers
{
    /*
    User Controller for API requests involving log in
    */
    [Authorize]
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // For API storage context and setting up connection to the User Service for authentication.
        private readonly UserContext _context;
        private IUserService _userService;

        public UserController(UserContext context, IUserService userService)
        {
            _context = context;
            _userService = userService;
        }

        /* GET: api/User
            For use in scenarios where administrative users are required to check the list of users.
            DTO will display information pertaining to the username and password of a User and no additional information.
        */

        // [HttpGet]
        // public async Task<ActionResult<IEnumerable<UserDTO>>> GetUsers()
        // {
        //     return await _context.Users.Select(x => ItemToDTO(x)).ToListAsync();
        // }

        /*
            Primary Authentication Endpoint

            Descriptions: Allows API users to access this endpoint in order to the determine if a user
            is valid or invalid. Will make comparison against a currently existing list of users
            Before returning the appropriate account role that will determine the level of access 
            on the Web Client.

            Params: username and password as is required by the User Model in Models/User.cs

            Output: Role Type associated with the account as dictated by the Authentication DTO.
        */
        [AllowAnonymous]
        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody]User dto) {
            var user = await _userService.Authenticate(dto.userName, dto.password);

            if (user == null) {
                return BadRequest(new { message = "Username or Password is incorrect"});
            }

            return Ok(new AuthenticateDTO {role = user.role});
        }


        // POST: api/User
        // For future use in situations where new users are to be added to the list.
        // Will require redirection within the User Service as well.

        // [HttpPost]
        // public async Task<ActionResult<User>> PostUser(User user)
        // {
        //     _context.Users.Add(user);
        //     await _context.SaveChangesAsync();

        //     return CreatedAtAction("GetUser", new { id = user.ID }, user);
        // }

        private bool UserExists(long id)
        {
            return _context.Users.Any(e => e.ID == id);
        }

        // Used in Conjunction with Get Users which is currently disabled.
        // private static UserDTO ItemToDTO(User user) =>
        // new UserDTO
        // {
        //     userName = user.userName,
        //     password = user.password
        // };
    }
}
