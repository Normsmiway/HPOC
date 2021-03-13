﻿using System;

namespace App.Applications.Results
{
    public sealed class TransactionResult
    {
        public string TranactionType { get; }
        public decimal Amount { get; }
        public DateTime TransactionDate { get; }
        public string Narration { get; }
        public string Reference { get; }
        public string Currency { get; }
        public string MarchantReference { get; }
        public TransactionResult(
            string transactionType,
            decimal amount,
            DateTime transactionDate,
            string currency,
            string narration,
            string reference,
            string marchantReference)
        {
            TranactionType = transactionType;
            Amount = amount;
            TransactionDate = transactionDate;
            Currency = currency;
            Reference = reference ?? string.Empty;
            MarchantReference = marchantReference ?? string.Empty;
            Narration = narration ?? string.Empty;
        }
    }
}
