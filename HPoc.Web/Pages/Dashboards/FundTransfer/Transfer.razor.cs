using FluentValidation;
using HPoc.Web.Requests;
using HPoc.Web.Results;
using HPoc.Web.Sevices;
using HPoc.Web.Validators;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;
using System;
using System.Text;
using System.Threading.Tasks;

namespace HPoc.Web.Pages.Dashboards.FundTransfer
{
    public partial class Transfer : ComponentBase
    {
        double amount = 0;
        const int numberLength = 8;
        const string RegexForValidation = "^[A-Z]{3}[0-9]{3,9}";
        [Inject] IDialogService DialogService { get; set; }
        [Parameter] public string SenderWalletNumber { get; set; }
        [Parameter] public string Narration { get; set; }
        //  [Parameter]public decimal Amount { get; set; }
        public UserDetailsResult UserDetailModel { get; private set; } = new();
        [Inject] IHalalWalletClient WalletClient { get; set; }
        [Inject] NavigationManager Navigator { get; set; }
        public TransferModel Model = new();
        bool success;
        string walletUserName = string.Empty;
        private async Task OnValidSubmit(EditContext context)
        {
            var request = new FundtransferRequest()
            {
                Amount = Convert.ToDecimal(amount.ToString()),
                SendingNumber = SenderWalletNumber,
                RecievingNumber = Model.ReceiverWalletNumber,
                Narration = Narration
            };
            var result = await WalletClient.TrasnferFund(request);
            if (!string.IsNullOrWhiteSpace(result.ReceiverWalletNumber))
            {
                StringBuilder builder = new();
                builder.Append($"Your Transfer to {result.ReceiverWalletNumber} was successful").AppendLine().AppendLine();

                builder.AppendLine($"{result.Transaction.Currency} {result.Transaction.Amount.ToString($"0,0.00")}").AppendLine();
                builder.AppendLine($"{result.ReceiverName.ToUpperInvariant()}");
                builder.AppendLine($"{result.ReceiverWalletNumber.ToUpperInvariant()}");
                builder.AppendLine($"_______________________________________________________").AppendLine();
                builder.AppendLine($"Refrence\n: {result.Transaction.MarchantReference}");
                builder.AppendLine($"Date\n:{result.Transaction.TransactionDate:yyyy-MMM-dd hh:mm tt}");
                builder.AppendLine($"From\n:{result.From.ToUpperInvariant()}");

                var parameters = new DialogParameters
                {
                    { "ContentText", builder.ToString() },
                    { "ButtonText", "Yes" },
                    { "Color", Color.Success }
                };

                DialogService.Show<TransferDialog>("Transfer Successful", parameters);
            }
            else
            {
                var parameters = new DialogParameters
                {
                    { "ContentText", "Fund transfer failed" },
                    { "ButtonText", "Close" },
                    { "Color", Color.Error }
                };

                var options = new DialogOptions() { CloseButton = true, MaxWidth = MaxWidth.ExtraSmall };

                DialogService.Show<TransferDialog>("Transfer failed", parameters, options);
            }
            StateHasChanged();
        }

        public async Task KeyUp()
        {
            Model.ReceiverWalletNumber = Model.ReceiverWalletNumber.Trim()?.ToUpperInvariant();
            await MakeEnquiry();
        }

        public async Task MakeEnquiry()
        {
            if (Model?.ReceiverWalletNumber?.Length == numberLength)
            {
                success = true;
                var result = await WalletClient.GetUserDetails(Model.ReceiverWalletNumber.Trim());

                walletUserName = !string.IsNullOrWhiteSpace(result?.Name) ? result?.Name : "No results found";
            }
        }

        readonly FluentValueValidator<string> walletNumberValidator = new(x => x
        .NotEmpty()
        .Length(8, 10)
        .Matches(RegexForValidation));

        void Subtract()
        {
            amount -= 500;
            if (amount < 0)
                amount = 0;
        }

        void Add()
        {
            amount += 500;
        }
    }

    public class TransferModel
    {
        public string SenderWalletNumber { get; set; } = string.Empty;
        public string ReceiverWalletNumber { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string Narration { get; set; } = string.Empty;
    }
}
