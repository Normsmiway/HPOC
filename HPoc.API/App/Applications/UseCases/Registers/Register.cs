
using System;
using App.Domains.Users;
using App.Domains.Wallets;
using System.Threading.Tasks;
using App.Applications.WalletNumbers;
using HPoc.API.App.Applications.Contracts;

namespace App.Applications.UseCases.Registers
{
    public class Register : IRegister
    {
        private readonly IUserStore _store;
        private readonly IWalletNumberHandler _numberHandler;
        private readonly IWalletStore _walletStore;
        public Register(IUserStore store,
            IWalletStore walletStore,
            IWalletNumberHandler numberHandler)
        {
            _store = store;
            _walletStore = walletStore;
            _numberHandler = numberHandler;
        }
        public async Task<RegisterResult> Execute(string name, string email, string phoneNumber, DateTime dateOfBirth, decimal intialAmount)
        {
            User user = User.Create(name, email, phoneNumber);
            string number = await _numberHandler.GenerateAsync();
            Wallet wallet = Wallet.Create(user.Id.ToString(), number, "Default", "NGN");

            wallet.FundWallet(intialAmount, Guid.NewGuid().ToString().ToUpperInvariant());
            Credit credit = (Credit)wallet.GetLastTransaction();

            user.Register(wallet.Id);

            //wrap this in a unit of work
            await _store.AddAsync(user);
            await _walletStore.Add(wallet, credit);


            return new RegisterResult(user, wallet);

        }
    }
}
