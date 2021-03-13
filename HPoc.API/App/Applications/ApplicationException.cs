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

    internal sealed class InvalidTransferException : ApplicationException
    {
        public InvalidTransferException():base("Invalid Operation, can't transder fund to the same wallet")
        {

        }
    }
}
