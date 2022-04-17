using Newtonsoft.Json;

namespace App.Domains.Users
{
    public sealed class PhoneNumber
    {
        public  string Value { get; private set; }
        [JsonConstructor]
        public PhoneNumber(string value)
        {
            //if (string.IsNullOrWhiteSpace(text))
            //    throw new PhoneNumberShouldNotBeEmptyException("The 'PhoneNumber' field is required");

            this.Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public static implicit operator PhoneNumber(string text)
        {
            return new PhoneNumber(text);
        }

        public static implicit operator string(PhoneNumber name)
        {
            return name?.Value;
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
                return obj.ToString() == Value;
            }

            return ((PhoneNumber)obj).Value == Value;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}
