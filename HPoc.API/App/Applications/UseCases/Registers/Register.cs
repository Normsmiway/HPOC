using App.Applications.WalletNumbers;
using App.Domains.Users;
using App.Domains.Wallets;
using App.Infrastructure.InMemoryStore;
using System;
using System.Threading.Tasks;

namespace App.Applications.UseCases.Registers
{
    public class Register : IRegister
    {
        private readonly UserInMemoryStore _store;
        private readonly IWalletNumberHandler _numberHandler;
        private readonly WalletInMemoryStore _walletStore;
        public Register(UserInMemoryStore store,
            WalletInMemoryStore walletStore,
            IWalletNumberHandler numberHandler)
        {
            _store = store;
            _walletStore = walletStore;
            _numberHandler = numberHandler;
        }
        public async Task<RegisterResult> Execute(string name, string email, string phoneNumber, DateTime dateOfBirth, decimal intialAmount)
        {
            User user = new User(name, email, phoneNumber);
            string number = await _numberHandler.GenerateAsync();
            Wallet wallet = new Wallet(user.Id.ToString(), number, "Default", "NGN");

            wallet.FundWallet(intialAmount);
            Credit credit = (Credit)wallet.GetLastTransaction();

            user.Register(wallet.Id);

            await _store.AddAsync(user);
            await _walletStore.Add(wallet, credit);


            return new RegisterResult(user, wallet);

        }
    }
}
