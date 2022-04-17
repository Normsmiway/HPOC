using System;
using System.Linq;
using App.Domains.Users;
using System.Threading.Tasks;
using System.Collections.Generic;
using App.Infrastructure.InMemoryStore;

namespace HPoc.API.App.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly Context _context;
        public UserRepository(Context context)
        {
            _context = context;
        }
        public async Task Add(User user)
        {
            Entities.User usr = new()
            {
                Email = user.Email,
                Id = user.Id,
                Name = user.Name,
                PhoneNumber = user.PhoneNumber
            };

            await _context.Users.AddAsync(usr);
        }


        public async Task<User> Get(Guid id)
        {
            Entities.User usr = await _context.Users.GetAsync(id);

            List<Guid> wallets = _context.Wallets
                .Where(w => w.UserId == id)
                .Select(c => c.Id).ToList();

            var walletCollection = WalletCollection.Create();

            foreach (var walletId in wallets) walletCollection.Add(walletId);

            return User.Load(usr.Id, usr.Name, usr.Email, usr.PhoneNumber, walletCollection);
        }

        public async Task<List<User>> GetAll()
        {
            var users = await _context.Users.GetAllAsync();

            return users?.Select(u => Get(u.Id).Result).ToList();
        }

        public async Task Update(User user)
        {
            Entities.User usr = new()
            {
                Email = user.Email,
                Id = user.Id,
                Name = user.Name,
                PhoneNumber = user.PhoneNumber
            };

            await _context.Users.UpdateAsync(usr);
        }
    }
}
