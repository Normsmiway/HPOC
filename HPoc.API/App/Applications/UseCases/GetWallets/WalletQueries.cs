using App.Applications.Results;
using App.Domains.Wallets;
using App.Infrastructure.InMemoryStore;
using HPoc.API.App.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Applications.UseCases.GetWallets
{
    public class WalletQueries : IWalletQueries
    {
        private readonly Context _context;
        private readonly IWalletRepository _repository;
        public WalletQueries(IWalletRepository repository, Context context)
        {
            _context = context;
            _repository = repository;
        }
        public async Task<WalletResult> GetWalletAsync(Guid walletId)
        {
            Wallet wallet = await _repository.Get(walletId);

            return await GetAsync(wallet);
        }

        public async Task<WalletResult> GetWalletAsync(string walletNumber)
        {
            Wallet wallet = await _repository.Get(walletNumber);

            return await GetAsync(wallet);
        }



        private static async Task<WalletResult> GetAsync(Wallet wallet)
        {
            if (wallet is null)
                throw new WalletNotFoundException("Wallet not found");

            List<ITransaction> credits = wallet.GetWalletTransactions()
                .Where(c => c is Credit).ToList();

            List<ITransaction> debits = wallet.GetWalletTransactions()
                .Where(d => d is Debit).ToList();


            decimal credit = credits.Sum(c => c.Amount);
            decimal debit = debits.Sum(d => d.Amount);

            List<TransactionResult> transactionResults = new();

            foreach (Credit t in credits)
            {
                TransactionResult transactionResult = new(
                    t.TransactionType,
                    t.Amount,
                    t.TransactionDate,
                    wallet.CurrencyCode,
                    t.Narration,
                    t.Reference,
                    t.MarchantRefence);
                transactionResults.Add(transactionResult);
            }

            foreach (Debit t in debits)
            {
                TransactionResult transactionResult = new(
                    t.TransactionType,
                    t.Amount,
                    t.TransactionDate,
                    wallet.CurrencyCode,
                    t.Narration,
                    t.Reference,
                    t.MarchantRefence);
                transactionResults.Add(transactionResult);
            }

            List<TransactionResult> orderedTransactionResult = transactionResults
                .OrderByDescending(t => t.TransactionDate).ToList();

            WalletResult walletResult = new(wallet.Id,
                wallet.CurrencyCode,
                wallet.WalletType,
                credit - debit,
                wallet.GetTotalIcome(),
                wallet.GetTotalExpenses(),
                wallet.WalletNumber,
                wallet.UserId,
                orderedTransactionResult);

            return await Task.FromResult(walletResult);
        }
    }
}
