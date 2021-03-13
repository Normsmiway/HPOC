namespace App.Applications
{
    internal sealed class InvalidTransferException : ApplicationException
    {
        public InvalidTransferException():base("Invalid Operation, can't transder fund to the same wallet")
        {

        }
    }
}
