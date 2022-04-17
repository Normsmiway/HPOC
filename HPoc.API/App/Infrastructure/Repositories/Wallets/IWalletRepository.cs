using App.Domains.Wallets;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HPoc.API.App.Infrastructure.Repositories
{

    public interface IWalletRepository
    {
        Task Add(Wallet wallet, Credit credit);
        Task Update(Wallet wallet, Credit credit);
        Task Update(Wallet wallet, Debit debit);
        Task Delete(Wallet wallet);
        Task<Wallet> Get(Guid id);
        Task<Wallet> Get(string walletNumner);
        Task<Wallet> GetByUserId(Guid userId);
        public List<Wallet> GetOtherWallets(Guid userId);
    }
}
