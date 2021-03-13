using App.Domains.ValueObjects;
using System;

namespace App.Domains.Wallets
{
    public sealed record Debit : IEntity<Guid>, ITransaction
    {
        public Guid WalletId { get; private set; }
        public Guid Id { get; private init; }
        public Amount Amount { get; private init; }
        public DateTime TransactionDate { get; private init; }
        public string Reference { get; private init; }
        public string Narration { get; private init; }
        public string TransactionType { get { return nameof(Debit); } }
        public string MarchantRefence { get; }

        private Debit() { }

        public static Debit Load(Guid id, Guid walletId, Amount amount, DateTime transactionDate,
            string reference, string narration)
        {
            return new Debit()
            {
                Amount = amount,
                Id = id,
                Narration = narration,
                Reference = reference,
                TransactionDate = transactionDate,
                WalletId = walletId
            };
        }

        public Debit(Guid walletId, Amount amount, string narration)
        {
            Id = Guid.NewGuid();
            WalletId = walletId;
            Amount = amount;
            TransactionDate = DateTime.UtcNow;
            Narration = narration;
            Reference = Guid.NewGuid().ToString();
            MarchantRefence = Guid.NewGuid().ToString().ToUpperInvariant();
        }
    }
}
