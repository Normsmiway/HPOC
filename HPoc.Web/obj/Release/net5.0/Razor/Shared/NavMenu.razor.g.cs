#pragma checksum "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c625e698fbf22b9830883b888ec515f4b029e629"
// <auto-generated/>
#pragma warning disable 1591
namespace HPoc.Web.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\_Imports.razor"
using HPoc.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\_Imports.razor"
using HPoc.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\_Imports.razor"
using MudBlazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\_Imports.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\_Imports.razor"
using HPoc.Web.Pages.Dashboards.UserDetails;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\_Imports.razor"
using HPoc.Web.Pages.Dashboards.FundTransfer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\_Imports.razor"
using HPoc.Web.Results;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudNavMenu>(0);
            __builder.AddAttribute(1, "Class", "mud-width-full");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudText>(3);
                __builder2.AddAttribute(4, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 3 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\NavMenu.razor"
                       Typo.h6

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "Class", "px-4");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudText>(7);
                __builder2.AddAttribute(8, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 4 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\NavMenu.razor"
                       Typo.body2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Class", "px-4 mud-text-secondary");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudDivider>(11);
                __builder2.AddAttribute(12, "Class", "my-2");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(14);
                __builder2.AddAttribute(15, "Href", "/dashboard");
                __builder2.AddAttribute(16, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 6 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\NavMenu.razor"
                                             Icons.Filled.Dashboard

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(18, "Dashboard");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(20);
                __builder2.AddAttribute(21, "Href", "/servers");
                __builder2.AddAttribute(22, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\NavMenu.razor"
                                           Icons.Filled.Storage

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(24, "Servers");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudNavLink>(26);
                __builder2.AddAttribute(27, "Href", "/billing");
                __builder2.AddAttribute(28, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 8 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\NavMenu.razor"
                                           Icons.Filled.Receipt

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 8 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\NavMenu.razor"
                                                                           true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(31, "Billing");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudNavGroup>(33);
                __builder2.AddAttribute(34, "Title", "Settings");
                __builder2.AddAttribute(35, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\NavMenu.razor"
                                             Icons.Filled.Settings

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "Expanded", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 9 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\NavMenu.razor"
                                                                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(38);
                    __builder3.AddAttribute(39, "Href", "/users");
                    __builder3.AddAttribute(40, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 10 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\NavMenu.razor"
                                             Icons.Filled.People

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(41, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 10 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\NavMenu.razor"
                                                                             Color.Success

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(43, "Users");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudNavLink>(45);
                    __builder3.AddAttribute(46, "Href", "/security");
                    __builder3.AddAttribute(47, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\NavMenu.razor"
                                                Icons.Filled.Security

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(48, "IconColor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 11 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\NavMenu.razor"
                                                                                  Color.Info

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(50, "Security");
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
