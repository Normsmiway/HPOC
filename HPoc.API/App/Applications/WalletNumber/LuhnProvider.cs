namespace App.Applications.WalletNumbers
{
    public static class LuhnProvider
    {
        public static string Luhnify(string number)
        {
            var sum = 0;
            var alt = true;
            var digits = number.ToCharArray();
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                var curDigit = (digits[i] - 48);
                if (alt)
                {
                    curDigit *= 2;
                    if (curDigit > 9)
                        curDigit -= 9;
                }
                sum += curDigit;
                alt = !alt;
            }
            if ((sum % 10) == 0)
            {
                return "0";
            }
            return (10 - (sum % 10)).ToString();
        }

        public static bool Validate(string number)
        {
            var total = 0;
            var alt = false;
            var digits = number.ToCharArray();
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                var curDigit = (int)char.GetNumericValue(digits[i]);
                if (alt)
                {
                    curDigit *= 2;
                    if (curDigit > 9)
                        curDigit -= 9;
                }
                total += curDigit;
                alt = !alt;
            }
            return total % 10 == 0;
        }
    }
}
