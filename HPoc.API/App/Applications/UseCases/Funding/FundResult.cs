using App.Applications.Results;
using App.Domains.ValueObjects;
using App.Domains.Wallets;

namespace App.Applications.UseCases.FundWallets
{
    public sealed class FundingResult
    {
        
        public TransactionResult Transaction { get; }
        public decimal CurrentBalace { get; }
        public FundingResult(Credit credit, Amount balance )
        {
            Transaction = new TransactionResult(
                credit.TransactionType,
                credit.Amount,
                credit.TransactionDate,
                credit.Narration,
                credit.Reference);

            CurrentBalace = balance;
        }
    }
}
