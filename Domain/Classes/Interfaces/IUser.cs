using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Classes
{
    public interface IUser
    {
        Guid Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string PasswordHash { get; set; }
        DateTime DateOfCreation { get; set; }
        string PhoneNumber { get; set; }
    }
}
