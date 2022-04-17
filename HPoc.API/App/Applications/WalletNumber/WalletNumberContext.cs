using App.Domains;
using App.Domains.ValueObjects;
using App.Infrastructure.InMemoryStore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace App.Applications
{
    public class WalletNumberContext :
        InMemoryRepository<WalletNumber, Guid>
    {
        private readonly Context _context;
        public WalletNumberContext(Context context)
        {
            _context = context;
        }
        public async Task<bool> NumberExistsAsync(string number)
        {
            var result = _context.WalletNumbers.Where(n => n.Value == number).FirstOrDefault();
            return result != null;
        }
        public new async Task AddAsync(WalletNumber walletNumber)
        {
            await _context.WalletNumbers.AddAsync(new HPoc.API.App.Infrastructure.Entities.WalletNumber()
            {
                Id = walletNumber.Id,
                Value = walletNumber.Value
            });
        }
    }


}
