using System;

namespace HPoc.Web.Results
{
    public class UserDetailsResult
    {
        public string WalletNumber { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public DateTime LastLogin { get; set; }

    }
}