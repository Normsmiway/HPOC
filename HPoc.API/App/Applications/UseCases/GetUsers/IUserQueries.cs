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
        public Task<UserResult> GetUser(Guid userId);
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

            List<WalletResult> walletResults = new List<WalletResult>();

            foreach (Guid walletId in user.Wallets)
            {
                WalletResult walletResult = await _walletQueries.GetWalletAsync(walletId);
                walletResults.Add(walletResult);
            }

            UserResult userResult = new UserResult(user.Id, user.Name,
                user.Email, user.PhoneNumber, walletResults);

            return await Task.FromResult(userResult);
        }
    }
}
