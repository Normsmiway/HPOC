using App.Applications.UseCases.Transfer;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HPoc.API.Modules.Wallets.Transfers
{
    public sealed class WalletsController : BaseController
    {
        private readonly IFundTransfer _fundTransfer;

        public WalletsController(IFundTransfer fundTransfer)
        {
            _fundTransfer = fundTransfer;
        }
        [HttpPost("transfer", Name = nameof(TransferFund))]
        public async Task<IActionResult> TransferFund([FromBody] FundTransferRequest request)
        {
            try
            {
                var result = await _fundTransfer.Execute(request.SendingWalletId,
                              request.RecievingWalletId, request.Amount, request.Narration);

                if (result is null) { return new NotFoundResult(); }

                return Ok(result);
            }
            catch (System.Exception ex)
            {
                throw;
            }

        }


        [HttpPost("transfer/by-number", Name = nameof(TransferFundByNumber))]
        public async Task<IActionResult> TransferFundByNumber([FromBody] FundTransferbyNumberRequest request)
        {
            try
            {
                var result = await _fundTransfer.Execute(request.SendingNumber,
                              request.RecievingNumber, request.Amount, request.Narration);

                if (result is null) { return new NotFoundResult(); }

                return Ok(result);
            }
            catch (System.Exception ex)
            {
                throw;
            }

        }
    }
}
