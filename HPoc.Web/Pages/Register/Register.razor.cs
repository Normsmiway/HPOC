using HPoc.Web.Requests;
using HPoc.Web.Sevices;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace HPoc.Web.Pages.Register
{
    public partial class Register : ComponentBase
    {

        [Inject] IHalalWalletClient WalletClient { get; set; }
        const string currencyIcon = "₦";
        RegisterAccountForm model = new();
        bool success;

        string walletNumber = string.Empty;
        private async Task OnValidSubmit(EditContext context)
        {
            var request = new RegistrationRequest()
            {
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                InitialAmount = model.Amount,
                Name = model.Name
            };

            var result = await WalletClient.Register(request);
            if (!string.IsNullOrWhiteSpace(result.Wallet.WalletNumber))
            {
                success = true;
                walletNumber = result.Wallet.WalletNumber;
            }
        

            StateHasChanged();
        }

        string formatAmount = "0";

        // decimal amount = 0;

        readonly decimal[] initialAmounts = { 10000, 20000, 50000 };
        private void InitializeAmount(decimal amount)
        {

            model.Amount = amount;
            formatAmount = amount.ToString("0,0.00");
        }
        void FormatAmount(string value)
        {
            _ = decimal.TryParse(value.Replace(",", string.Empty), out decimal amnt);
            InitializeAmount(amnt);
        }
    }
    public class RegisterAccountForm
    {
        [Required]
        [StringLength(50, ErrorMessage = "Name length can't be more than 50.")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        public decimal Amount { get; set; } = 0;
    }
}
