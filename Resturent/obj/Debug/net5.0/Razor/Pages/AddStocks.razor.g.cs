#pragma checksum "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89d2b3e9462fa75219ab98ad6deadf5a53095056"
// <auto-generated/>
#pragma warning disable 1591
namespace Resturent.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\_Imports.razor"
using Resturent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\_Imports.razor"
using Resturent.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
using Resturent.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addStocks")]
    public partial class AddStocks : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Add Stocks</h3>\r\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "form-row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group col-md-6");
            __Blazor.Resturent.Pages.AddStocks.TypeInference.CreateMudTextField_0(__builder, 6, 7, "Supplier", 8, 
#nullable restore
#line 10 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                                                                      Variant.Outlined

#line default
#line hidden
#nullable disable
            , 9, 
#nullable restore
#line 10 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                                                                                                Margin.Dense

#line default
#line hidden
#nullable disable
            , 10, "form-control", 11, 
#nullable restore
#line 10 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                       objStock.SupplierId

#line default
#line hidden
#nullable disable
            , 12, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objStock.SupplierId = __value, objStock.SupplierId)));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __builder.OpenElement(14, "fieldset");
            __builder.AddMarkupContent(15, "<legend>Add items:</legend>\r\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "form-row");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "form-group col-md-2");
            __Blazor.Resturent.Pages.AddStocks.TypeInference.CreateMudTextField_1(__builder, 20, 21, "Item Name", 22, 
#nullable restore
#line 30 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                                                                     Variant.Outlined

#line default
#line hidden
#nullable disable
            , 23, 
#nullable restore
#line 30 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                                                                                               Margin.Dense

#line default
#line hidden
#nullable disable
            , 24, "form-control", 25, 
#nullable restore
#line 30 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                       objStock.ItemName

#line default
#line hidden
#nullable disable
            , 26, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objStock.ItemName = __value, objStock.ItemName)));
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\r\n        ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "form-group col-md-2");
            __Blazor.Resturent.Pages.AddStocks.TypeInference.CreateMudTextField_2(__builder, 30, 31, "Qty", 32, 
#nullable restore
#line 34 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                                                          Variant.Outlined

#line default
#line hidden
#nullable disable
            , 33, 
#nullable restore
#line 34 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                                                                                    Margin.Dense

#line default
#line hidden
#nullable disable
            , 34, "form-control", 35, 
#nullable restore
#line 34 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                       objStock.Qty

#line default
#line hidden
#nullable disable
            , 36, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objStock.Qty = __value, objStock.Qty)));
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n\r\n\r\n        ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "form-group col-md-2");
            __builder.OpenComponent<MudBlazor.MudSelect<String>>(40);
            __builder.AddAttribute(41, "Label", "Unit");
            __builder.AddAttribute(42, "Strict", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 44 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                                                                   true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 44 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                                                                                  Variant.Outlined

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "Margin", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Margin>(
#nullable restore
#line 44 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                                                                                                            Margin.Dense

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "class", "form-control");
            __builder.AddAttribute(46, "Format", "F2");
            __builder.AddAttribute(47, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<String>(
#nullable restore
#line 44 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                               objStock.Unit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objStock.Unit = __value, objStock.Unit))));
            __builder.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __Blazor.Resturent.Pages.AddStocks.TypeInference.CreateMudSelectItem_3(__builder2, 50, 51, 
#nullable restore
#line 45 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                        "Kg"

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(52, "\r\n                ");
                __Blazor.Resturent.Pages.AddStocks.TypeInference.CreateMudSelectItem_4(__builder2, 53, 54, 
#nullable restore
#line 46 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                        "Gr"

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(55, "\r\n                ");
                __Blazor.Resturent.Pages.AddStocks.TypeInference.CreateMudSelectItem_5(__builder2, 56, 57, 
#nullable restore
#line 47 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                        "Lt"

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n\r\n        ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "form-group col-md-2");
            __Blazor.Resturent.Pages.AddStocks.TypeInference.CreateMudTextField_6(__builder, 61, 62, "Price Per Unit", 63, 
#nullable restore
#line 53 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                                                                              Variant.Outlined

#line default
#line hidden
#nullable disable
            , 64, 
#nullable restore
#line 53 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                                                                                                        Margin.Dense

#line default
#line hidden
#nullable disable
            , 65, "form-control", 66, 
#nullable restore
#line 53 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                       objStock.PricePerUnit

#line default
#line hidden
#nullable disable
            , 67, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objStock.PricePerUnit = __value, objStock.PricePerUnit)));
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n\r\n\r\n        ");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "form-group col-md-2");
            __Blazor.Resturent.Pages.AddStocks.TypeInference.CreateMudTextField_7(__builder, 71, 72, "Amount", 73, 
#nullable restore
#line 58 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                                                                Variant.Outlined

#line default
#line hidden
#nullable disable
            , 74, 
#nullable restore
#line 58 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                                                                                          Margin.Dense

#line default
#line hidden
#nullable disable
            , 75, "form-control", 76, 
#nullable restore
#line 58 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                       objStock.Amount

#line default
#line hidden
#nullable disable
            , 77, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objStock.Amount = __value, objStock.Amount)));
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n\r\n        ");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "form-group col-md-2");
            __builder.OpenComponent<MudBlazor.MudButton>(81);
            __builder.AddAttribute(82, "Variant", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Variant>(
#nullable restore
#line 62 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                Variant.Outlined

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "Icon", 
#nullable restore
#line 62 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                                         Icons.Material.Filled.Add

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(84, "Size", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Size>(
#nullable restore
#line 62 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                                                                          Size.Medium

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(85, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 62 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                                                                                              Color.Secondary

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(86, "Class", "ma-2");
            __builder.AddAttribute(87, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(88, "Add More");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n        ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "form-row");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "form-group col-md-3");
            __Blazor.Resturent.Pages.AddStocks.TypeInference.CreateMudTextField_8(__builder, 94, 95, "CGST", 96, 
#nullable restore
#line 71 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                                                                Variant.Outlined

#line default
#line hidden
#nullable disable
            , 97, 
#nullable restore
#line 71 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                                                                                          Margin.Dense

#line default
#line hidden
#nullable disable
            , 98, "form-control", 99, 
#nullable restore
#line 71 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                           objStock.Cgst

#line default
#line hidden
#nullable disable
            , 100, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objStock.Cgst = __value, objStock.Cgst)));
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n        \r\n        \r\n            ");
            __builder.OpenElement(102, "div");
            __builder.AddAttribute(103, "class", "form-group col-md-3");
            __Blazor.Resturent.Pages.AddStocks.TypeInference.CreateMudTextField_9(__builder, 104, 105, "SGST", 106, 
#nullable restore
#line 76 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                                                                Variant.Outlined

#line default
#line hidden
#nullable disable
            , 107, 
#nullable restore
#line 76 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                                                                                          Margin.Dense

#line default
#line hidden
#nullable disable
            , 108, "form-control", 109, 
#nullable restore
#line 76 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                           objStock.Sgst

#line default
#line hidden
#nullable disable
            , 110, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objStock.Sgst = __value, objStock.Sgst)));
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n        \r\n            ");
            __builder.OpenElement(112, "div");
            __builder.AddAttribute(113, "class", "form-group col-md-3");
            __Blazor.Resturent.Pages.AddStocks.TypeInference.CreateMudTextField_10(__builder, 114, 115, "Total Amount", 116, 
#nullable restore
#line 80 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                                                                               Variant.Outlined

#line default
#line hidden
#nullable disable
            , 117, 
#nullable restore
#line 80 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                                                                                                         Margin.Dense

#line default
#line hidden
#nullable disable
            , 118, "form-control", 119, 
#nullable restore
#line 80 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                           objStock.TotalAmount

#line default
#line hidden
#nullable disable
            , 120, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => objStock.TotalAmount = __value, objStock.TotalAmount)));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n        ");
            __builder.OpenElement(122, "div");
            __builder.AddAttribute(123, "class", "form-row");
            __builder.OpenElement(124, "div");
            __builder.AddAttribute(125, "class", "form-group col-md-2");
            __builder.AddMarkupContent(126, "<label for=\"inputPassword4\">Payment Status</label>\r\n                ");
            __builder.OpenElement(127, "label");
            __builder.AddAttribute(128, "class", "switch");
            __builder.OpenElement(129, "input");
            __builder.AddAttribute(130, "type", "checkbox");
            __builder.AddAttribute(131, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 88 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                                  PaymentType

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(132, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => PaymentType = __value, PaymentType));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n                    <span class=\"slider round\"></span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n        ");
            __builder.OpenElement(135, "div");
            __builder.AddAttribute(136, "class", "row");
            __builder.OpenElement(137, "div");
            __builder.AddAttribute(138, "class", "col-md-4");
            __builder.OpenElement(139, "div");
            __builder.AddAttribute(140, "class", "form-group");
            __builder.OpenElement(141, "input");
            __builder.AddAttribute(142, "type", "button");
            __builder.AddAttribute(143, "class", "btn btn-primary");
            __builder.AddAttribute(144, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 97 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                                                            CreateStocks

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(145, "value", "save");
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n                    ");
            __builder.OpenElement(147, "input");
            __builder.AddAttribute(148, "type", "button");
            __builder.AddAttribute(149, "class", "btn");
            __builder.AddAttribute(150, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 98 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
                                                                Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(151, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 119 "C:\Users\Debojit Paul\OneDrive\Desktop\Stock-resturent\Resturent\Pages\AddStocks.razor"
       






    StockPurch objStock = new StockPurch();

    private bool hover = true;
    private DateTime eDate;
    public bool PaymentType;


    protected override void OnInitialized()
    {
        eDate = DateTime.Now;
    }

    void CreateStocks()
    {
        objStock.EDate = eDate;
        objStock.MDate = null;
        objStock.PaymentType = PaymentType ? true : false;
        // objVariation.IsAdmin = isAdmin ? true : false;
        //objSupplier.Status = status ? true : false;
        objStockPurchesService.Create(objStock);
        NavigationManager.NavigateTo("stockPurches");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("stockPurches");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StockPurchesService objStockPurchesService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SupplierService objSupplierService { get; set; }
    }
}
namespace __Blazor.Resturent.Pages.AddStocks
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.Margin __arg2, int __seq3, System.Object __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Margin", __arg2);
        __builder.AddAttribute(__seq3, "class", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.Margin __arg2, int __seq3, System.Object __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Margin", __arg2);
        __builder.AddAttribute(__seq3, "class", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.Margin __arg2, int __seq3, System.Object __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Margin", __arg2);
        __builder.AddAttribute(__seq3, "class", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_3<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_4<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudSelectItem_5<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0)
        {
        __builder.OpenComponent<global::MudBlazor.MudSelectItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_6<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.Margin __arg2, int __seq3, System.Object __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Margin", __arg2);
        __builder.AddAttribute(__seq3, "class", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_7<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.Margin __arg2, int __seq3, System.Object __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Margin", __arg2);
        __builder.AddAttribute(__seq3, "class", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_8<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.Margin __arg2, int __seq3, System.Object __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Margin", __arg2);
        __builder.AddAttribute(__seq3, "class", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_9<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.Margin __arg2, int __seq3, System.Object __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Margin", __arg2);
        __builder.AddAttribute(__seq3, "class", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateMudTextField_10<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::MudBlazor.Variant __arg1, int __seq2, global::MudBlazor.Margin __arg2, int __seq3, System.Object __arg3, int __seq4, T __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg5)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Label", __arg0);
        __builder.AddAttribute(__seq1, "Variant", __arg1);
        __builder.AddAttribute(__seq2, "Margin", __arg2);
        __builder.AddAttribute(__seq3, "class", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
