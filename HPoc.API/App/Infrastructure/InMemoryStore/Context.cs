using System;
using HPoc.API.App.Infrastructure.Entities;
using HPoc.API.App.Infrastructure.InMemoryStore;
namespace App.Infrastructure.InMemoryStore
{
    public class Context
    {

      //  const string baseFilePath = "HALALPOCDB";
        public WalletJsonStore<User, Guid> Users { get; set; }
        public WalletJsonStore<Wallet, Guid> Wallets { get; set; }
        public WalletJsonStore<WalletNumber, Guid> WalletNumbers { get; set; }

        public WalletJsonStore<Credit, Guid> Credits { get; set; }
        public WalletJsonStore<Debit, Guid> Debits { get; set; }


        public Context()
        {
            Users = new WalletJsonStore<User, Guid>();
            Wallets = new WalletJsonStore<Wallet, Guid>();
            WalletNumbers = new WalletJsonStore<WalletNumber, Guid>();
            Credits = new WalletJsonStore<Credit, Guid>();
            Debits = new WalletJsonStore<Debit, Guid>();
        }
    }
}
