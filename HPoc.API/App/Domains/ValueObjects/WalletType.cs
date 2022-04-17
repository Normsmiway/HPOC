

using Newtonsoft.Json;

namespace App.Domains.ValueObjects
{
    public sealed class WalletType
    {
        public string Value { get;  set; }

        [JsonConstructor]
        public WalletType(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new WalletNumberShouldNotBeEmptyException("WalletType is required");
            Value = value;

        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public static implicit operator WalletType(string text)
            => new WalletType(text);

        public static implicit operator string(WalletType number)
            => number.Value;

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

            return ((WalletType)obj).Value == Value;
        }

        public override int GetHashCode()
            => Value.GetHashCode();

    }
}
