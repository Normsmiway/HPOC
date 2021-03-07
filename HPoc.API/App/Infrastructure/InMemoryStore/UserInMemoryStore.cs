using App.Domains;
using App.Domains.Users;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace App.Infrastructure.InMemoryStore
{
    public class UserInMemoryStore : InMemoryRepository<User, Guid>
    {
        private readonly Context _context;

        public UserInMemoryStore(Context context)
        {
            _context = context;
        }

        public async Task AddAsync(User user)
        {
            _context.Users.Add(user);
            await Task.CompletedTask;
        }

        public async Task<User> GetUserAsync(Guid id)
        {
            User user = _context.Users
                .Where(u => u.Id == id)
                .SingleOrDefault();

            return await Task.FromResult(user);
        }

        public async Task Update(User usr)
        {
            User user = await GetUserAsync(usr.Id);
            var oldUser = user;
            await Task.CompletedTask;
        }
    }
}
