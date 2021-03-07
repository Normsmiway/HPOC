namespace App.Domains.Users
{
    public sealed class PhoneNumber
    {
        private string _text;

        public PhoneNumber(string text)
        {
            //if (string.IsNullOrWhiteSpace(text))
            //    throw new PhoneNumberShouldNotBeEmptyException("The 'PhoneNumber' field is required");

            this._text = text;
        }

        public override string ToString()
        {
            return _text.ToString();
        }

        public static implicit operator PhoneNumber(string text)
        {
            return new PhoneNumber(text);
        }

        public static implicit operator string(PhoneNumber name)
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

            return ((PhoneNumber)obj)._text == _text;
        }

        public override int GetHashCode()
        {
            return _text.GetHashCode();
        }
    }
}
