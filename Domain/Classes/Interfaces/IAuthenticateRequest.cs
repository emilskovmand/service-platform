using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public interface IAuthenticateRequest
    {
        string Email { get; set; }
        string Password { get; set; }
    }
}
