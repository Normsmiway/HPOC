using App.Domains;
using App.Domains.ValueObjects;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace App.Applications
{
    public class WalletNumberContext :
        InMemoryRepository<WalletNumber, Guid>
    {
       public async Task<bool> NumberExistsAsync(string number)
        {
          return await Task.FromResult(this.Entities.Values
              .FirstOrDefault(n =>n.Text== number) != null);
        }


    }


}
