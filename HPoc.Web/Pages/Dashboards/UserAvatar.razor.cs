using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;

namespace HPoc.Web.Pages.Dashboards
{
    public partial class UserAvatar : ComponentBase
    {
        [Parameter] public string Name { get; set; }

        private string name { get; set; }
        public string Avatar
        {
            get
            {
                List<string> names = Name.Split(" ").ToList();
                if (names.Count > 1)
                {
                    name = names[0];
                    return $"{names[0][0]}{names[1][0]}";
                }
                else
                {
                    name = Name;
                    return Name[0].ToString();
                }

            }
        }
    }
}
