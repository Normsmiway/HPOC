namespace App.Domains.ValueObjects
{
    public sealed class InvalidWalletNumberException : DomainException
    {
        internal InvalidWalletNumberException(string message)
            : base(message)
        { }
    }
}
