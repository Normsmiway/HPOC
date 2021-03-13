using App.Applications.Results;
using App.Domains.ValueObjects;
using App.Domains.Wallets;

namespace App.Applications.UseCases.FundWallets
{
    public sealed class FundingResult
    {
        
        public TransactionResult Transaction { get; }
        public decimal CurrentBalace { get; }
        public FundingResult(Credit credit, Amount balance,string currency )
        {
            Transaction = new TransactionResult(
                credit.TransactionType,
                credit.Amount,
                credit.TransactionDate,
                currency,
                credit.Narration,
                credit.Reference,
                credit.MarchantRefence);

            CurrentBalace = balance;
        }
    }
}
