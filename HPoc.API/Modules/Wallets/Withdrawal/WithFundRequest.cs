using System;

namespace HPoc.API.Modules.Wallets.Withdrawal
{
    public class WithFundRequest
    {
        public Guid WalletId { get; set; }
        public decimal Amount { get; set; }
        public string Narration { get; set; }
    }
}
