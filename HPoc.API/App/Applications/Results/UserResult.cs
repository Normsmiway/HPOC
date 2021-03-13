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
        public IReadOnlyCollection<UserDetails> Beneficiaries { get; }
        public UserResult(Guid userId,
            string name,
            string email,
            string phone,
            List<WalletResult> walletAccounts, List<UserDetails> beneficiaries)
        {
            UserId = userId;
            Name = name;
            Email = email;
            PhoneNumber = phone;
            Beneficiaries = beneficiaries;
            WalletResults = walletAccounts;

        }

    }

    public sealed class UserDetails
    {
        public string WalletNumber { get; }
        public Guid UserId { get; }
        public string Name { get; }
        public string Email { get; }
        public string PhoneNumber { get; } = string.Empty;

        public UserDetails(Guid userId,
          string walletNumber,
          string name,
          string email,
          string phone)
        {
            UserId = userId;
            WalletNumber = walletNumber;
            Name = name;
            Email = email;
            PhoneNumber = phone;
        }
    }
}
