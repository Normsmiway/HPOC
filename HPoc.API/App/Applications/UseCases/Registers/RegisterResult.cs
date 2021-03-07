using App.Applications.Results;
using App.Domains.Users;
using App.Domains.Wallets;
using System.Collections.Generic;

namespace App.Applications.UseCases.Registers
{
    public sealed class RegisterResult
    {
        public UserResult User { get; }
        public WalletResult Wallet { get; }

        public RegisterResult(User user, Wallet wallet)
        {
            List<TransactionResult> transactionResults = new List<TransactionResult>();

            foreach (ITransaction transaction in wallet.GetWalletTransactions())
            {
                transactionResults.Add(
                    new TransactionResult(
                        transaction.TransactionType,
                        transaction.Amount,
                        transaction.TransactionDate,
                        transaction.Narration,
                        transaction.Reference));
            }

            Wallet = new WalletResult(wallet.Id, wallet.CurrencyCode, wallet.WalletType, wallet.GetWalletBalance(),
                wallet.GetTotalIcome(), wallet.GetTotalExpenses(), wallet.WalletNumber, transactionResults);

            List<WalletResult> accountResults = new List<WalletResult>
            {
                Wallet
            };

            User = new UserResult(user.Id, user.Name, user.Email, user.PhoneNumber, accountResults);
        }
    }
}
