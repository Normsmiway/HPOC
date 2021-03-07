using App.Applications.Results;
using App.Domains.ValueObjects;
using App.Domains.Wallets;

namespace App.Applications.UseCases.Transfer
{
    public class FundTransferResult
    {
        public TransactionResult Transaction { get; }
        public decimal CurrentBalace { get; }
        public FundTransferResult(Debit debit, Amount balance)
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
