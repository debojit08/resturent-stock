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
#line 1 "D:\internship\Resturent\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\internship\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\internship\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\internship\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\internship\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\internship\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\internship\Resturent\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\internship\Resturent\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\internship\Resturent\_Imports.razor"
using Resturent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\internship\Resturent\_Imports.razor"
using Resturent.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\internship\Resturent\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\internship\Resturent\Pages\Variations.razor"
using Resturent.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/variation")]
    public partial class Variations : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 106 "D:\internship\Resturent\Pages\Variations.razor"
       



    private bool dense = false;
    private bool hover = true;
    private bool striped = false;
    private bool bordered = false;
    private string searchString = "";




    List<Variation> objVariation;

    private HashSet<Variation> selectedItems = new HashSet<Variation>();
    private HashSet<Variation> variation = new HashSet<Variation>();



    //display
    private HashSet<Variation> GetVariation()
    {

        objVariation = objVariationService.GetVariation(); //after delete display
        return variation;
    }

    protected override async Task OnInitializedAsync()
    {
        objVariation = await Task.Run(() => objVariationService.GetVariation());

    }


    //search
    private bool FilterFunc(Variation element)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 149 "D:\internship\Resturent\Pages\Variations.razor"
                          
        if ($"{element.VariationName}".Contains(searchString))
            return true;

        return false;
    }

    //delete
    protected void Delete(long VariationId)
    {
        objVariationService.Delete(VariationId);
        GetVariation();

    }
    //multiDelete
    protected void DeleteMulti(long[] num)
    {
        foreach (long x in num)
        {
            objVariationService.Delete(x);
        }
        GetVariation();
    }



    //----------------------------------------Excel export----------------------------------//


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private VariationService objVariationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsruntime { get; set; }
    }
}
#pragma warning restore 1591
