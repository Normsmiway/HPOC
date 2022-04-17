using System;

namespace HPoc.API.App.Infrastructure.Entities
{
    public class User : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
    }
}
