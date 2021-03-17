using System;
using System.Collections.Generic;

namespace HPoc.Web.Results
{
    public class UserResult
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public List<WalletResult> WalletResults { get; set; } = new();
        public List<UserDetailsResult> Beneficiaries { get; set; } = new();
    }
}