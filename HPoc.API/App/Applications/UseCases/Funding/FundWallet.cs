using App.Domains.ValueObjects;
using App.Domains.Wallets;
using App.Infrastructure.InMemoryStore;
using System;
using System.Threading.Tasks;

namespace App.Applications.UseCases.FundWallets
{
    public class FundWallet : IFundWallet
    {
        private readonly WalletInMemoryStore _store;
        public FundWallet(WalletInMemoryStore store)
        {
            _store = store;
        }

        public async Task<FundingResult> Execute(Guid walletId, Amount amount, string marchantReference)
        {
            Wallet wallet = await _store.Get(walletId);
            return await GetFundingResult(amount, wallet, marchantReference);
        }



        public async Task<FundingResult> Execute(string walletNumber, Amount amount, string marchantReference)
        {
            Wallet wallet = await _store.Get(walletNumber);

            return await GetFundingResult(amount, wallet, marchantReference);
        }


        #region private helper method
        private async Task<FundingResult> GetFundingResult(Amount amount, Wallet wallet, string marchantReference)
        {
            if (wallet is null)
                throw new WalletNotFoundException("Wallet not found");

            wallet.FundWallet(amount, marchantReference);

            Credit credit = (Credit)wallet.GetLastTransaction();

            await _store.Update(wallet, credit);

            return new FundingResult(credit, wallet.GetWalletBalance(), wallet.CurrencyCode);
        }
        #endregion
    }
}
