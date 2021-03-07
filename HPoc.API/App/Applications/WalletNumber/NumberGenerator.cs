using System;
using System.Linq;

namespace App.Applications.WalletNumbers
{
    public static class NumberGenerator
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reference"></param>
        /// <param name="maxLength"></param>
        /// <param name="range"></param>
        /// <returns></returns>
        public static (string, string) ToWalletNumber(this string reference, int maxLength = 19, int range = 100)
        {
            if (string.IsNullOrEmpty(reference))
            {
                reference = Generate(Guid.NewGuid(), maxLength);
            }
            var digitsOnly = string.Concat(reference.Where(c => !char.IsLetter(c))).ToString();
            digitsOnly = digitsOnly.ExtractAndNormalize(maxLength, range);
            return (reference, digitsOnly);
        }

        private static string ExtractAndNormalize(this string numbersOnly, int maxLength = 20, int range = 100)
        {
            if (numbersOnly.Length < maxLength)
            {
                for (int i = 0; i < maxLength - numbersOnly.Length; i++)
                {
                    var num = new Random(range).Next().ToString();
                    numbersOnly += num;
                }
                numbersOnly = numbersOnly.Length >= maxLength ? numbersOnly.Substring(0, maxLength - 1) : numbersOnly;
            }

            return numbersOnly;
        }

        public static string Generate(Guid id, int length = 20)
        {
            return Guid.NewGuid().ToString().Replace("-", "").Substring(0, length).ToUpper();
        }

        public static string Generate(int length = 20)
        {
            return Guid.NewGuid().ToString().Replace("-", "").Substring(0, length).ToUpper();

        }

    }
}
