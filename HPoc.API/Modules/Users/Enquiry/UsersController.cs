using App.Applications.UseCases.GetUsers;
using HPoc.API.Modules.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HPoc.API.Modules.Users.Enquiry
{

    public sealed class UsersController : BaseController
    {
        private readonly IUserQueries _queries;

        public UsersController(IUserQueries queries)
        {
            _queries = queries;
        }
        [HttpGet("details/{userId}", Name = "GetUserDetails")]
        public async Task<IActionResult> GetUser(Guid userId)
        {
            var user = await _queries.GetUser(userId);

            if (user is null) { return new NoContentResult(); }

            List<WalletDetailsModel> wallets = new List<WalletDetailsModel>();

            foreach (var wallet in user.WalletResults)
            {
                List<TransactionModel> transactions = new List<TransactionModel>();

                foreach (var item in wallet.Transactions)
                {
                    var transaction = new TransactionModel(
                        item.Amount, item.TranactionType,
                        item.TransactionDate,
                        item.Narration,
                        item.Reference);
                    transactions.Add(transaction);
                }
                wallets.Add(new WalletDetailsModel(
                    wallet.WalletId,
                    wallet.CurrentBalance,
                    wallet.TotalIncome,
                    wallet.TotalExpenses,
                    wallet.CurrencyCode,
                    wallet.WalletType,
                    transactions));
            }

            UserDetailsModel model = new UserDetailsModel(
                user.UserId,
                user.PhoneNumber,
                user.Email,
                user.Name,
                DateTime.Today.AddYears(-18),
                wallets);

            return Ok(model);
        }
    }
}
