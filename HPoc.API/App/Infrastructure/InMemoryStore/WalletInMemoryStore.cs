using App.Domains;
using App.Domains.Wallets;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace App.Infrastructure.InMemoryStore
{
    public class WalletInMemoryStore : InMemoryRepository<Wallet, Guid>
    {
        private readonly Context _context;

        public WalletInMemoryStore(Context context)
        {
            _context = context;
        }
        public Task Add(Wallet wallet, Credit credit)
        {
            return Task.Run(() =>
            {
                _context.Wallets.Add(wallet);
            });
        }

        public async Task<Wallet> Get(Guid id)
        {
            Wallet wallet = _context.Wallets
                .Where(e => e.Id == id)
                .SingleOrDefault();

            return await Task.FromResult<Wallet>(wallet);
        }

        public async Task<Wallet> Get(string walletNumber)
        {
            Wallet wallet = _context.Wallets
                .Where(w => w.WalletNumber == walletNumber)
                .SingleOrDefault();

            return await Task.FromResult<Wallet>(wallet);
        }
        public Task Update(Wallet wallet, Credit credit)
        {
            {
                return Task.Run(() =>
                {
                    Wallet oldWallet = _context.Wallets
                    .Where(w => w.Id == wallet.Id).SingleOrDefault();

                    oldWallet = wallet;
                });
            }
        }

        public Task Update(Wallet wallet, Debit debit)
        {
            {
                return Task.Run(() =>
                {
                    Wallet oldWallet = _context.Wallets
                     .Where(w => w.Id == wallet.Id).SingleOrDefault();

                    oldWallet = wallet;
                });
            }
        }
        public Task Delete(Wallet wallet)
        {
            {
                return Task.Run(() =>
                {
                    Wallet walletOld = _context.Wallets
                    .Where(w => w.Id == wallet.Id).SingleOrDefault();

                    _context.Wallets.Remove(walletOld);
                });
            }
        }
    }
}
