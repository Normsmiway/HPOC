using App.Applications.Results;
using App.Applications.UseCases.GetWallets;
using App.Domains.Users;
using App.Infrastructure.InMemoryStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static App.Infrastructure.InfrastructureException;

namespace App.Applications.UseCases.GetUsers
{
    public interface IUserQueries
    {
        Task<UserResult> GetUser(Guid userId);
        Task<List<UserResult>> GetUsers();
    }


    public class UserQueries : IUserQueries
    {
        private readonly Context _context;
        private readonly IWalletQueries _walletQueries;
        public UserQueries(Context context, IWalletQueries walletQueries)
        {
            _context = context;
            _walletQueries = walletQueries;
        }
        public async Task<UserResult> GetUser(Guid userId)
        {
            User user = _context.Users
                .Where(u => u.Id == userId).SingleOrDefault();

            if (user is null)
                throw new UserNotFoundException();

            return await GetUserResult(user);
        }
        public async Task<List<UserResult>> GetUsers()
        {
            List<UserResult> usersResult = new();
            var users = _context.Users;

            if (users is not null && users.Any())
                foreach (var user in users)
                {
                    usersResult.Add(await GetUserResult(user));
                }
            return usersResult;

            throw new UserNotFoundException();
        }


        #region private helper methods
        private async Task<UserResult> GetUserResult(User user)
        {
            List<WalletResult> walletResults = new();

            foreach (Guid walletId in user.Wallets)
            {
                WalletResult walletResult = await _walletQueries.GetWalletAsync(walletId);
                walletResults.Add(walletResult);
            }

            UserResult userResult = new UserResult(user.Id, user.Name,
                user.Email, user.PhoneNumber, walletResults);

            return await Task.FromResult(userResult);
        }
        #endregion
    }
}
