using System;

namespace HPoc.API.Modules.Users.Register
{
    public sealed partial class UsersController
    {
        public sealed class RegisterRequest
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public decimal InitialAmount { get; set; }
            public DateTime DateOfBirth { get; set; }
        }
    }
}
