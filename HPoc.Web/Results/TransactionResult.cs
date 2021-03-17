using System;

namespace HPoc.Web.Results
{
    public class TransactionResult
    {
        public int Number { get; set; }
        public string TranactionType { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Narration { get; set; }
        public string Reference { get; set; }
        public string Currency { get; set; }
        public string MarchantReference { get; set; }
    }
}