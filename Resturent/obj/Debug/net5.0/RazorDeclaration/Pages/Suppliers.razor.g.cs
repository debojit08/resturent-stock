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
#line 2 "C:\Users\Debojit Paul\OneDrive\Desktop\internship\Resturent\Pages\Suppliers.razor"
using Resturent.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/supplier")]
    public partial class Suppliers : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 114 "C:\Users\Debojit Paul\OneDrive\Desktop\internship\Resturent\Pages\Suppliers.razor"
       



    private bool dense = false;
    private bool hover = true;
    private bool striped = false;
    private bool bordered = false;
    private string searchString = "";




    List<Supplier> objSupplier;

    private HashSet<Supplier> selectedItems = new HashSet<Supplier>();
    private HashSet<Supplier> supplier = new HashSet<Supplier>();



    //display
    private HashSet<Supplier> GetSupplier()
    {

        objSupplier = objSupplierService.GetSupplier(); //after delete display
        return supplier;
    }

    protected override async Task OnInitializedAsync()
    {
        objSupplier = await Task.Run(() => objSupplierService.GetSupplier());

    }


    //search
    private bool FilterFunc(Supplier element)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 157 "C:\Users\Debojit Paul\OneDrive\Desktop\internship\Resturent\Pages\Suppliers.razor"
                          
        if ($"{element.SupplierName}".Contains(searchString))
            return true;

        return false;
    }

    //delete
    protected void Delete(long SupplierId)
    {
        objSupplierService.Delete(SupplierId);
        GetSupplier();

    }
    //multiDelete
    protected void DeleteMulti(long[] num)
    {
        foreach (long x in num)
        {
            objSupplierService.Delete(x);
        }
        GetSupplier();
    }



    //----------------------------------------Excel export----------------------------------//


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SupplierService objSupplierService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsruntime { get; set; }
    }
}
#pragma warning restore 1591
