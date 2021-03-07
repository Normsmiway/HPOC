using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace App.Domains.Users
{
    public sealed class User : IAggregateRoot<Guid>
    {
        private WalletCollection _wallets;


        public Guid Id { get; private set; }
        public Name Name { get; private set; }
        public PhoneNumber PhoneNumber { get; private set; }
        public Email Email { get; private set; }

        public IReadOnlyCollection<Guid> Wallets
        {
            get
            {
                IReadOnlyCollection<Guid> walletIds = _wallets.GetWalletIds();
                return walletIds;
            }
        }

        public User(Name name, Email email, PhoneNumber phone)
        {
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
            PhoneNumber = phone;
            _wallets = new WalletCollection();
        }

        public void Register(Guid walletId)
        {
            _wallets.Add(walletId);
        }
        private User() { }
        public static User Load(Guid id, Name name, Email email, PhoneNumber phone, WalletCollection wallets)
        {
            return new User()
            {
                Email = email,
                Id = id,
                Name = name,
                PhoneNumber = phone,
                _wallets = wallets
            };
        }

    }
}
