using App.Applications.Results;
using System;
using System.Collections.Generic;

namespace HPoc.API.Modules.Models
{
    public sealed class WalletDetailsModel
    {
        public Guid WalletId { get; }
        public string WalletNumber { get; }
        public decimal CurrentBalance { get; }
        public string CurrencyCode { get; }
        public string WalletType { get; }
        public decimal TotalExpences { get; }
        public decimal TotalIncome { get; }
        public List<TransactionModel> Transactions { get; }



        public WalletDetailsModel(Guid walletId, string walletNumber,
            decimal currentBalance,decimal totalIncome,
            decimal totalExpenses,string currencycode,
            string walletType,List<TransactionModel> transactions)
        {
            WalletId = walletId;
            WalletNumber = walletNumber;
            CurrentBalance = currentBalance;
            CurrencyCode = currencycode;
            WalletType = walletType;
            TotalExpences = totalExpenses;
            TotalIncome = totalIncome;
            Transactions = transactions;
        }
    }


    public sealed class UserDetailsModel
    {
        public Guid UserId { get; }
        public string PhoneNumber { get; }
        public string Email { get; }
        public string Name { get; }
        public DateTime DateOfBirth { get; }
        public List<WalletDetailsModel> Wallets { get; }
        public List<UserDetails> Beneficiaries { get; }

        public UserDetailsModel(Guid userId,string phone,
            string email,string name,DateTime dateOfBirth,
            List<WalletDetailsModel> wallets,
            List<UserDetails> beneficiaries) 
        {
            UserId = userId;
            PhoneNumber = phone;
            Email = email;
            Name = name;
            DateOfBirth = dateOfBirth;
            Wallets = wallets;
            Beneficiaries=beneficiaries;
        }
    }
}
