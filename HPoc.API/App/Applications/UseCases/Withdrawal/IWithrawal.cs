using App.Domains.ValueObjects;
using System;
using System.Threading.Tasks;

namespace App.Applications.UseCases.Withdrawal
{
    public interface IWithdrawal
    {
        Task<WithdrawalResult> Execute(Guid walletId, Amount amount,string narration);
        Task<WithdrawalResult> Execute(string walletNumber, Amount amount, string narration);
    }
}
