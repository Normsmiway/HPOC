#pragma checksum "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18c9e2891f6f99bd71e1716b69d9017fadfc3c3f"
// <auto-generated/>
#pragma warning disable 1591
namespace HPoc.Web.Pages.Register
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(EmptyLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudItem>(0);
            __builder.AddAttribute(1, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 4 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
             12

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "sm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 4 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                     6

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "md", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 4 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                            4

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudCard>(5);
                __builder2.AddAttribute(6, "Elevation", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 5 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                        25

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "Class", "rounded-lg pb-4");
                __builder2.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudCardHeader>(9);
                    __builder3.AddAttribute(10, "CardHeaderContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudText>(11);
                        __builder4.AddAttribute(12, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 8 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                               Typo.h5

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(13, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 8 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                               Align.Center

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(15, "Create Wallet Account");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(16, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudText>(17);
                        __builder4.AddAttribute(18, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 9 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                Align.Center

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(20, "Already have an account? ");
                            __builder5.OpenComponent<MudBlazor.MudLink>(21);
                            __builder5.AddAttribute(22, "Href", "/");
                            __builder5.AddAttribute(23, "Underline", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Underline>(
#nullable restore
#line 9 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                                                                                    Underline.Always

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(25, "Login");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddContent(26, " ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(27);
                    __builder3.AddAttribute(28, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                           model

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(29, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                                                 OnValidSubmit

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudCardContent>(31);
                        __builder4.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(33);
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(34, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudCard>(35);
                            __builder5.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudCardContent>(37);
                                __builder6.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
#nullable restore
#line 17 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                         if (!string.IsNullOrEmpty(walletNumber))
                        {

#line default
#line hidden
#nullable disable
                                    __builder7.OpenComponent<MudBlazor.MudAlert>(39);
                                    __builder7.AddAttribute(40, "Severity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Severity>(
#nullable restore
#line 19 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                                Severity.Success

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddContent(42, "Your wallet number is: ");
                                        __builder8.AddContent(43, 
#nullable restore
#line 19 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                                                                          walletNumber

#line default
#line hidden
#nullable disable
                                        );
                                    }
                                    ));
                                    __builder7.CloseComponent();
#nullable restore
#line 20 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                        }

#line default
#line hidden
#nullable disable
                                    __builder7.OpenComponent<MudBlazor.MudText>(44);
                                    __builder7.AddAttribute(45, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 21 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                        Align.Center

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
#nullable restore
#line 22 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                             foreach (var amount in initialAmounts)
                            {

#line default
#line hidden
#nullable disable
                                        __builder8.OpenComponent<MudBlazor.MudChip>(47);
                                        __builder8.AddAttribute(48, "Style", "color:coral;");
                                        __builder8.AddAttribute(49, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                                                       args=> { InitializeAmount(amount); }

#line default
#line hidden
#nullable disable
                                        )));
                                        __builder8.AddAttribute(50, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __builder9.AddContent(51, 
#nullable restore
#line 24 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                                                                                              currencyIcon

#line default
#line hidden
#nullable disable
                                            );
                                            __builder9.AddContent(52, " ");
                                            __builder9.AddContent(53, 
#nullable restore
#line 24 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                                                                                                            amount

#line default
#line hidden
#nullable disable
                                            );
                                        }
                                        ));
                                        __builder8.CloseComponent();
#nullable restore
#line 25 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                            }

#line default
#line hidden
#nullable disable
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(54, "\r\n\r\n                        ");
                                    __Blazor.HPoc.Web.Pages.Register.Register.TypeInference.CreateMudTextField_0(__builder7, 55, 56, "Set Amount Initial Amount", 57, 
#nullable restore
#line 28 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                                                                                             Variant.Outlined

#line default
#line hidden
#nullable disable
                                    , 58, 
#nullable restore
#line 29 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                                 Adornment.Start

#line default
#line hidden
#nullable disable
                                    , 59, 
#nullable restore
#line 29 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                                                                  currencyIcon

#line default
#line hidden
#nullable disable
                                    , 60, 
#nullable restore
#line 29 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                                                                                           InputType.Text

#line default
#line hidden
#nullable disable
                                    , 61, 
#nullable restore
#line 30 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                                CultureInfo.InvariantCulture

#line default
#line hidden
#nullable disable
                                    , 62, 
#nullable restore
#line 31 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                                      Color.Warning

#line default
#line hidden
#nullable disable
                                    , 63, "color:coral; font-weight:500", 64, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                                                                                                  args=> { FormatAmount(formatAmount); }

#line default
#line hidden
#nullable disable
                                    ), 65, 
#nullable restore
#line 28 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                                    formatAmount

#line default
#line hidden
#nullable disable
                                    , 66, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => formatAmount = __value, formatAmount)));
                                    __builder7.AddMarkupContent(67, "\r\n\r\n                        ");
                                    __Blazor.HPoc.Web.Pages.Register.Register.TypeInference.CreateMudTextField_1(__builder7, 68, 69, "Max. 8 characters ", 70, 
#nullable restore
#line 34 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                             () => model.Name

#line default
#line hidden
#nullable disable
                                    , 71, "Full Name", 72, 
#nullable restore
#line 34 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                                                                           Variant.Outlined

#line default
#line hidden
#nullable disable
                                    , 73, 
#nullable restore
#line 33 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                                                                   model.Name

#line default
#line hidden
#nullable disable
                                    , 74, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Name = __value, model.Name)));
                                    __builder7.AddMarkupContent(75, "\r\n\r\n                        ");
                                    __Blazor.HPoc.Web.Pages.Register.Register.TypeInference.CreateMudTextField_2(__builder7, 76, 77, "Email", 78, "mt-3", 79, 
#nullable restore
#line 37 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                             () => model.Email

#line default
#line hidden
#nullable disable
                                    , 80, 
#nullable restore
#line 37 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                                                          Variant.Outlined

#line default
#line hidden
#nullable disable
                                    , 81, 
#nullable restore
#line 36 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                                   model.Email

#line default
#line hidden
#nullable disable
                                    , 82, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Email = __value, model.Email)));
                                    __builder7.AddMarkupContent(83, "\r\n\r\n                        ");
                                    __Blazor.HPoc.Web.Pages.Register.Register.TypeInference.CreateMudTextField_3(__builder7, 84, 85, 
#nullable restore
#line 40 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                             () => model.PhoneNumber

#line default
#line hidden
#nullable disable
                                    , 86, "Phone Number", 87, 
#nullable restore
#line 40 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                                                                                     Variant.Outlined

#line default
#line hidden
#nullable disable
                                    , 88, 
#nullable restore
#line 39 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                                   model.PhoneNumber

#line default
#line hidden
#nullable disable
                                    , 89, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.PhoneNumber = __value, model.PhoneNumber)));
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(90, "\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudText>(91);
                            __builder5.AddAttribute(92, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 45 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                               Typo.body2

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(93, "Align", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Align>(
#nullable restore
#line 45 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                                  Align.Center

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(94, "Class", "my-4");
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(95, "\r\n\r\n                ");
                            __builder5.OpenComponent<MudBlazor.MudExpansionPanels>(96);
                            __builder5.AddAttribute(97, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenComponent<MudBlazor.MudExpansionPanel>(98);
                                __builder6.AddAttribute(99, "Text", "Show Validation Summary");
                                __builder6.AddAttribute(100, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
#nullable restore
#line 51 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                         if (success)
                        {

#line default
#line hidden
#nullable disable
                                    __builder7.OpenComponent<MudBlazor.MudText>(101);
                                    __builder7.AddAttribute(102, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 53 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                            Color.Success

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(103, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddContent(104, "Success");
                                    }
                                    ));
                                    __builder7.CloseComponent();
#nullable restore
#line 54 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                                    __builder7.OpenComponent<MudBlazor.MudText>(105);
                                    __builder7.AddAttribute(106, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 57 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                             Color.Error

#line default
#line hidden
#nullable disable
                                    ));
                                    __builder7.AddAttribute(107, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(108);
                                        __builder8.CloseComponent();
                                    }
                                    ));
                                    __builder7.CloseComponent();
#nullable restore
#line 60 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                        }

#line default
#line hidden
#nullable disable
                                }
                                ));
                                __builder6.CloseComponent();
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(109, "\r\n\r\n            ");
                        __builder4.OpenComponent<MudBlazor.MudCardActions>(110);
                        __builder4.AddAttribute(111, "Class", "d-flex justify-center");
                        __builder4.AddAttribute(112, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.OpenComponent<MudBlazor.MudButton>(113);
                            __builder5.AddAttribute(114, "ButtonType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.ButtonType>(
#nullable restore
#line 68 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                       ButtonType.Submit

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(115, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 68 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                                                   Variant.Filled

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(116, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 69 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                  Color.Primary

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(117, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 69 "C:\Users\Surface\Documents\Clients\HalalPay\HPoc\HPoc\hpoc\HPoc.Web\Pages\Register\Register.razor"
                                                       Size.Large

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.AddAttribute(118, "Style", "width:50%;");
                            __builder5.AddAttribute(119, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(120, "Create Account");
                            }
                            ));
                            __builder5.CloseComponent();
                        }
                        ));
                        __builder4.CloseComponent();
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
namespace __Blazor.HPoc.Web.Pages.Register.Register
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.Adornment __arg2, int __seq3, global::System.String __arg3, int __seq4, global::MudBlazor.InputType __arg4, int __seq5, global::System.Globalization.CultureInfo __arg5, int __seq6, global::MudBlazor.Color __arg6, int __seq7, global::System.String __arg7, int __seq8, global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.FocusEventArgs> __arg8, int __seq9, T __arg9, int __seq10, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg10)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Adornment", __arg2);
        __builder.AddAttribute(__seq3, "AdornmentText", __arg3);
        __builder.AddAttribute(__seq4, "InputType", __arg4);
        __builder.AddAttribute(__seq5, "Culture", __arg5);
        __builder.AddAttribute(__seq6, "AdornmentColor", __arg6);
        __builder.AddAttribute(__seq7, "Style", __arg7);
        __builder.AddAttribute(__seq8, "OnBlur", __arg8);
        __builder.AddAttribute(__seq9, "Value", __arg9);
        __builder.AddAttribute(__seq10, "ValueChanged", __arg10);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg1, int __seq2, global::System.String __arg2, int __seq3, global::MudBlazor.Variant __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "HelperText", __arg0);
        __builder.AddAttribute(__seq1, "For", __arg1);
        __builder.AddAttribute(__seq2, "Label", __arg2);
        __builder.AddAttribute(__seq3, "Variant", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.String __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg2, int __seq3, global::MudBlazor.Variant __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Class", __arg1);
        __builder.AddAttribute(__seq2, "For", __arg2);
        __builder.AddAttribute(__seq3, "Variant", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<T>> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::MudBlazor.Variant __arg2, int __seq3, T __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "Variant", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
