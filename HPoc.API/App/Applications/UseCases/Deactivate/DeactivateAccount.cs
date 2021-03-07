using App.Domains.Wallets;
using App.Infrastructure.InMemoryStore;
using System;
using System.Threading.Tasks;

namespace App.Applications.UseCases.Deactivate
{
    public sealed class DeactivateAccount : IDeactivateAccount
    {
        private readonly WalletInMemoryStore _store;
        public DeactivateAccount(WalletInMemoryStore store)
        {
            _store = store;
        }
        public async Task<Guid> Execute(Guid walletId)
        {
            Wallet wallet = await _store.Get(walletId);
            if (wallet == null)
                throw new WalletNotFoundException($"Wallet not found");
            wallet.Deactivate();

            await _store.RemoveAsync(wallet.Id);

            return wallet.Id;
        }
    }
}
