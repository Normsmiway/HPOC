using System;

namespace App.Domains
{
    public class DomainException : Exception
    {
        internal DomainException(string businessMessage)
            : base(businessMessage)
        {
        }
    }
}
