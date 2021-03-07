namespace App.Domains.Users
{
    public sealed class Email
    {
        private string _text;

        public Email(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new EmailShouldNotBeEmptyException("The 'Email' field is required");

            this._text = text;
        }

        public override string ToString()
        {
            return _text.ToString();
        }

        public static implicit operator Email(string text)
        {
            return new Email(text);
        }

        public static implicit operator string(Email name)
        {
            return name._text;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj is string)
            {
                return obj.ToString() == _text;
            }

            return ((Email)obj)._text == _text;
        }

        public override int GetHashCode()
        {
            return _text.GetHashCode();
        }
    }
}
