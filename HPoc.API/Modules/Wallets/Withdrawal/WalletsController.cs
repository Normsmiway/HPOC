using App.Applications.UseCases.Withdrawal;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HPoc.API.Modules.Wallets.Withdrawal
{
    public sealed class WalletsController : BaseController
    {
        private readonly IWithdrawal _withdrawal;

        public WalletsController(IWithdrawal withdrawal)
        {
            _withdrawal = withdrawal;
        }
        [ApiExplorerSettings(IgnoreApi = true)]
        [HttpPost("withrawfund/walletId", Name = nameof(WithrawFund))]
        public async Task<IActionResult> WithrawFund([FromBody] WithdrawalFundRequest request)
        {
            var result = await _withdrawal.Execute(request.WalletId, request.Amount, request.Narration);

            return GetWithrawalResult(result);
        }

        [HttpPost("withrawfund", Name = nameof(WithrawFundByNumber))]
        public async Task<IActionResult> WithrawFundByNumber([FromBody] WithdrawalByNumberFundRequest request)
        {
            var result = await _withdrawal.Execute(request.WalletNumber, request.Amount, request.Narration);
            
            return GetWithrawalResult(result);
        }

        #region private helper methods
        private IActionResult GetWithrawalResult(WithdrawalResult result)
        {
            if (result is null) { return new NoContentResult(); }

            WithdrawalResultModel model = new(
                result.Transaction.Amount,
                result.Transaction.TranactionType,
                result.Transaction.TransactionDate,
                result.CurrentBalace,
                result.Transaction.Narration,
                result.Transaction.Reference);

            return Ok(model);
        }
        #endregion
    }
}
