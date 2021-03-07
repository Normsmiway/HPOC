
namespace App.Infrastructure
{
    using System;
    public class InfrastructureException : Exception
    {
        internal InfrastructureException(string businessMessage)
               : base(businessMessage)
        {
        }

        public class UserNotFoundException : InfrastructureException
        {
            internal UserNotFoundException()
                : base("User not found")
            { }
        }
    }
}
