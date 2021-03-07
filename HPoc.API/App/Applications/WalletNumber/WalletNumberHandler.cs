using App.Domains.ValueObjects;
using System.Threading.Tasks;

namespace App.Applications.WalletNumbers
{
    public class WalletNumberHandler : IWalletNumberHandler
    {

        private readonly WalletNumberContext _context;
        private WalletNumberProvider _provider;
        private readonly string prefix = string.Empty;
        private readonly NumberStrategy strategy;
        private readonly int maxNumberOfterations = 0;
        private int iterations = 0;
        private readonly int incrementalValue = 0;
        private readonly string fallBackStrategy = string.Empty;

        public WalletNumberHandler(WalletNumberContext context)
        {
            bool useRaw = false;
            fallBackStrategy = "Luhn";
            int maxLength = 8;
            prefix = "HAL";
            maxNumberOfterations =10;
            incrementalValue = 1;
            strategy =useRaw ? NumberStrategy.Raw : NumberStrategy.Luhn;
            _provider = new WalletNumberProvider(maxLength, strategy);
            _context = context;
        }
        /// <summary>
        /// Recursive Pin Generation mechanism
        /// This method us two basic approach:
        /// 1. Uses Raw strategy to geneerate user pin 
        ///     Advantage: Has a lager search space: i.e reduced
        ///     rate of duplication event with short length pin
        ///     Disadvantage: Generated pin can't be verified
        /// 2. Uses Luhn strategy to geneerate user pin 
        ///    Advantage: Generated pin can't be verified using Luhn algorithm
        ///    Disadvantage: Shorter search space, slower in performace
        /// <param name="userId"></param>
        /// <returns>string</returns>
        public async Task<WalletNumber> GenerateAsync()
        {
            #region NOTE: TODO
            //exit point from a recursive function: use other strategy after
            //failure to generate unique pin over certain iterations specified
            //NOTE: This is a point of failure, as the system can't gurantee the 
            //sequence generated will be unique at this point: Dude find a better way
            #endregion
            if (iterations == maxNumberOfterations)
                return fallBackStrategy == nameof(NumberStrategy.Luhn)
                    ? await GenerateDigitOnlyPin()
                    : await GenereteAlphanumericSequence();

            var (sequence, isUnique) = await GeneratePinAsync();

            if (isUnique)
                return sequence;

            iterations += 1;
            return await GenerateAsync();
        }




        private async Task<(string, bool)> GeneratePinAsync()
        {
            // _provider=new PinProvider(_options.Length, pinStrategy);
            string number = _provider.Provide(prefix);
            bool exists = await _context.NumberExistsAsync(number);

            if (!exists)
            {
                var walletNumber = new WalletNumber(number);
                await _context.AddAsync(walletNumber);
            }
            return (number, !exists);
        }

        /// <summary>
        /// This uses Raw strategy to geneerate user pin 
        /// Advantage: Has a lager search space: i.e reduced
        /// rate of duplication event with short length pin
        /// Disadvantage: Generated pin can't be verified
        /// </summary>
        /// <param name="userId">UserId used in generating user pin</param>
        private async Task<string> GenereteAlphanumericSequence()
        {
            _provider = new WalletNumberProvider(8, NumberStrategy.Raw);
            var param = await GeneratePinAsync();

            return param.Item1;
        }

        /// <summary>
        /// This uses Luhn strategy to geneerate user pin 
        /// Advantage: Generated pin can't be verified using Luhn algorithm
        /// Disadvantage: Shorter search space, slower in performace
        /// </summary>
        /// <param name="userId">UserId used in generating user pin</param>
        private async Task<string> GenerateDigitOnlyPin()
        {
            _provider = new WalletNumberProvider(8+ incrementalValue, NumberStrategy.Luhn);
            var param = await GeneratePinAsync();

            return param.Item1;
        }
    }

}
