using System;

namespace HPoc.API.Modules.Models
{
    public sealed class TransactionModel
    {
        public decimal Amount { get; }
        public string TransactionType { get; }
        public DateTime TransactionDate { get; }
        public string Narration { get; }
        public string Reference { get; }
        public TransactionModel(decimal amount, string type, DateTime transactionDate,string narration,string reference)
        {
            Amount = amount;
            TransactionType = type;
            TransactionDate = transactionDate;
            Reference = reference;
            Narration = narration;
        }
    }
}
