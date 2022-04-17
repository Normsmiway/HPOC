using App.Applications.UseCases.FundWallets;
using Microsoft.AspNetCore.Mvc;
using System;
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

        [ApiExplorerSettings(IgnoreApi = true)]
        [HttpPatch("fund/walletId", Name = nameof(FundWallet))]
        public async Task<IActionResult> FundWallet([FromBody] FundWalletRequest request)
        {
            FundingResult result = await _fundWallet.Execute(request.WalletId, request.Amount,Guid.NewGuid().ToString().ToUpperInvariant());
            return GetFundingResult(result);
        }
        [HttpPatch("fund", Name = nameof(FundWalletByNumber))]
        public async Task<IActionResult> FundWalletByNumber([FromBody] FundWalletRequestNumber request)
        {
            FundingResult result = await _fundWallet.Execute(request.WalletNumber, request.Amount,Guid.NewGuid().ToString().ToUpperInvariant());
            return GetFundingResult(result);
        }


        #region
        private static IActionResult GetFundingResult(FundingResult result)
        {
            if (result is null)
                return new NoContentResult();

            Model model = new(result.Transaction.Amount,
                result.Transaction.TranactionType,
                result.Transaction.TransactionDate,
                result.CurrentBalace, result.Transaction.Reference,
                result.Transaction.Narration);

            return new OkObjectResult(model);
        }

        #endregion
    }
}
