using App.Domains.Users;
using App.Domains.Wallets;
using HPoc.API.App.Infrastructure.InMemoryStore;
using System;
using System.IO;

namespace App.Infrastructure.InMemoryStore
{
    public class Context
    {
        public WalletJsonStore<User, Guid> Users { get; set; }
        public WalletJsonStore<Wallet, Guid> Wallets { get; set; }

        string usersPath, walletPath;
        public Context()
        {
            // EnsureRequiredFilesAreCreated();
            AssignPath();
            Users = new WalletJsonStore<User, Guid>(usersPath);
            Wallets = new WalletJsonStore<Wallet, Guid>(walletPath);
        }

        public void AssignPath()
        {
            string baseFilePath = "HALALPOCDB";
            usersPath = Path.Combine(baseFilePath, $"{nameof(Users)}.json");
            walletPath = Path.Combine(baseFilePath, $"{nameof(Wallets)}.json");

        }
        private void EnsureRequiredFilesAreCreated()
        {
            string baseFilePath = "HALALPOCDB";

            if (!Directory.Exists(baseFilePath))
                Directory.CreateDirectory(baseFilePath);

            usersPath = Path.Combine(baseFilePath, $"{nameof(Users)}.json");
            walletPath = Path.Combine(baseFilePath, $"{nameof(Wallets)}.json");
            if (!File.Exists(usersPath))
                File.Create(usersPath);
            if (!File.Exists(walletPath))
                File.Create(walletPath);
        }
    }

    public class JsonUserStore
    {
        public WalletJsonStore<User, Guid> Users { get; set; }
        public WalletJsonStore<Wallet, Guid> Wallets { get; set; }

        string usersPath, walletPath;
        public JsonUserStore()
        {
            EnsureRequiredFilesAreCreated();

            Users = new WalletJsonStore<User, Guid>(usersPath);
            Wallets = new WalletJsonStore<Wallet, Guid>(walletPath);
        }

        private void EnsureRequiredFilesAreCreated()
        {
            string baseFilePath = "HALALPOCDB";

            if (!Directory.Exists(baseFilePath))
                Directory.CreateDirectory(baseFilePath);

            usersPath = Path.Combine(baseFilePath, $"{nameof(Users)}.json");
            walletPath = Path.Combine(baseFilePath, $"{nameof(Wallets)}.json");
            if (!File.Exists(usersPath))
                File.Create(usersPath);
            if (!File.Exists(walletPath))
                File.Create(walletPath);
        }
    }
}
