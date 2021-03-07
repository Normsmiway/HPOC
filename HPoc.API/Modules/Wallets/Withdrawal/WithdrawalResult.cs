using System;

namespace HPoc.API.Modules.Wallets.Withdrawal
{

    internal sealed class WithdrawalResultModel
    {
        public decimal Amount { get; }
        public string Type { get; }
        public DateTime TransactionDate { get; }
        public decimal CurrentBalance { get; }
        public string Narration { get; }
        public string Reference { get; }

        public WithdrawalResultModel(decimal amount, string transactionType, DateTime transactionDate, decimal updatedBalance,string narrattion,string refrenece)
        {
            Amount = amount;
            Type = transactionType;
            TransactionDate = transactionDate;
            CurrentBalance = updatedBalance;
            Narration = narrattion;
            Reference = refrenece;
        }
    }
}
