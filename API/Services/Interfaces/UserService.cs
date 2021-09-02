using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> Authenticate(string email, string password);
        Task<IEnumerable<User>> GetAll();
    }

    public class UserService : IUserService
    {
        private List<User> _users = new List<User>
        {
            new User { Id = 1, FirstName = "Test", LastName = "User", Email = "Email", Password = "test" }
        };

        public async Task<User> Authenticate(string email, string password)
        {
            var user = await Task.Run(() => _users.SingleOrDefault(x => x.Email == email && x.Password == password));

            if (user == null)
                return null;

            return user;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await Task.Run(() => _users);
        }
    }
}
