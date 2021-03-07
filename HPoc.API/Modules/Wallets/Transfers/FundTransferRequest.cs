using System;

namespace HPoc.API.Modules.Wallets.Transfers
{
    public class FundTransferRequest
    {
        public Guid SendingWalletId { get; set; }
        public Guid RecievingWalletId { get; set; }
        public decimal Amount { get; set; }
        public string Narration { get; set; }
    }
}
