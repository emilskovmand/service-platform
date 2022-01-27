using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Classes;

namespace API.Services
{
    public interface IAccountService
    {
        Task<IUser> Login(IAuthenticateRequest request);
        Task<IUser> Register(User user);
        Task<IUser> Logout(int userId);

    }
}
