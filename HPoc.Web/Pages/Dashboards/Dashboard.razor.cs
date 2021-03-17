using HPoc.Web.Results;
using HPoc.Web.Sevices;
using HPoc.Web.Tools;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPoc.Web.Pages.Dashboards
{
    public partial class Dashboard : ComponentBase
    {


        private string Narrattion { get { return $"Fund transfer from {Profile.Name}"; } }
        [Inject] Store _store { get; set; }
        public RegisterationResult Result { get; set; } = new();
        public UserDetailsResult Profile { get; set; } = new();
        public List<MoneyModel> MoneyModels { get; set; } = new();
        List<UserDetailsResult> Beneficiaries { get; set; } = new();
        List<TransactionResult> Transactions { get; set; } = new();
        [Inject] IHalalWalletClient WalletClient { get; set; }
        protected async override Task OnInitializedAsync()
        {
            Profile = _store.CurrentUser ?? new();
            Result = _store.RegistredUsers.Where(c =>
           c.User.UserId == Profile.UserId).FirstOrDefault() ?? new();
            RefreshUserDetails();
        }

        //protected async override Task OnAfterRenderAsync(bool firstRender)
        //{
        //    // Profile = _store.CurrentUser ?? new();
        //    Result = _store.RegistredUsers.Where(c =>
        //   c.User.UserId == Profile.UserId).FirstOrDefault() ?? new();

        //    RefreshUserDetails();
        //    StateHasChanged();
        //}



        async Task UpdateUI()
        {
            Result = _store.RegistredUsers.Where(c =>
            c.User.UserId == Profile.UserId).FirstOrDefault() ?? new();

            RefreshUserDetails();
            StateHasChanged();
        }
        private void RefreshUserDetails()
        {
            if (!MoneyModels.Any())
            {
                MoneyModels.Add(new MoneyModel()
                {
                    Text = "Balance",
                    Value = Convert.ToDouble(Result.Wallet.CurrentBalance.ToString()),
                    Percentage = 100
                });
                MoneyModels.Add(new MoneyModel()
                {
                    Text = "Total Expense",
                    Value = Convert.ToDouble(Result.Wallet.TotalExpenses.ToString()),
                    Percentage = 0
                });
                MoneyModels.Add(new MoneyModel()
                {
                    Text = "Total Income",
                    Value = Convert.ToDouble(Result.Wallet.TotalIncome.ToString()),
                    Percentage = 100
                });
                Beneficiaries = Result.User.Beneficiaries;
            }
            else
            {
                MoneyModels.ToArray()[0] = new MoneyModel()
                {
                    Text = "Balance",
                    Value = Convert.ToDouble(Result.Wallet.CurrentBalance.ToString()),
                    Percentage = 100
                };
                MoneyModels.ToArray()[1] = new MoneyModel()
                {
                    Text = "Total Expense",
                    Value = Convert.ToDouble(Result.Wallet.TotalExpenses.ToString()),
                    Percentage = 0
                };

                MoneyModels.ToArray()[2] = new MoneyModel()
                {
                    Text = "Total Income",
                    Value = Convert.ToDouble(Result.Wallet.TotalIncome.ToString()),
                    Percentage = 100
                };

                Beneficiaries = Result.User.Beneficiaries;
                Result.Wallet.Transactions = Result.Wallet.Transactions;
            }

        }
        private MudTable<TransactionResult> table;

        private int totalItems;
        private string searchString = null;
        private async Task<TableData<TransactionResult>> ServerReload(TableState state)
        {
            int number = 0;
            IEnumerable<TransactionResult> data = Result.Wallet.Transactions;
            data = data.Where(transaction =>
            {
                if (string.IsNullOrWhiteSpace(searchString))
                    return true;
                if (transaction.Amount.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase))
                    return true;
                if (transaction.TranactionType.Contains(searchString, StringComparison.OrdinalIgnoreCase))
                    return true;
                if ($"{transaction.Amount} {transaction.Reference} {transaction.MarchantReference}".Contains(searchString))
                    return true;
                return false;
            }).ToArray();
            totalItems = data.Count();
            switch (state.SortLabel)
            {
                case "nr_field":
                    data = data.OrderByDirection(state.SortDirection, o => o.Number);
                    break;
                case "sign_field":
                    data = data.OrderByDirection(state.SortDirection, o => o.TranactionType);
                    break;
                case "name_field":
                    data = data.OrderByDirection(state.SortDirection, o => o.Narration);
                    break;
                case "position_field":
                    data = data.OrderByDirection(state.SortDirection, o => o.Reference);
                    break;
                case "mass_field":
                    data = data.OrderByDirection(state.SortDirection, o => o.TransactionDate);
                    break;
            }

            Transactions = data.Skip(state.Page * state.PageSize).Take(state.PageSize).ToList();
            return new TableData<TransactionResult>() { TotalItems = totalItems, Items = Transactions };
        }
        private void OnSearch(string text)
        {
            searchString = text;
            table.ReloadServerData();
        }
    }
}
