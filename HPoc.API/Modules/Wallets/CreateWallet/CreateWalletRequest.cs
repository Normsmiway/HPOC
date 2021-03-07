namespace HPoc.API.Modules.Wallets.CreateWallet
{
    public class CreateWalletRequest
    {
        public string Type { get; set; }
        public decimal InitialAmount { get; set; } = 0;
    }
}