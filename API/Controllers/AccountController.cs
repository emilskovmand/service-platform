using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using API.Services.Interfaces;
using System;
using System.Threading.Tasks;
using API.Models;

namespace API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/account")]
    public class AccountController : ControllerBase
    {
        private IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost, AllowAnonymous, Route("login")]
        public async Task<IActionResult> Authenticate([FromBody]AuthenticateModel model)
        {
            var user = await _userService.Authenticate(model.Email, model.Password);

            if (user == null)
                return BadRequest(new { message = "Email or password is incorrect" });

            return Ok(user);
        }

        [HttpPost, AllowAnonymous, Route("logout")]
        public async Task<IActionResult> Logout([FromBody] string parameters)
        {
            throw new NotImplementedException();
        }

        [HttpPost, AllowAnonymous, Route("register")]
        public async Task<IActionResult> Register([FromBody] string parameters)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await _userService.GetAll();
            return Ok(users);
        }

    }
}
