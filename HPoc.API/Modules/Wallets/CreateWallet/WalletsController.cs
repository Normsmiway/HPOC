using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HPoc.API.Modules.Wallets.CreateWallet
{

    public sealed class WalletsController : BaseController
    {
        [HttpPost("create", Name = "NewWallet")]
        public async Task<IActionResult> Post([FromBody] CreateWalletRequest request)
        {
            return await Task.FromResult(CreatedAtRoute("GetWalletDetails",
                new { walletId = "351525T" },
                new
                {
                    Name = "Savings",
                    Type = request.Type,
                    CurrencyCode = "NGN",
                    WalletNumber = "234222T",
                    AvalilableBalance = request.InitialAmount
                }));
        }
    }
}
