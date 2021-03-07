namespace App.Domains.Wallets
{
    public sealed class InsuficientFundsException : DomainException
    {
        internal InsuficientFundsException(string message)
            : base(message)
        { }
    }


    public sealed class WalletCannotBeClosedException : DomainException
    {
        internal WalletCannotBeClosedException(string message)
            : base(message)
        { }
    }
}
