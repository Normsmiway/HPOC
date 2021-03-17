using HPoc.Web.Results;
using Microsoft.AspNetCore.Components;

namespace HPoc.Web.Pages.Dashboards.UserDetails
{
    public partial class UserDetail : ComponentBase
    {
        [Parameter] public UserDetailsResult Model { get; set; } = new();
    }
}
