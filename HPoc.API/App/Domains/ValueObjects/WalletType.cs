namespace App.Domains.ValueObjects
{
    public sealed class WalletType
    {
        public string Text { get; private set; }

        public WalletType(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new WalletNumberShouldNotBeEmptyException("WalletType is required");
            Text = text;

        }

        public override string ToString()
        {
            return Text.ToString();
        }

        public static implicit operator WalletType(string text)
            => new WalletType(text);

        public static implicit operator string(WalletType number)
            => number.Text;

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
                return obj.ToString() == Text;
            }

            return ((WalletType)obj).Text == Text;
        }

        public override int GetHashCode()
            => Text.GetHashCode();

    }
}
