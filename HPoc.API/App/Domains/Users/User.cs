using System;
using Newtonsoft.Json;
using System.Collections.Generic;

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
        [JsonConstructor]
        private User(Name name, Email email, PhoneNumber phone)
        {
            //run precondntions
            Id = Guid.NewGuid();
            Name = name;
            Email = email;
            PhoneNumber = phone;
            _wallets = new WalletCollection();

            //raise new user created domain event
        }
        public static User Create(Name name,Email email,PhoneNumber phoneNumber)
        {
            return new(name, email, phoneNumber);
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
