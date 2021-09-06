using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public class User : IUser
    {
        public Guid Id { get ; set ; }
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }
        public string Email { get ; set ; }
        public string PasswordHash { get ; set ; }
        public DateTime DateOfCreation { get ; set ; }
        public string PhoneNumber { get ; set ; }
    }
}
