namespace HPoc.Web.Requests
{
    public class FundtransferRequest
    {
        public string SendingNumber { get; set; }
        public string RecievingNumber { get; set; }
        public decimal Amount { get; set; }
        public string Narration { get; set; }
    }
}
