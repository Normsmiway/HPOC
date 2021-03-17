using Microsoft.AspNetCore.Components;

namespace HPoc.Web.Pages.Dashboards
{
    public partial class Money : ComponentBase
    {
        [Parameter] public MoneyModel Model { get; set; } = new();
    }


    public class MoneyModel
    {
        public double Value { get; set; }
        public string Text { get; set; }
        public double Percentage { get; set; }
    }
}
