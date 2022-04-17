using FluentValidation;
using HPoc.Web.Results;
using HPoc.Web.Sevices;
using HPoc.Web.Validators;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace HPoc.Web.Pages.Dashboards
{
    public partial class WalletEnquiry : ComponentBase
    {
        string walletNumner = string.Empty;
        const int numberLength = 8;
        const string RegexForValidation = "^[A-Z]{3}[0-9]{3,9}";
        [Parameter] public EnquiryModel Model { get; set; } = new();
        public UserDetailsResult UserDetailModel { get; private set; } = new();
        [Inject] IHalalWalletClient WalletClient { get; set; }
        [Inject] NavigationManager Navigator { get; set; }

        bool success;
        string walletUserName = string.Empty;
        private async Task OnValidSubmit(EditContext context)
        {
            if (Model.WalletNumber?.Length == numberLength)
            {

                var result = await WalletClient.GetUserDetails(Model.WalletNumber.Trim());
                walletUserName = !string.IsNullOrWhiteSpace(result?.Name) ? result?.Name : "No results found";

                success = !string.IsNullOrWhiteSpace(result?.Name) && string.CompareOrdinal(walletUserName, "No results found") != 0;
                if (success)
                {
                    UserDetailModel = result;
                    //  Navigator.NavigateTo("/dashboard");
                }

            }

            StateHasChanged();
        }

        public async Task KeyUp()
        {
            if (!string.IsNullOrWhiteSpace(Model.WalletNumber))
            {
                Model.WalletNumber = Model.WalletNumber.Trim().ToUpperInvariant();
                await MakeEnquiry();
            }
        }

        public async Task MakeEnquiry()
        {
            if (Model.WalletNumber?.Length == numberLength)
            {
                success = true;
                var result = await WalletClient.GetUserDetails(Model.WalletNumber.Trim());

                walletUserName = !string.IsNullOrWhiteSpace(result?.Name) ? result?.Name : "No results found";
            }
        }

        readonly FluentValueValidator<string> walletNumberValidator = new(x => x
        .NotEmpty()
        .Length(8, 10)
        .Matches(RegexForValidation));
    }


    public class EnquiryModel
    {
        [Required(ErrorMessage = "Wallet Id is required")]
        public string WalletNumber { get; set; }
    }
}
