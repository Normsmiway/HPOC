using App.Applications.Results;
using App.Domains.ValueObjects;
using App.Domains.Wallets;

namespace App.Applications.UseCases.Transfer
{
    public class FundTransferResult
    {
        public TransactionResult Transaction { get; }
        public string ReceiverName { get; }
        public string ReceiverWalletNumber { get; }
        public string From { get; }
        public FundTransferResult(Debit debit, Credit credit, string from,
            string currencyCode, string recieverName,string receiverWalletNumber)
        {
            Transaction = new TransactionResult(
                debit.TransactionType,
                debit.Amount,
                debit.TransactionDate,
                currencyCode,
                credit.Narration,
                debit.Reference);
            ReceiverWalletNumber = receiverWalletNumber;
            ReceiverName = recieverName;
            From = from;
        }
    }



    //Transfer Result
    //Currency
    //Amount
    //ReceiverName
    //ReceiverWalletId

    //TransactionType
    //ReferenceId
    //Date
    //From
    //Narration
}
