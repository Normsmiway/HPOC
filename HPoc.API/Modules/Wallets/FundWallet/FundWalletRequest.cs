using System;

namespace HPoc.API.Modules.Wallets.FundWallet
{
    public class FundWalletRequest
    {
        public Guid WalletId { get; set; }
        public string WalletNumber { get; set; }
        public decimal Amount { get; set; }
    }
}
