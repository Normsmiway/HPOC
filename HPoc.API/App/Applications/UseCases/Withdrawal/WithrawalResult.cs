using App.Applications.Results;
using App.Domains.ValueObjects;
using App.Domains.Wallets;

namespace App.Applications.UseCases.Withdrawal
{
    public sealed class WithdrawalResult
    {

        public TransactionResult Transaction { get; }
        public decimal CurrentBalace { get; }
        public WithdrawalResult(Debit debit, Amount balance)
        {
            Transaction = new TransactionResult(
                debit.TransactionType,
                debit.Amount,
                debit.TransactionDate,
                debit.Narration,
                debit.Reference);

            CurrentBalace = balance;
        }
    }
}
