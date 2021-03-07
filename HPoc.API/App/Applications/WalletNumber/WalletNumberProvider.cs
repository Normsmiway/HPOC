
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Applications.WalletNumbers
{
    public class WalletNumberProvider
    {

        /// <summary>
        /// Pinzoint Generated Pin from Luhn Angorithm
        /// </summary>
        public string Luhn { get; private set; }

        /// <summary>
        /// This is User Pin => Pinzoint Prefix+LuhnValue
        /// </summary>
        public string Number { get; private set; }

        public Guid UserId { get; private set; }

        /// <summary>
        /// Ramdom generated alphanumeric sequence
        /// </summary>
        public string Raw { get; private set; }

        /// <summary>
        /// Extracted Digits from Raw
        /// </summary>
        public string RawDigit { get; set; }

        /// <summary>
        /// Digit required to make generated RawDigit a valid Luhn
        /// </summary>
        public string LuhnDigit { get; set; }

        // private readonly NumberGenerator _generator;
        private int MaxLength { get; set; }
        private NumberStrategy Strategy { get; set; }
        public WalletNumberProvider(int maxLength, NumberStrategy strategy = NumberStrategy.Raw)
        {
            MaxLength = maxLength;
            Strategy = strategy;
        }

        #region Pin generation Strategies
        private void GenerateRaw()
        {
            Raw = NumberGenerator.Generate(MaxLength).ToWalletNumber(MaxLength).Item1;
        }

        private void GenerateLuhn()
        {
            (Raw, RawDigit) = NumberGenerator.Generate(MaxLength - 1).ToWalletNumber(MaxLength);
            LuhnDigit = LuhnProvider.Luhnify(RawDigit);
            Luhn = string.Concat(RawDigit, LuhnDigit);
        }

        private void Generate()
        {
            switch (Strategy)
            {
                case NumberStrategy.Raw:
                    GenerateRaw();
                    return;
                case NumberStrategy.Luhn:
                    GenerateLuhn();
                    return;

            }
        }
        #endregion
        private void ValidateAndStorePin()
        {

            if (!string.IsNullOrEmpty(Luhn))
                ValidateLuhn(Luhn);

        }

        public bool ValidateLuhn(string number)
        {
            return LuhnProvider.Validate(number);
        }
        public string Provide(string prefix)
        {
            bool useRaw = Strategy == NumberStrategy.Raw;
            Generate();
            ValidateAndStorePin();

            Number = (!string.IsNullOrWhiteSpace(prefix)) ?
            string.Concat(prefix, useRaw ? Raw : Luhn) : useRaw ? Raw : Luhn;

            return Number;
        }

    }

    public enum NumberStrategy
    {
        Raw,
        Luhn
    }
}




