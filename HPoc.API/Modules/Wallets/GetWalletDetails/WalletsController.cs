using App.Applications.UseCases.GetWallets;
using HPoc.API.Modules.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;


namespace HPoc.API.Modules.Wallets.GetWalletDetails
{
    public sealed class WalletsController : BaseController
    {
        private readonly IWalletQueries _queries;
        public WalletsController(IWalletQueries queries)
        {
            _queries = queries;
        }
        [HttpGet("details/{walletId}", Name = "GetWalletDetails")]
        public async Task<IActionResult> GetWallet(Guid walletId)
        {
            var wallet = await _queries.GetWalletAsync(walletId);
            List<TransactionModel> transactions = new List<TransactionModel>();

            foreach (var item in wallet.Transactions)
            {
                var transaction = new TransactionModel(
                    item.Amount, item.TranactionType,
                    item.TransactionDate, item.Narration,
                    item.Reference);

                transactions.Add(transaction);
            }


            return new OkObjectResult(new
                WalletDetailsModel(wallet.WalletId, wallet.CurrentBalance,
                wallet.TotalIncome, wallet.TotalExpenses,
                wallet.CurrencyCode, wallet.WalletType,
                transactions));
        }
    }

    public class WalletDetailsResultModel
    {
        public string Type { get; set; }
        public string CurrencyCode { get; set; }
        public string Name { get; set; }
        public string WalletNumber { get; set; }
    }
}
