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
        [HttpGet("details/walletId/{walletId}", Name = "GetWalletDetails")]
        public async Task<IActionResult> GetWalletDetails(Guid walletId)
        {
            var wallet = await _queries.GetWalletAsync(walletId);
            List<TransactionModel> transactions = new();

            return GetWalletDetails(wallet, transactions);
        }

        [HttpGet("details/{walletNumber}", Name = "GetWalletDetailsByNumber")]
        public async Task<IActionResult> GetWalletDetailsByNumber(string walletNumber)
        {
            var wallet = await _queries.GetWalletAsync(walletNumber);
            List<TransactionModel> transactions = new();

            return GetWalletDetails(wallet, transactions);
        }

        #region private helper
        private static IActionResult GetWalletDetails(App.Applications.Results.WalletResult wallet, List<TransactionModel> transactions)
        {
            foreach (var item in wallet.Transactions)
            {
                var transaction = new TransactionModel(
                    item.Amount, item.TranactionType,
                    item.TransactionDate, item.Narration,
                    item.Reference,item.MarchantReference);

                transactions.Add(transaction);
            }


            return new OkObjectResult(new
                WalletDetailsModel(wallet.WalletId,wallet.WalletNumber, wallet.CurrentBalance,
                wallet.TotalIncome, wallet.TotalExpenses,
                wallet.CurrencyCode, wallet.WalletType,
                transactions));
        }
        #endregion
    }
}
