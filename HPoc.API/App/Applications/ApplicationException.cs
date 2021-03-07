namespace App.Applications
{
    using System;
    public class ApplicationException : Exception
    {
        internal ApplicationException(string businessMessage)
               : base(businessMessage)
        {
        }
    }

    internal sealed class WalletNotFoundException : ApplicationException
    {
        internal WalletNotFoundException(string message)
            : base(message)
        { }
    }
}
