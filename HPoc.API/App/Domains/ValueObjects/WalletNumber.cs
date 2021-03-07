using System;
using System.Text.RegularExpressions;

namespace App.Domains.ValueObjects
{
    public sealed class WalletNumber:IAggregateRoot<Guid>
    {
        public Guid Id { get; set; }
        public string Text { get; private set; }
        const string RegexForValidation = "^[A-Z]{3}[0-9]{6,9}";


        public WalletNumber(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                throw new WalletNumberShouldNotBeEmptyException("WalletNumber is required");


            if (!Regex.IsMatch(text, RegexForValidation))
                throw new InvalidWalletNumberException("Invalid wallet number format. Use XXX000000 format");
            Id = Guid.NewGuid();
            Text = text;

        }

        public override string ToString()
        {
            return Text.ToString();
        }

        public static implicit operator WalletNumber(string text)
            => new WalletNumber(text);


        public static implicit operator string(WalletNumber number)
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

            return ((WalletNumber)obj).Text == Text;
        }

        public override int GetHashCode()
            => Text.GetHashCode();

    }
}
