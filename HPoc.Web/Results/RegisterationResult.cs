namespace HPoc.Web.Results
{
    public class RegisterationResult
    {
        public UserResult User { get; set; } = new();
        public WalletResult Wallet { get; set; } = new();
    }


    public class FundTransferResult
    {
        public TransactionResult Transaction { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverWalletNumber { get; set; }
        public string From { get; set; }
    }
}