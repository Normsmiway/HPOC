using System;
using System.Collections.Generic;

namespace App.Applications.Results
{
    public sealed class UserResult
    {
        public Guid UserId { get; }
        public string Name { get; }
        public string Email { get; }
        public string PhoneNumber { get; } = string.Empty;
        public IReadOnlyCollection<WalletResult> WalletResults { get; }

        public UserResult(Guid userId,
            string name,
            string email,
            string phone,
            List<WalletResult> walletAccounts)
        {
            UserId = userId;
            Name = name;
            Email = email;
            PhoneNumber = phone;
            WalletResults = walletAccounts;

        }

    }
}
