
using Newtonsoft.Json;

namespace App.Domains.Users
{
    public sealed class Name
    {
        public string  Value { get; private set; }

        [JsonConstructor]
        public Name(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new NameShouldNotBeEmptyException("The 'Name' field is required");

            this.Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public static implicit operator Name(string text)
        {
            return new Name(text);
        }

        public static implicit operator string(Name name)
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

            return ((Name)obj).Value == Value;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}
