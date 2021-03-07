using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace App.Domains.Users
{
    public sealed class WalletCollection
    {
        private readonly IList<Guid> _walletds;

        public WalletCollection()
        {
            _walletds = new List<Guid>();
        }

        public IReadOnlyCollection<Guid> GetWalletIds()
        {
            IReadOnlyCollection<Guid> walletIds = new ReadOnlyCollection<Guid>(_walletds);
            return walletIds;
        }

        public void Add(Guid walletId)
        {
            _walletds.Add(walletId);
        }
    }
}
