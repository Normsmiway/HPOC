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
            //Ensure both debit and credit accoount exits
            var sendingWallet = await GetWallet(sendingWalletId);
            var receivingWallet = await GetWallet(recievingWalletId);

            if (sendingWalletId.Equals(recievingWalletId))
            {
                throw new InvalidTransferException();
            }
            var withrawalResult = await _withdrawal.Execute(sendingWalletId, amount, narration);

            if (withrawalResult is not null)
            {
                _ = Guid.TryParse(sendingWallet?.UserId, out Guid senderUsrId);
                var sender = await GetUser(senderUsrId);

                var fundResult = await _funding.Execute(recievingWalletId, amount,
                    withrawalResult.Transaction.MarchantReference);


                _ = Guid.TryParse(receivingWallet?.UserId, out Guid usrId);
                var receiver = await GetUser(usrId);

                return new FundTransferResult(
                    new Debit(sendingWallet.WalletId, amount, narration),
                    new Credit(receivingWallet.WalletId, fundResult.Transaction.Amount,
                    withrawalResult.Transaction.MarchantReference),
                    sender.Name,
                    withrawalResult.Transaction.Currency,
                    receiver.Name,
                    receivingWallet.WalletNumber);
            }

            return default;
        }

        public async Task<FundTransferResult> Execute(string sendingWalletNumber, string recievingWalletNumber, Amount amount, string narration)
        {
            //Ensure both debit and credit accoount exits
            var sendingWallet = await GetWallet(sendingWalletNumber);
            var receivingWallet = await GetWallet(recievingWalletNumber);

            if (sendingWalletNumber.Equals(recievingWalletNumber))
            {
                throw new InvalidTransferException();
            }
            var withrawalResult = await _withdrawal.Execute(sendingWalletNumber, amount, narration);
            // withrawalResult.Transaction.Reference;
            if (withrawalResult is not null)
            {


                _ = Guid.TryParse(sendingWallet?.UserId, out Guid senderUsrId);
                var sender = await GetUser(senderUsrId);

                var fundResult = await _funding.Execute(recievingWalletNumber, amount,
                    withrawalResult.Transaction.MarchantReference);


                _ = Guid.TryParse(receivingWallet?.UserId, out Guid usrId);
                var receiver = await GetUser(usrId);

                return new FundTransferResult(
                    new Debit(sendingWallet.WalletId, amount, narration),
                    new Credit(receivingWallet.WalletId, fundResult.Transaction.Amount,
                    withrawalResult.Transaction.MarchantReference),
                    sender.Name,
                    withrawalResult.Transaction.Currency,
                    receiver.Name,
                    receivingWallet.WalletNumber);
            }

            return default;
        }

        #region private helper methods
        private async Task<WalletResult> GetWallet(Guid walletId)
        {
            var wallet = await _walletQueries.GetWalletAsync(walletId);
            return wallet;
        }
        private async Task<WalletResult> GetWallet(string walletNumber)
        {
            var wallet = await _walletQueries.GetWalletAsync(walletNumber);
            return wallet;
        }
        private async Task<UserResult> GetUser(Guid usrId)
        {
            var user = await _userQueries.GetUserAsync(usrId);
            return user;
        }
        #endregion
    }
}
