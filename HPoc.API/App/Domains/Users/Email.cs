using Newtonsoft.Json;

namespace App.Domains.Users
{
    public sealed class Email
    {
        public  string Value { get; private set; }
        [JsonConstructor]
        public Email(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new EmailShouldNotBeEmptyException("The 'Email' field is required");

            this.Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public static implicit operator Email(string text)
        {
            return new Email(text);
        }

        public static implicit operator string(Email name)
        {
            return name.Value;
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

            return ((Email)obj).Value == Value;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}
