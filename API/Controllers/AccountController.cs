using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Domain.Classes;

namespace API.Controllers
{
    [Route("api/account")]
    [ApiController]
    [Authorize]
    public class AccountController : ControllerBase
    {
        [HttpPost, AllowAnonymous, Route("login")]
        public async Task<IActionResult> Login([FromBody] AuthenticateRequest parameter)
        {
            if (parameter == null)
            {
                throw new ArgumentNullException(nameof(parameter));
            }
            User user = null;
        }

        [HttpGet, AllowAnonymous, Route("logout")]
        public async Task<IActionResult> Logout(int? userId)
        {
            throw new NotImplementedException();
        }

        [HttpPost, AllowAnonymous, Route("register")]
        public async Task<IActionResult> Register([FromBody] User parameter)
        {
            throw new NotImplementedException();
        }

        [HttpPost, AllowAnonymous, Route("resetpassword"), ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPassword parameter)
        {
            throw new NotImplementedException();
        }

        [HttpGet, AllowAnonymous, Route("resetpassword")]
        public async Task<IActionResult> ResetPassword(string token, string email)
        {
            if (string.IsNullOrEmpty(token) || string.IsNullOrEmpty(email))
            {
                throw new ArgumentNullException();
            }
            var model = new ResetPassword() { Email = email, ResetPasswordToken = token };
            return Ok(model);
        }

        [HttpGet, AllowAnonymous, Route("forgotpassword")]
        public async Task<IActionResult> ForgotPassword(ForgotPassword parameter)
        {
            throw new NotImplementedException();
        }
    }
}
