using App.Domains.ValueObjects;
using System;

namespace App.Domains.Wallets
{
    public sealed record Credit : IEntity<Guid>, ITransaction
    {
        public Guid WalletId { get; init; }
        public Guid Id { get; private init; }
        public Amount Amount { get;  init; }
        public DateTime TransactionDate { get;  init; }
        public string Reference { get;  init; }
        public string TransactionType { get { return nameof(Credit); } }
        public string Narration { get { return $"Creditd {Amount} into wallet"; }} 

        private Credit() { }

        public static Credit Load(Guid id, Guid walletId, Amount amount, DateTime transactionDate,
            string reference)
        {
            return new Credit()
            {
                Amount = amount,
                Id = id,
                Reference = reference,
                TransactionDate = transactionDate,
                WalletId = walletId
            };
        }

        public Credit(Guid walletId,Amount amount)
        {
            Id = Guid.NewGuid();
            WalletId = walletId;
            Amount = amount;
            TransactionDate = DateTime.UtcNow;
            Reference = Guid.NewGuid().ToString();
        }
    }
}
