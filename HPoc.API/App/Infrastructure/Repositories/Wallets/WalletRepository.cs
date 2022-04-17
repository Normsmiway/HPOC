using App.Domains.Wallets;
using App.Infrastructure.InMemoryStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace HPoc.API.App.Infrastructure.Repositories
{
    public class WalletRepository : IWalletRepository
    {
        private readonly Context _context;
        public WalletRepository(Context context)
        {
            _context = context;
        }
        public async Task Add(Wallet wallet, Credit credit)
        {
            Entities.Wallet walletEntity = new()
            {
                CurrencyCode = wallet.CurrencyCode,
                Id = wallet.Id,
                UserId = Guid.Parse(wallet.UserId),
                WalletNumber = wallet.WalletNumber,
                WalletType = wallet.WalletType
            };
            Entities.Credit creditEntity = new()
            {
                Id = credit.Id,
                Amount = credit.Amount,
                MarchantRefence = credit.MarchantRefence,
                Narration = credit.Narration,
                Reference = credit.Reference,
                TransactionDate = credit.TransactionDate,
                TransactionType = credit.TransactionType,
                WalletId = credit.WalletId
            };

            await _context.Wallets.AddAsync(walletEntity);
            await _context.Credits.AddAsync(creditEntity);
        }

        public Task Delete(Wallet wallet)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Wallet> Get(Guid id)
        {
            Entities.Wallet wallet =
                await _context.Wallets.GetAsync(id);
            List<Entities.Credit> credits =
                 _context.Credits.Where(c => c.WalletId == id).ToList();

            List<Entities.Debit> debits =
              _context.Debits.Where(c => c.WalletId == id).ToList();

            List<ITransaction> transactions = new();

            foreach (var c in credits)
            {
                Credit credit = Credit.Load(c.Id, c.WalletId,
                    c.Amount, c.TransactionDate, c.Reference, c.MarchantRefence);
                transactions.Add(credit);
            }
            foreach (var d in debits)
            {
                Debit debit = Debit.Load(d.Id, d.WalletId,
                    d.Amount, d.TransactionDate, d.Reference, d.Narration, d.MarchantRefence);
                transactions.Add(debit);
            }
            var orderedTransactions = transactions.OrderByDescending(o => o.TransactionDate).ToList();
            TransactionCollection transactionCollection = new TransactionCollection();
            transactionCollection.Add(orderedTransactions);

            Wallet result = Wallet.Load(
                wallet.Id, wallet.UserId.ToString(),
                wallet.WalletNumber, wallet.WalletType,
                wallet.CurrencyCode,
                transactionCollection);

            return result;
        }

        public async Task<Wallet> Get(string walletNumner)
        {
            Entities.Wallet wallet =
                  _context.Wallets.Where(w => w.WalletNumber == walletNumner).SingleOrDefault() ?? new();

            List<Entities.Credit> credits =
                 _context.Credits.Where(c => c.WalletId == wallet.Id).ToList();

            List<Entities.Debit> debits =
              _context.Debits.Where(c => c.WalletId == wallet.Id).ToList();

            List<ITransaction> transactions = new();

            foreach (var c in credits)
            {
                Credit credit = Credit.Load(c.Id, c.WalletId,
                    c.Amount, c.TransactionDate, c.Reference, c.MarchantRefence);
                transactions.Add(credit);
            }
            foreach (var d in debits)
            {
                Debit debit = Debit.Load(d.Id, d.WalletId,
                    d.Amount, d.TransactionDate, d.Reference, d.Narration, d.MarchantRefence);
                transactions.Add(debit);
            }
            var orderedTransactions = transactions.OrderByDescending(o => o.TransactionDate).ToList();
            TransactionCollection transactionCollection = new TransactionCollection();
            transactionCollection.Add(orderedTransactions);

            Wallet result = Wallet.Load(
                wallet.Id, wallet.UserId.ToString(),
                wallet.WalletNumber, wallet.WalletType,
                wallet.CurrencyCode,
                transactionCollection);

            return result;
        }

        public List<Wallet> GetOtherWallets(Guid userId)
        {
            var res = _context.Wallets.Where(w => w.UserId != userId);
            return res.Select(w => Get(w.Id).Result).ToList();
        }

        public async Task<Wallet> GetByUserId(Guid userId)
        {
            Entities.Wallet wallet =
                   _context.Wallets.Where(w => w.UserId == userId).SingleOrDefault() ?? new();
            List<Entities.Credit> credits =
                           _context.Credits.Where(c => c.WalletId == wallet.Id).ToList();

            List<Entities.Debit> debits =
              _context.Debits.Where(c => c.WalletId == wallet.Id).ToList();

            List<ITransaction> transactions = new();

            foreach (var c in credits)
            {
                Credit credit = Credit.Load(c.Id, c.WalletId,
                    c.Amount, c.TransactionDate, c.Reference, c.MarchantRefence);
                transactions.Add(credit);
            }
            foreach (var d in debits)
            {
                Debit debit = Debit.Load(d.Id, d.WalletId,
                    d.Amount, d.TransactionDate, d.Reference, d.Narration, d.MarchantRefence);
                transactions.Add(debit);
            }
            var orderedTransactions = transactions.OrderByDescending(o => o.TransactionDate).ToList();
            TransactionCollection transactionCollection = new();
            transactionCollection.Add(orderedTransactions);

            Wallet result = Wallet.Load(
                wallet.Id, wallet.UserId.ToString(),
                wallet.WalletNumber, wallet.WalletType,
                wallet.CurrencyCode,
                transactionCollection);

            return result;
        }

        public async Task Update(Wallet wallet, Credit credit)
        {
            Entities.Credit creditEntity = new()
            {
                Amount = credit.Amount,
                Id = credit.Id,
                MarchantRefence = credit.MarchantRefence,
                Narration = credit.Narration,
                Reference = credit.Reference,
                TransactionType = credit.TransactionType,
                TransactionDate = credit.TransactionDate,
                WalletId = credit.WalletId
            };

            await _context.Credits.UpdateAsync(creditEntity);
        }

        public async Task Update(Wallet wallet, Debit debit)
        {
            Entities.Debit debitEntity = new()
            {
                Amount = debit.Amount,
                Id = debit.Id,
                MarchantRefence = debit.MarchantRefence,
                Narration = debit.Narration,
                Reference = debit.Reference,
                TransactionType = debit.TransactionType,
                TransactionDate = debit.TransactionDate,
                WalletId = debit.WalletId
            };

            await _context.Debits.UpdateAsync(debitEntity);
        }


    }
}
