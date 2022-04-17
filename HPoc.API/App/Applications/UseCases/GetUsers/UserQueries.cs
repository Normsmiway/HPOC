using System;
using System.Linq;
using App.Domains.Users;
using App.Domains.Wallets;
using System.Threading.Tasks;
using App.Applications.Results;
using System.Collections.Generic;
using App.Infrastructure.InMemoryStore;
using App.Applications.UseCases.GetWallets;
using HPoc.API.App.Infrastructure.Repositories;
using static App.Infrastructure.InfrastructureException;

namespace App.Applications.UseCases.GetUsers
{
    public class UserQueries : IUserQueries
    {
        private readonly Context _context;
        private readonly IWalletQueries _walletQueries;
        private readonly IUserRepository _repository;
        private readonly IWalletRepository _walletRepository;
        public UserQueries(Context context,
            IWalletQueries walletQueries,
            IUserRepository repository,
            IWalletRepository walletRepository)
        {
            _context = context;
            _walletQueries = walletQueries;
            _repository = repository;
            _walletRepository = walletRepository;
        }
        public async Task<UserResult> GetUserAsync(Guid userId)
        {
            User user = await _repository.Get(userId);

            if (user is null)
                throw new UserNotFoundException();

            var userResult = await GetUserResult(user);



            return userResult;
        }

        public async Task<UserDetails> GetUserDetailsAsync(string walletNumber)
        {
            return await GetUserDetails(walletNumber);
        }

        public async Task<List<UserResult>> GetUsersAsync()
        {
            List<UserResult> usersResult = new();
            var users = await _repository.GetAll();

            if (users is not null && users.Any())
                foreach (var user in users)
                {
                    usersResult.Add(await GetUserResult(user));
                }
            return usersResult;

            throw new UserNotFoundException();
        }


        #region private helper methods

        private async Task<List<UserDetails>> GetBeneficiaries(Guid userId, User user)
        {
            List<Wallet> othersWallets = _walletRepository.GetOtherWallets(userId);

            #region manipulation to get beneficiaries
            List<UserDetails> Beneficiaries = new();
            List<ITransaction> myCreditTransacToOthers = new();

            List<ITransaction> otherWalletCreditTranactions = new();
            List<string> BeneficiaryIds = new();
            List<WalletResult> MyWalletResults = new();

            foreach (Guid walletId in user.Wallets)
            {
                WalletResult walletResult = await _walletQueries.GetWalletAsync(walletId);
                MyWalletResults.Add(walletResult);
            }

            othersWallets.ForEach(w =>
            {
                var creditTransactions = w.GetWalletTransactions().Where(t => t.TransactionType == nameof(Credit));
                otherWalletCreditTranactions.AddRange(creditTransactions);
            });
            var mywallet = MyWalletResults.SingleOrDefault();
            var myDebits = mywallet?.Transactions?.Where(t => t.TranactionType == nameof(Debit));


            if (myDebits is not null && myDebits.Any())
            {
                foreach (var transaction in myDebits)
                {
                    var creditToOther = otherWalletCreditTranactions.Where(tr =>
                   tr.MarchantRefence == transaction.MarchantReference).SingleOrDefault();

                    if (creditToOther is not null)
                        myCreditTransacToOthers.Add(creditToOther);
                }
            }



            foreach (var item in myCreditTransacToOthers)
            {
                var otherWallet = othersWallets.Where(ow => ow.GetWalletTransactions()
                .Where(t => t.MarchantRefence ==
                item.MarchantRefence).SingleOrDefault() != null).SingleOrDefault();

                if (otherWallet is not null && !BeneficiaryIds.Contains(otherWallet.WalletNumber))
                    BeneficiaryIds.Add(otherWallet.WalletNumber);
            }


            foreach (var beneficiaryId in BeneficiaryIds)
            {
                Beneficiaries.Add(await GetUserDetails(beneficiaryId));
            }

            return Beneficiaries;
            #endregion
        }
        private async Task<UserResult> GetUserResult(User user)
        {
            List<WalletResult> walletResults = new();

            foreach (Guid walletId in user.Wallets)
            {
                WalletResult walletResult = await _walletQueries.GetWalletAsync(walletId);
                walletResults.Add(walletResult);
            }

            var beneficiaries = await GetBeneficiaries(user.Id, user);
            UserResult userResult = new(user.Id, user.Name,
                user.Email, user.PhoneNumber, walletResults, beneficiaries);

            return await Task.FromResult(userResult);
        }


        private async Task<UserDetails> GetUserDetails(string walletNumber)
        {
            WalletResult wallet = null;
            try
            {
                wallet = await _walletQueries.GetWalletAsync(walletNumber);
            }
            catch (WalletNotFoundException)
            {
                throw new UserNotFoundException();
            }


            _ = Guid.TryParse(wallet.UserId, out Guid userId);

            var user = _context.Users.Where(u => u.Id == userId).SingleOrDefault();

            return new UserDetails(user.Id, wallet.WalletNumber, user.Name, user.Email, user.PhoneNumber);
        }
        #endregion
    }
}
