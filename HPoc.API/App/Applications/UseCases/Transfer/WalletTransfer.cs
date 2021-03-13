using App.Domains.ValueObjects;
using System;
using System.Threading.Tasks;

namespace App.Applications.UseCases.Transfer
{
    public interface IFundTransfer
    {
        Task<FundTransferResult> Execute(Guid sendingWalletId, Guid recievingWalletId, Amount amount, string narration);
        Task<FundTransferResult> Execute(string sendingWalletNumber, string recievingWalletNumber, Amount amount, string narration);
    }
}
