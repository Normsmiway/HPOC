using App.Applications.Results;
using App.Applications.UseCases.FundWallets;
using App.Applications.UseCases.GetUsers;
using App.Applications.UseCases.GetWallets;
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
        private readonly IWalletQueries _walletQueries;
        private readonly IUserQueries _userQueries;
        public FundTransfer
            (IWithdrawal withdrawal,
             IFundWallet fundWallet,
             IWalletQueries walletQueries,
             IUserQueries userQueries)
        {
            _withdrawal = withdrawal;
            _funding = fundWallet;
            _walletQueries = walletQueries;
            _userQueries = userQueries;
        }
        public async Task<FundTransferResult> Execute(Guid sendingWalletId, Guid recievingWalletId, Amount amount, string narration)
        {

            var withrawalResult = await _withdrawal.Execute(sendingWalletId, amount, narration);
            if (withrawalResult is not null)
            {
                var sendingWallet = await GetWalletUserId(sendingWalletId);

                _ = Guid.TryParse(sendingWallet?.UserId, out Guid senderUsrId);
                var sender = await GetUser(senderUsrId);

                var fundResult = await _funding.Execute(recievingWalletId, amount);

                var receivingWallet = await GetWalletUserId(recievingWalletId);
                _ = Guid.TryParse(receivingWallet?.UserId, out Guid usrId);
                var receiver = await GetUser(usrId);

                return new FundTransferResult(
                    new Debit(sendingWalletId, amount, narration),
                    new Credit(recievingWalletId, fundResult.Transaction.Amount),
                    sender.Name,
                    withrawalResult.Transaction.Currency,
                    receiver.Name,
                    receivingWallet.WalletNumber);
            }

            return default;
        }

        private async Task<WalletResult> GetWalletUserId(Guid walletId)
        {
            var wallet = await _walletQueries.GetWalletAsync(walletId);
            return wallet;
        }

        private async Task<UserResult> GetUser(Guid usrId)
        {
            var user= await _userQueries.GetUser(usrId);
            return user;
        }
    }
}
