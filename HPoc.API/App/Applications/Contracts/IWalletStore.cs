using System;
using App.Domains.Wallets;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace HPoc.API.App.Applications.Contracts
{
    public interface IWalletStore
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
