namespace App.Domains.Wallets
{
    using System;
    using App.Domains.ValueObjects;

    public interface ITransaction
    {
        Amount Amount { get; }
        string TransactionType { get; }
        DateTime TransactionDate { get; }
        string Reference { get; }
        string Narration { get; }
    }


    public enum TransactionType
    {
        Credit,
        Debit
    }
}
