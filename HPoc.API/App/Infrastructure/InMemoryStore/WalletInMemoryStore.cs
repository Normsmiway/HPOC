using App.Domains;
using App.Domains.Wallets;
using HPoc.API.App.Applications.Contracts;
using HPoc.API.App.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Infrastructure.InMemoryStore
{
    public class WalletInMemoryStore : InMemoryRepository<Wallet, Guid>, IWalletStore
    {
        private readonly Context _context;
        private readonly IWalletRepository _repository;
        public WalletInMemoryStore(Context context,IWalletRepository repository)
        {
            _context = context;
            _repository = repository;
        }
        public Task Add(Wallet wallet, Credit credit)
        {
           return _repository.Add(wallet,credit);
        }

        public new Task<Wallet> Get(Guid id)
        {
           return  _repository.Get(id);
        }

        public  Task<Wallet> Get(string walletNumber)
        {
         return _repository.Get(walletNumber);
        }
        public Task Update(Wallet wallet, Credit credit)
        {
            return _repository.Update(wallet, credit);
        }

        public Task Update(Wallet wallet, Debit debit)
        {
            return _repository.Update(wallet, debit);
        }
        public Task Delete(Wallet wallet)
        {
            return _repository.Delete(wallet);
        }

        public Task<Wallet> GetByUserId(Guid userId)
        {
            throw new NotImplementedException();
        }

        public List<Wallet> GetOtherWallets(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
