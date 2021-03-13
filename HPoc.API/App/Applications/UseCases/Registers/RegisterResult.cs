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
            List<TransactionResult> transactionResults = new();

            foreach (ITransaction transaction in wallet.GetWalletTransactions())
            {
                transactionResults.Add(
                    new TransactionResult(
                        transaction.TransactionType,
                        transaction.Amount,
                        transaction.TransactionDate,
                        wallet.CurrencyCode,
                        transaction.Narration,
                        transaction.Reference,
                        transaction.MarchantRefence));
            }

            Wallet = new WalletResult(wallet.Id,
                wallet.CurrencyCode,
                wallet.WalletType,
                wallet.GetWalletBalance(),
                wallet.GetTotalIcome(),
                wallet.GetTotalExpenses(),
                wallet.WalletNumber,
                wallet.UserId,
                transactionResults);

            List<WalletResult> accountResults = new()
            {
                Wallet
            };

            User = new UserResult(user.Id, user.Name, user.Email, user.PhoneNumber, accountResults,new());
        }
    }
}
