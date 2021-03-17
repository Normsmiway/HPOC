using System;
using System.Collections.Generic;
using System.Linq;

namespace HPoc.Web.Results
{
    public class WalletResult
    {
        public Guid WalletId { get; set; }
        public decimal CurrentBalance { get; set; }
        public decimal TotalExpenses { get; set; }
        public decimal TotalIncome { get; set; }
        public string CurrencyCode { get; set; }
        public string WalletNumber { get; set; }

        public string WalletType { get; set; }
        public string UserId { get; set; }
        public IEnumerable<TransactionResult> Transactions { get; set; } = Enumerable.Empty<TransactionResult>();



    }
}