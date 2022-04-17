using App.Domains.Users;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HPoc.API.App.Infrastructure.Repositories
{
    public interface IUserRepository
    {
        Task Add(User user);
        Task Update(User user);
        Task<User> Get(Guid id);
        Task<List<User>> GetAll();
       
    }
}
