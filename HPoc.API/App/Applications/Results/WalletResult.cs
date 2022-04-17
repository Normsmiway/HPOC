using App.Domains.Wallets;
using System;
using System.Collections.Generic;
using System.Linq;

namespace  App.Applications.Results
{
    public sealed class WalletResult
    {
        public Guid WalletId { get;}
        public decimal CurrentBalance { get; }
        public decimal TotalExpenses { get; }
        public decimal TotalIncome { get; }
        public string CurrencyCode { get; }
        public string WalletNumber { get; }

        public string WalletType { get;  }
        public string UserId { get; }
        public List<TransactionResult> Transactions { get; }

        public WalletResult(Guid walletId, 
            string currencyCode,
            string walletType,
            decimal currentBalance,
            decimal totalIncome,
            decimal totalExpenses, 
            string walletNumber, 
            string userId,
            List<TransactionResult> transactions)
        {
            WalletId = walletId;
            CurrencyCode = currencyCode;
            WalletType = walletType;
            CurrentBalance = currentBalance;
            TotalIncome = totalIncome;
            TotalExpenses = totalExpenses;
            WalletNumber = walletNumber;
            Transactions = transactions;
            UserId = userId;
        }

        public WalletResult(Wallet wallet)
        {
            WalletId = wallet.Id;
            WalletNumber = wallet.WalletNumber.Value;
            CurrentBalance = wallet.GetWalletBalance();
            TotalIncome = wallet.GetTotalIcome();
            TotalExpenses = wallet.GetTotalExpenses();
            CurrencyCode =wallet.CurrencyCode;
            WalletType =wallet.WalletType;

            List<TransactionResult> transactionResults = new();
            wallet.GetWalletTransactions(10).ToList().ForEach(transaction =>
            {
                var transactionResult = new TransactionResult(transaction.TransactionType,
                    transaction.Amount, transaction.TransactionDate,wallet.CurrencyCode,
                    transaction.Narration,
                    transaction.Reference,transaction.MarchantRefence);

                transactionResults.Add(transactionResult);
            });

            Transactions = transactionResults;

        }
    }
}
