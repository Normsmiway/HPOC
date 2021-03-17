using HPoc.Web.Requests;
using HPoc.Web.Results;
using System;
using System.Threading.Tasks;

namespace HPoc.Web.Sevices
{
    public interface IHalalWalletClient
    {
        Task<RegisterationResult> Register(RegistrationRequest request);
        Task<UserDetailsResult> GetUserDetails(string walletNumber);
        Task<FundTransferResult> TrasnferFund(FundtransferRequest request);
        Task<RegisterationResult> GetUpdateDetails(Guid userId);
    }
}
