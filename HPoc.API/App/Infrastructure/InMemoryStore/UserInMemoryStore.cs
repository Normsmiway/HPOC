using App.Domains;
using App.Domains.Users;
using HPoc.API.App.Applications.Contracts;
using HPoc.API.App.Infrastructure.Repositories;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace App.Infrastructure.InMemoryStore
{
    public class UserInMemoryStore : InMemoryRepository<User, Guid>, IUserStore
    {
        private readonly Context _context;
        private readonly IUserRepository _repository;
        public UserInMemoryStore(Context context, IUserRepository repository)
        {
            _context = context;
            _repository = repository;
        }

        public new async Task AddAsync(User user)
        {
            await _repository.Add(user);
        }

        public async Task<User> GetUserAsync(Guid id)
        {
            //User user = _context.Users
            //    .Where(u => u.Id == id)
            //    .SingleOrDefault();

            //return await Task.FromResult(user);

            return await _repository.Get(id);
        }

        public new async Task Update(User usr)
        {
            User user = await GetUserAsync(usr.Id);
            var oldUser = user;
            await Task.CompletedTask;
        }
    }
}
