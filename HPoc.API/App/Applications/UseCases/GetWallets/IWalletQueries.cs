using App.Applications.Results;
using System;
using System.Threading.Tasks;

namespace App.Applications.UseCases.GetWallets
{
    public interface IWalletQueries
    {
        Task<WalletResult> GetWalletAsync(Guid walletId);
        Task<WalletResult> GetWalletAsync(string walletNumber);
    }
}
