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
        [HttpPost("withrawfund", Name = nameof(WithrawFund))]
        public async Task<IActionResult> WithrawFund([FromBody] WithFundRequest request)
        {
            var result = await _withdrawal.Execute(request.WalletId, request.Amount, request.Narration);

            if(result is null) { return new NoContentResult(); }

            WithdrawalResultModel model = new WithdrawalResultModel(
                result.Transaction.Amount,
                result.Transaction.TranactionType,
                result.Transaction.TransactionDate,
                result.CurrentBalace,
                result.Transaction.Narration,
                result.Transaction.Reference);

            return Ok(model);
        }
    }
}
