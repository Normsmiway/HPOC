using System;

namespace HPoc.API.Modules.Wallets.Withdrawal
{
    public class WithdrawalFundRequest
    {
        public Guid WalletId { get; set; }
        public decimal Amount { get; set; }
        public string Narration { get; set; }
    }

    public class WithdrawalByNumberFundRequest
    {
        public string WalletNumber { get; set; }
        public decimal Amount { get; set; }
        public string Narration { get; set; }
    }
}
