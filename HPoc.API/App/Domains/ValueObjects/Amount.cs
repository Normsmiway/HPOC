using Newtonsoft.Json;
using System;

namespace App.Domains.ValueObjects
{
    public sealed class Amount
    {
        public decimal Value { get; private set; }

        [JsonConstructor]
        public Amount(decimal value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public static implicit operator decimal(Amount value)
        {
            return value.Value;
        }

        public static Amount operator -(Amount value)
        {
            return new Amount(Math.Abs(value.Value) * -1);
        }

        public static implicit operator Amount(decimal value)
        {
            return new Amount(value);
        }

        public static Amount operator +(Amount amount1, Amount amount2)
        {
            return new Amount(amount1.Value + amount2.Value);
        }

        public static Amount operator -(Amount amount1, Amount amount2)
        {
            return new Amount(amount1.Value - amount2.Value);
        }

        public static bool operator <(Amount amount1, Amount amount2)
        {
            return amount1.Value < amount2.Value;
        }

        public static bool operator >(Amount amount1, Amount amount2)
        {
            return amount1.Value > amount2.Value;
        }

        public static bool operator <=(Amount amount1, Amount amount2)
        {
            return amount1.Value <= amount2.Value;
        }

        public static bool operator >=(Amount amount1, Amount amount2)
        {
            return amount1.Value >= amount2.Value;
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

            if (obj is decimal)
            {
                return (decimal)obj == Value;
            }

            return ((Amount)obj).Value == Value;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }
}
