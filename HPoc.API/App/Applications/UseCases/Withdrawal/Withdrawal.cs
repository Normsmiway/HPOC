using App.Domains.ValueObjects;
using App.Domains.Wallets;
using App.Infrastructure.InMemoryStore;
using System;
using System.Threading.Tasks;

namespace App.Applications.UseCases.Withdrawal
{
    public class Withdrawal : IWithdrawal
    {

        private readonly WalletInMemoryStore _store;
        public Withdrawal(WalletInMemoryStore store)
        {
            _store = store;
        }
        public async Task<WithdrawalResult> Execute(Guid walletId, Amount amount, string narration)
        {
            Wallet wallet = await _store.Get(walletId);
            return await GetWithdrawalResult(amount, narration, wallet);
        }

        public async Task<WithdrawalResult> Execute(string walletNumber, Amount amount, string narration)
        {
            Wallet wallet = await _store.Get(walletNumber);
            return await GetWithdrawalResult(amount, narration, wallet);
        }

        #region private helper methods
        private async Task<WithdrawalResult> GetWithdrawalResult(Amount amount, string narration, Wallet wallet)
        {
            if (wallet is null)
                throw new WalletNotFoundException("Wallet not found");

            wallet.Withraw(amount, narration);

            Debit debit = (Debit)wallet.GetLastTransaction();
           
            
            await _store.Update(wallet, debit);

            return new WithdrawalResult(
                debit, wallet.GetWalletBalance(), wallet.CurrencyCode);
        }
        #endregion
    }
}
