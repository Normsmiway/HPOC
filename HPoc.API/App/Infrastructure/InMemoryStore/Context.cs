using App.Domains.Users;
using App.Domains.Wallets;
using System.Collections.ObjectModel;

namespace App.Infrastructure.InMemoryStore
{
    public class Context
    {
        public Collection<User> Users { get; set; }
        public Collection<Wallet> Wallets { get; set; }

        public Context()
        {
            Users = new Collection<User>();
            Wallets = new Collection<Wallet>();
        }
    }
}
