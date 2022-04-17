using App.Domains;
using System.Threading.Tasks;

namespace App.Applications.WalletNumbers
{
    public interface IWalletNumberHandler
    {
        Task<WalletNumber> GenerateAsync();
    }

}
