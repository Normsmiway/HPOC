namespace App.Domains.Users
{
    public sealed class NameShouldNotBeEmptyException : DomainException
    {
        internal NameShouldNotBeEmptyException(string message)
            : base(message)
        { }
    }



    public sealed class EmailShouldNotBeEmptyException : DomainException
    {
        internal EmailShouldNotBeEmptyException(string message)
            : base(message)
        { }
    }

    public sealed class PhoneNumberShouldNotBeEmptyException : DomainException
    {
        internal PhoneNumberShouldNotBeEmptyException(string message)
            : base(message)
        { }
    }
}
