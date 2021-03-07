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
            if (wallet is null)
                throw new WalletNotFoundException("Wallet not found");

            wallet.Withraw(amount, narration);

            Debit debit = (Debit)wallet.GetLastTransaction();

            await _store.Update(wallet, debit);

            return new WithdrawalResult(
                debit, wallet.GetWalletBalance());
        }
    }
}
