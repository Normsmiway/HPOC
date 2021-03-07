using App.Applications.UseCases.Deactivate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace HPoc.API.Modules.Wallets.CloseWallet
{
    public sealed class WalletsController : BaseController
    {
        private readonly IDeactivateAccount _service;
        public WalletsController(IDeactivateAccount deactivate)
        {
            _service = deactivate;
        }
        [HttpPost("{walletId}", Name = nameof(CloseWallet))]
        public async Task<IActionResult> CloseWallet(Guid walletId)
        {
            Guid deactivateResult = await _service.Execute(walletId);
            if (deactivateResult==Guid.Empty)
            {
                return new NoContentResult();
            }

            return Ok("Wallet Deactivated");
        }
    }
}
