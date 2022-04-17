using FluentValidation;
using HPoc.Web.Results;
using HPoc.Web.Sevices;
using HPoc.Web.Validators;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace HPoc.Web.Pages
{
    public partial class Index : ComponentBase
    {
        const int numberLength = 8;
        const string RegexForValidation = "^[A-Z]{3}[0-9]{3,9}";

        public UserDetailsResult UserDetailModel { get;private set; } = new();
        [Inject] IHalalWalletClient WalletClient { get; set; }
        [Inject] NavigationManager Navigator { get; set; }
        public LoginModel Model = new();
        bool success;
        string walletUserName = string.Empty;
        private async Task OnValidSubmit(EditContext context)
        {
            if (Model?.WalletNumber?.Length == numberLength)
            {

                var result = await WalletClient.GetUserDetails(Model.WalletNumber.Trim());
                walletUserName = !string.IsNullOrWhiteSpace(result?.Name) ? result?.Name : "No results found";

                success = !string.IsNullOrWhiteSpace(result?.Name) && string.CompareOrdinal(walletUserName, "No results found") != 0;
                if (success)
                {
                    UserDetailModel = result;

                    Navigator.NavigateTo("/dashboard");
                }

            }

            StateHasChanged();
        }

        public async Task KeyUp()
        {
            Model.WalletNumber = Model.WalletNumber?.Trim().ToUpperInvariant();
            await MakeEnquiry();
        }
      
        public async Task MakeEnquiry()
        {
            if (Model?.WalletNumber?.Length == numberLength)
            {
                Model.WalletNumber = Model.WalletNumber.Substring(0, numberLength);
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


    public class LoginModel
    {
        [Required(ErrorMessage = "Wallet number is required")]
        //[StringLength(10, ErrorMessage ="Wall")]
        public string WalletNumber { get; set; }
    }

}
