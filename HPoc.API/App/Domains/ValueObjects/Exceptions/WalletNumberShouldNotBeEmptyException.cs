namespace App.Domains.ValueObjects
{
    public sealed class WalletNumberShouldNotBeEmptyException : DomainException
    {
        internal WalletNumberShouldNotBeEmptyException(string message)
            : base(message)
        { }
    }
}
