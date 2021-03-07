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
        public async Task<IActionResult> FundWallet([FromBody]FundWalletRequest request)
        {
            FundingResult result = await _fundWallet.Execute(request.WalletId, request.Amount);

            if (result is null)
                return new NoContentResult();

            Model model = new Model(result.Transaction.Amount,
                result.Transaction.TranactionType,
                result.Transaction.TransactionDate,
                result.CurrentBalace, result.Transaction.Reference,
                result.Transaction.Narration);

            return new OkObjectResult(model);
        }
    }
}
