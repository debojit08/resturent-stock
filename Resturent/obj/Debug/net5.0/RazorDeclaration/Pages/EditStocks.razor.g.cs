// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Resturent.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Debojit Paul\OneDrive\Desktop\internship\Resturent\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Debojit Paul\OneDrive\Desktop\internship\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Debojit Paul\OneDrive\Desktop\internship\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Debojit Paul\OneDrive\Desktop\internship\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Debojit Paul\OneDrive\Desktop\internship\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Debojit Paul\OneDrive\Desktop\internship\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Debojit Paul\OneDrive\Desktop\internship\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Debojit Paul\OneDrive\Desktop\internship\Resturent\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Debojit Paul\OneDrive\Desktop\internship\Resturent\_Imports.razor"
using Resturent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Debojit Paul\OneDrive\Desktop\internship\Resturent\_Imports.razor"
using Resturent.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Debojit Paul\OneDrive\Desktop\internship\Resturent\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Debojit Paul\OneDrive\Desktop\internship\Resturent\Pages\EditStocks.razor"
using Resturent.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editStocks/{CurrentId}")]
    public partial class EditStocks : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\Debojit Paul\OneDrive\Desktop\internship\Resturent\Pages\EditStocks.razor"
       
    [Parameter]
    public string CurrentId { get; set; }

    StockPurch objStock = new StockPurch();



    private DateTime mDate;
    protected override void OnInitialized()
    {
        mDate = DateTime.Now;
    }

    protected override async Task OnInitializedAsync()
    {
        objStock = await Task.Run(() => objStockPurchesService.GetStockById(Convert.ToInt32(CurrentId)));
    }

    void UpdateStocks()
    {


        objStock.MDate = mDate;
        objStockPurchesService.Update(objStock);
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
#pragma warning restore 1591
