using App.Applications.UseCases.FundWallets;
using App.Applications.UseCases.Withdrawal;
using App.Domains.ValueObjects;
using App.Domains.Wallets;
using System;
using System.Threading.Tasks;

namespace App.Applications.UseCases.Transfer
{
    public sealed class FundTransfer : IFundTransfer
    {
        private readonly IWithdrawal _withdrawal;
        private readonly IFundWallet _funding;

        public FundTransfer(IWithdrawal withdrawal, IFundWallet fundWallet)
        {
            _withdrawal = withdrawal;
            _funding = fundWallet;
        }
        public async Task<FundTransferResult> Execute(Guid sendingWalletId, Guid recievingWalletId, Amount amount, string narration)
        {

            var withrawalResult = await _withdrawal.Execute(sendingWalletId, amount, narration);
            if (withrawalResult is not null)
            {
                var fundResult = await _funding.Execute(recievingWalletId, amount);

                return new FundTransferResult(
                    new Debit(sendingWalletId, amount, narration),
                    withrawalResult.CurrentBalace);
            }

            return default;
        }
    }
}
