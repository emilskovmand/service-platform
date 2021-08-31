using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace API.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        [HttpPost, AllowAnonymous, Route("login")]
        public async Task<IActionResult> Login([FromBody] string parameters)
        {
            throw new NotImplementedException();
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

    }
}
