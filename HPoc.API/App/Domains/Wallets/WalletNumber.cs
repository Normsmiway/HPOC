using App.Domains.ValueObjects;
using Newtonsoft.Json;
using System;
using System.Text.RegularExpressions;

namespace App.Domains
{
    public sealed class WalletNumber:IAggregateRoot<Guid>
    {
        public Guid Id { get; set; }
        public string Value { get; private set; }
        const string RegexForValidation = "^[A-Z]{3}[0-9]{3,9}";

        [JsonConstructor]
        public WalletNumber(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new WalletNumberShouldNotBeEmptyException("WalletNumber is required");


            if (!Regex.IsMatch(value, RegexForValidation))
                throw new InvalidWalletNumberException("Invalid wallet number format. Use XXX000 format");
            Id = Guid.NewGuid();
            Value = value;

        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public static implicit operator WalletNumber(string text)
            => new(text);


        public static implicit operator string(WalletNumber number)
            => number.Value;

        public override bool Equals(object obj)
        {
            if (obj is null)
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

            return ((WalletNumber)obj).Value == Value;
        }

        public override int GetHashCode()
            => Value.GetHashCode();

    }
}
