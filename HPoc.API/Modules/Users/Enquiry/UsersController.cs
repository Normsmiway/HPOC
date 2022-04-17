using App.Applications.Results;
using App.Applications.UseCases.GetUsers;
using App.Domains.Wallets;
using HPoc.API.Modules.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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

        [HttpGet("details", Name = "GetUsers")]
        public async Task<IActionResult> GetUsers()
        {
            List<UserDetailsModel> usersDetails = new();
            var users = await _queries.GetUsersAsync();
            users.ForEach(user =>
            {
                usersDetails.Add(GetUserDetails(user));
            });
            return Ok(usersDetails);
        }
        [HttpGet("details/walletNumer/{walletNumer}", Name = "GetWalletOwnder")]
        public async Task<IActionResult> GetWalletOwnder(string walletNumer)
        {

            var ownser = await _queries.GetUserDetailsAsync(walletNumer);
            return Ok(ownser);
        }
        [HttpGet("details/{userId}", Name = "GetUserDetails")]
        public async Task<IActionResult> GetUser(Guid userId)
        {
            var user = await _queries.GetUserAsync(userId);

            if (user is null) { return new NoContentResult(); }

            UserDetailsModel model = GetUserDetails(user);

            return Ok(model);
        }

        #region private helper methods
        private static UserDetailsModel GetUserDetails(UserResult user)
        {
            List<WalletDetailsModel> wallets = new();
            foreach (var wallet in user.WalletResults)
            {
                List<TransactionModel> transactions = new();

                foreach (var item in wallet.Transactions)
                {
                    if (item.TranactionType == nameof(Debit))
                    {
                        var benref = item.MarchantReference;
                    }

                    TransactionModel transaction = new (
                        item.Amount, item.TranactionType,
                        item.TransactionDate,
                        item.Narration,
                        item.Reference,
                        item.MarchantReference);
                    transactions.Add(transaction);
                }
                wallets.Add(new(
                    wallet.WalletId,
                    wallet.WalletNumber,
                    wallet.CurrentBalance,
                    wallet.TotalIncome,
                    wallet.TotalExpenses,
                    wallet.CurrencyCode,
                    wallet.WalletType,
                    transactions));
            }
           

            UserDetailsModel model = new(
                user.UserId,
                user.PhoneNumber,
                user.Email,
                user.Name,
                DateTime.Today.AddYears(-18),
                wallets,
                user.Beneficiaries.ToList());
            return model;
        }
        #endregion
    }
}
