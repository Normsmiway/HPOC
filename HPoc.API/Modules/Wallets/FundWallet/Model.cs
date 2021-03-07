using System;

namespace HPoc.API.Modules.Wallets.FundWallet
{
    internal sealed class Model
    {
        public decimal Amount { get; }
        public string Description { get; }
        public DateTime TransactionDate { get; }
        public decimal UpdateBalance { get; }
        public string Narration { get; }
        public string Reference { get; }

        public Model(decimal amount,
            string description, DateTime transactionDate,
            decimal updatedBalance,string reference,string narration)
        {
            Amount = amount;
            Description = description;
            TransactionDate = transactionDate;
            UpdateBalance = updatedBalance;
            Reference = reference;
            Narration = narration;
        }
    }
}
