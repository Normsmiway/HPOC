using App.Applications.UseCases.FundWallets;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HPoc.API.Modules.Wallets.FundWallet
{
    public sealed class WalletsController : BaseController
    {
        private readonly IFundWallet _fundWallet;
        public WalletsController(IFundWallet fundWallet)
        {
            _fundWallet = fundWallet;
        }

        [HttpPatch("fund", Name = nameof(FundWallet))]
        public async Task<IActionResult> FundWallet([FromBody] FundWalletRequest request)
        {
            FundingResult result = await _fundWallet.Execute(request.WalletId, request.Amount);
            return GetFundingResult(result);
        }
        [HttpPatch("fund/by-number", Name = nameof(FundWalletByNumber))]
        public async Task<IActionResult> FundWalletByNumber([FromBody] FundWalletRequestNumber request)
        {
            FundingResult result = await _fundWallet.Execute(request.WalletNumber, request.Amount);
            return GetFundingResult(result);
        }


        #region
        private static IActionResult GetFundingResult(FundingResult result)
        {
            if (result is null)
                return new NoContentResult();

            Model model = new Model(result.Transaction.Amount,
                result.Transaction.TranactionType,
                result.Transaction.TransactionDate,
                result.CurrentBalace, result.Transaction.Reference,
                result.Transaction.Narration);

            return new OkObjectResult(model);
        }

        #endregion
    }
}
