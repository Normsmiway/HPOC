using App.Domains.Users;
using System;
using System.Threading.Tasks;

namespace HPoc.API.App.Applications.Contracts
{
    public interface IUserStore
    {
        void Add(User user);
        Task AddAsync(User user);
        void Remove(Guid id);
        Task RemoveAsync(Guid id);
        void Update(User user);
        Task UpdateAsync(User user);
    }
}
