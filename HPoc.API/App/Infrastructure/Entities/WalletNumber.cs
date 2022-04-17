using System;

namespace HPoc.API.App.Infrastructure.Entities
{
    public class WalletNumber : BaseEntity<Guid>
    {
        public string Value { get; set; }
    }
}
