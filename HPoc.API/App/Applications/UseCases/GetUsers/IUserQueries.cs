using App.Applications.Results;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App.Applications.UseCases.GetUsers
{
    public interface IUserQueries
    {
        Task<UserResult> GetUserAsync(Guid userId);
        Task<UserDetails> GetUserDetailsAsync(string walletNumber);
        Task<List<UserResult>> GetUsersAsync();
    }
}
