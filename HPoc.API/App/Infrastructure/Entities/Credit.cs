using System;

namespace HPoc.API.App.Infrastructure.Entities
{
    public class Credit : BaseEntity<Guid>
    {
        public Guid WalletId { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Reference { get; set; }
        public string TransactionType { get; set; }
        public string Narration { get; set; }
        public string MarchantRefence { get; set; }
    }
}
