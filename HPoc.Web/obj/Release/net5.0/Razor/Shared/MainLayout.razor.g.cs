#pragma checksum "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a594437e7f2c542933e8eb435c18578d49f64d0a"
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style b-imemtld43k>
        .example-scroll-section {
            height: 100%;
            overflow: auto;
            padding: 0px;
        }

        .example-inner-section {
            height: 100%;
            display: flex;
            flex-direction: column;
            justify-content: space-between;
            padding: 3em;
        }

            .example-inner-section > h1, .example-inner-section > h2 {
                text-align: center;
            }

        .visible-custom-position {
            right: 80px;
            bottom: 40px;
            position: absolute;
            transition: all .2s;
        }

        .hidden-custom-position {
            right: -100px;
            visibility: hidden;
        }
    </style>
");
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(1);
            __builder.CloseComponent();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudLayout>(3);
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudAppBar>(5);
                __builder2.AddAttribute(6, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 36 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\MainLayout.razor"
                          1

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(8);
                    __builder3.AddAttribute(9, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\MainLayout.razor"
                              Icons.Material.Filled.Menu

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(10, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 37 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\MainLayout.razor"
                                                                 Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(11, "Edge", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Edge>(
#nullable restore
#line 37 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\MainLayout.razor"
                                                                                      Edge.Start

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(12, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\MainLayout.razor"
                                                                                                             (e) => DrawerToggle()

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(13, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudText>(14);
                    __builder3.AddAttribute(15, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 38 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\MainLayout.razor"
                       Typo.h5

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(16, "Class", "ml-3");
                    __builder3.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(18, "Halal Pay Dashboard");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(19, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudAppBarSpacer>(20);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(21, " \r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudMenu>(22);
                    __builder3.AddAttribute(23, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 40 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\MainLayout.razor"
                        Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(24, "ActivatorContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudAvatar>(25);
                        __builder4.AddAttribute(26, "Image", "https://i.picsum.photos/id/1074/5472/3648.jpg?hmac=w-Fbv9bl0KpEUgZugbsiGk3Y2-LGAuiLZOYsRk0zo4A");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudMenuItem>(28);
                        __builder4.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(30, "Profile");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(31, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudMenuItem>(32);
                        __builder4.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(34, "Theme");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(35, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudMenuItem>(36);
                        __builder4.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(38, "Usage");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(39, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudMenuItem>(40);
                        __builder4.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(42, "Sign Out");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudIconButton>(44);
                    __builder3.AddAttribute(45, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 51 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\MainLayout.razor"
                              Color.Inherit

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(46, "Edge", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Edge>(
#nullable restore
#line 51 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\MainLayout.razor"
                                                   Edge.End

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudDrawer>(48);
                __builder2.AddAttribute(49, "ClipMode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.DrawerClipMode>(
#nullable restore
#line 54 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\MainLayout.razor"
                                                  DrawerClipMode.Always

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 54 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\MainLayout.razor"
                                                                                    2

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "Open", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 54 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\MainLayout.razor"
                           _drawerOpen

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "OpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _drawerOpen = __value, _drawerOpen))));
                __builder2.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<HPoc.Web.Shared.NavMenu>(54);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudMainContent>(56);
                __builder2.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(58, "div");
                    __builder3.AddAttribute(59, "class", "example-scroll-section");
                    __builder3.AddAttribute(60, "id", "unique_id_scroll_section");
                    __builder3.AddAttribute(61, "b-imemtld43k");
                    __builder3.AddContent(62, 
#nullable restore
#line 59 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddMarkupContent(63, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudScrollToTop>(64);
                    __builder3.AddAttribute(65, "TopOffset", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 60 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\MainLayout.razor"
                                       100

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(66, "Style", "z-index:2000");
                    __builder3.AddAttribute(67, "VisibleCssClass", "visible-custom-position");
                    __builder3.AddAttribute(68, "HiddenCssClass", "hidden-custom-position");
                    __builder3.AddAttribute(69, "Selector", "#unique_id_scroll_section");
                    __builder3.AddAttribute(70, "OnScroll", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<MudBlazor.ScrollEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<MudBlazor.ScrollEventArgs>(this, 
#nullable restore
#line 65 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\MainLayout.razor"
                                      OnScroll

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(71, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudFab>(72);
                        __builder4.AddAttribute(73, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 66 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\MainLayout.razor"
                               Color.Secondary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(74, "Style", "float:right");
                        __builder4.AddAttribute(75, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 66 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\MainLayout.razor"
                                                                           Icons.Material.Filled.Add

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(76, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 67 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\MainLayout.razor"
                              Size.Large

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(77, "IconSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 67 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\MainLayout.razor"
                                                    Size.Large

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(78, "Class", "ma-2");
                        __builder4.AddAttribute(79, "Target", "_top");
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Shared\MainLayout.razor"
       
    bool _drawerOpen = true;

    void DrawerToggle()
    {
        _drawerOpen = !_drawerOpen;
    }

    Color Color = Color.Success;
    private void OnScroll(ScrollEventArgs e)
    {
        Color = (e.FirstChildBoundingClientRect.Top * -1) switch
        {
            var x when x < 500 => Color.Primary,
            var x when x < 1500 => Color.Secondary,
            var x when x < 2500 => Color.Tertiary,
            _ => Color.Error
        };
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
