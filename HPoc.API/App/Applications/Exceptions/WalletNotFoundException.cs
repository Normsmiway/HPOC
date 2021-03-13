namespace App.Applications
{
    internal sealed class WalletNotFoundException : ApplicationException
    {
        internal WalletNotFoundException(string message)
            : base(message)
        { }
    }
}
