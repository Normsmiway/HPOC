using System;

namespace HPoc.Web.Requests
{
    public class RegistrationRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public decimal InitialAmount { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
