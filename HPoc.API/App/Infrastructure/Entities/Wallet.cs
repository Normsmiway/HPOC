using System;

namespace HPoc.API.App.Infrastructure.Entities
{
    public class Wallet : BaseEntity<Guid>
    {
        public Guid UserId { get; set; }
        public string WalletNumber { get; set; }
        public string WalletType { get; set; }
        public string CurrencyCode { get; set; }
    }
}
